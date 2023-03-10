namespace LobbyRV.Forms
{
    partial class LobbyReveal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.panel_0 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.lblMessage.Location = new System.Drawing.Point(0, 338);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(848, 64);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "label1";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopy.Location = new System.Drawing.Point(0, 402);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(848, 59);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Coppy link to Clippboard";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(848, 50);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Team Participants";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.Info;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 21;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(848, 225);
            this.listBox.TabIndex = 4;
            // 
            // lblLink
            // 
            this.lblLink.BackColor = System.Drawing.SystemColors.Control;
            this.lblLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLink.Location = new System.Drawing.Point(0, 275);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(848, 63);
            this.lblLink.TabIndex = 6;
            this.lblLink.Text = "no data";
            this.lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_0
            // 
            this.panel_0.BackColor = System.Drawing.SystemColors.Control;
            this.panel_0.Controls.Add(this.btnCopy);
            this.panel_0.Controls.Add(this.lblMessage);
            this.panel_0.Controls.Add(this.lblLink);
            this.panel_0.Controls.Add(this.panel1);
            this.panel_0.Controls.Add(this.lblTitle);
            this.panel_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_0.Location = new System.Drawing.Point(0, 0);
            this.panel_0.Name = "panel_0";
            this.panel_0.Size = new System.Drawing.Size(848, 462);
            this.panel_0.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.listBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 225);
            this.panel1.TabIndex = 7;
            // 
            // LobbyReveal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 462);
            this.Controls.Add(this.panel_0);
            this.Name = "LobbyReveal";
            this.Text = "LobbyReveal";
            this.panel_0.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblMessage;
        private Button btnCopy;
        private Label lblTitle;
        private ListBox listBox;
        private Label lblLink;
        private Panel panel_0;
        private Panel panel1;
    }
}