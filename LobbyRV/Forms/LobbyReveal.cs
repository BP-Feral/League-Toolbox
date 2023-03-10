using Ekko;
using Microsoft.VisualBasic;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace LobbyRV.Forms
{
    public partial class LobbyReveal : Form
    {
        private List<LobbyHandler> _handlers = new List<LobbyHandler>();
        private bool _update = true;
        private bool show_link = false;
        string[] validLinks = new string[]
        {
            "https://www.op.gg/multisearch/BR?summoners=",
            "https://www.op.gg/multisearch/EUNE?summoners=",
            "https://www.op.gg/multisearch/EUW?summoners=",
            "https://www.op.gg/multisearch/LAN?summoners=",
            "https://www.op.gg/multisearch/LAS?summoners=",
            "https://www.op.gg/multisearch/NA?summoners=",
            "https://www.op.gg/multisearch/OCE?summoners=",
            "https://www.op.gg/multisearch/RU?summoners=",
            "https://www.op.gg/multisearch/TR?summoners=",
            "https://www.op.gg/multisearch/JP?summoners=",
            "https://www.op.gg/multisearch/KR?summoners=",
            "https://www.op.gg/multisearch/PH?summoners=",
            "https://www.op.gg/multisearch/SG?summoners=",
            "https://www.op.gg/multisearch/TW?summoners=",
            "https://www.op.gg/multisearch/TH?summoners=",
            "https://www.op.gg/multisearch/VVN?summoners=",
            "https://www.op.gg/multisearch/PBE?summoners="
        };
        public LobbyReveal()
        {
            InitializeComponent();
            lblMessage.Text = "Looking for data";
            lblLink.Visible = false;
            btnCopy.Enabled = false;
            
            var watcher = new LeagueClientWatcher();
            watcher.OnLeagueClient += (clientWatcher, client) =>
            {
                var handler = new LobbyHandler(new LeagueApi(client.ClientAuthInfo.RiotClientAuthToken,
                client.ClientAuthInfo.RiotClientPort));
                _handlers.Add(handler);
                handler.OnUpdate += (lobbyHandler, names) => { _update = true; };
                handler.Start();
                _update = true;
            };

            if (!Variables.LobbyHandlerVisited)
            {
                new Thread(async () => { await watcher.Observe(); })
                {
                    IsBackground = true
                }.Start();

                new Thread(() => { Refresher(); })
                {
                    IsBackground = true
                }.Start();

                new Thread(() => { AutoRefresh(); })
                {
                    IsBackground = true
                }.Start();

            }

        }

        private void AutoRefresh()
        {

            while (true)
            {
                if (_handlers.Count < 1)
                {
                    if (lblMessage.InvokeRequired)
                        try
                        {
                            lblMessage.Invoke(new MethodInvoker(delegate
                            {
                                lblMessage.Text = "No connections detected. Make sure you have at least one client open. \n (Link and summoners will load after you connect to lobby ('Connecting...'))";
                                lblMessage.Visible = true;
                            }));
                        }
                        catch (System.ObjectDisposedException ex) { Console.WriteLine(ex.ToString()); /* continue */}
                    _update = true;
                }
                else
                {
                    var region = _handlers[0].GetRegion();
                    var link = $"https://www.op.gg/multisearch/{region ?? LobbyRV.Region.EUW}?summoners=" + HttpUtility.UrlEncode($"{string.Join(",", _handlers[0].GetSummoners())}");

                    if (validLinks.Contains(link.ToString()))
                        show_link = false; else show_link = true;

                    if (lblLink.InvokeRequired)
                        try
                        {
                            lblLink.Invoke(new MethodInvoker(delegate
                            {
                                lblLink.Text = link.ToString();
                                lblLink.Visible = show_link;
                                if(show_link)
                                    btnCopy.Enabled = true;
                            }));
                        }
                        catch (System.ObjectDisposedException ex) { Console.WriteLine(ex.ToString()); /* continue */}
                    _update = true;
                }
                Thread.Sleep(200);
            }
        }

        private void Refresher()
        {
            while (true)
            {
                if (_update)
                {
                    if (listBox.InvokeRequired)
                        try
                        {
                            listBox.Invoke(new MethodInvoker(delegate
                            {
                                listBox.Items.Clear();
                            }));
                        }
                        catch (System.ObjectDisposedException ex) { Console.WriteLine(ex.ToString()); /* continue */}

                    for (int i = 0; i < _handlers.Count; i++)
                    {
                        var link = $"https://www.op.gg/multisearch/{_handlers[i].GetRegion() ?? LobbyRV.Region.EUW}?summoners=" + HttpUtility.UrlEncode($"{string.Join(",", _handlers[i].GetSummoners())}");

                        if (listBox.InvokeRequired)
                            listBox.Invoke(new MethodInvoker(delegate
                            {
                                string[] summoners = _handlers[i].GetSummoners();
                                foreach (string summoner in summoners)
                                {
                                    if (summoner != null)
                                    {
                                        listBox.Items.Add(summoner);
                                    }
                                    Console.WriteLine(summoner);
                                }
                            }));

                        if (lblLink.InvokeRequired)
                            lblLink.Invoke(new MethodInvoker(delegate
                            {
                                lblLink.Text = link.ToString();
                            }));
                    }
                    _update = false;
                }

                Thread.Sleep(200);
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lblLink.Text);
            Clipboard.SetText(lblLink.Text.ToString());
            btnCopy.Text = ("Copied!");
        }
    }
}