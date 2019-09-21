namespace WoWRealmListChanger
{
    partial class WoWRealmListChanger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WoWRealmListChanger));
            this.PanelDisplay = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LabelAppTitle = new System.Windows.Forms.Label();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDisplay
            // 
            this.PanelDisplay.ForeColor = System.Drawing.Color.White;
            this.PanelDisplay.Location = new System.Drawing.Point(12, 49);
            this.PanelDisplay.Name = "PanelDisplay";
            this.PanelDisplay.Size = new System.Drawing.Size(530, 300);
            this.PanelDisplay.TabIndex = 7;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "You can find me here!";
            this.notifyIcon.BalloonTipTitle = "Minimized";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Multi WoW Launcher";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exiToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(94, 26);
            // 
            // exiToolStripMenuItem
            // 
            this.exiToolStripMenuItem.Name = "exiToolStripMenuItem";
            this.exiToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exiToolStripMenuItem.Text = "Exit";
            this.exiToolStripMenuItem.Click += new System.EventHandler(this.ExiToolStripMenuItem_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(521, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(29, 25);
            this.BtnExit.TabIndex = 20;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LabelAppTitle
            // 
            this.LabelAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelAppTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAppTitle.ForeColor = System.Drawing.Color.White;
            this.LabelAppTitle.Location = new System.Drawing.Point(70, 9);
            this.LabelAppTitle.Name = "LabelAppTitle";
            this.LabelAppTitle.Size = new System.Drawing.Size(402, 25);
            this.LabelAppTitle.TabIndex = 21;
            this.LabelAppTitle.Text = "WoWRealmListChanger";
            this.LabelAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelAppTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.Location = new System.Drawing.Point(492, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(29, 25);
            this.BtnMinimize.TabIndex = 22;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WoWRealmListChanger.Properties.Resources.q2zxyse86xa11;
            this.pictureBox1.Location = new System.Drawing.Point(159, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // WoWRealmListChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.BtnMinimize);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.PanelDisplay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelAppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "WoWRealmListChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WoWRealmListChanger_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.Resize += new System.EventHandler(this.WoWRealmListChanger_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel PanelDisplay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exiToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LabelAppTitle;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

