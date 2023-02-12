using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Ekko;
using Spectre.Console;

namespace LobbyRV
{
    internal class Program
    {
        public async static Task Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMainMenu());
        }
    }
}