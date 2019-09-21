namespace WoWRealmListChanger
{
    partial class UserControlServersList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbServersList = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAddorModify = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbServersList
            // 
            this.LbServersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.LbServersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LbServersList.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbServersList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbServersList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.LbServersList.FormattingEnabled = true;
            this.LbServersList.ItemHeight = 18;
            this.LbServersList.Items.AddRange(new object[] {
            "adadaweawe",
            "eaweaweaweawe",
            "334123112"});
            this.LbServersList.Location = new System.Drawing.Point(0, 0);
            this.LbServersList.Name = "LbServersList";
            this.LbServersList.Size = new System.Drawing.Size(530, 252);
            this.LbServersList.TabIndex = 0;
            this.LbServersList.SelectedIndexChanged += new System.EventHandler(this.LbServersList_SelectedIndexChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(98, 268);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(89, 28);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAddorModify
            // 
            this.BtnAddorModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(120)))), ((int)(((byte)(90)))));
            this.BtnAddorModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddorModify.FlatAppearance.BorderSize = 0;
            this.BtnAddorModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddorModify.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnAddorModify.ForeColor = System.Drawing.Color.White;
            this.BtnAddorModify.Location = new System.Drawing.Point(3, 268);
            this.BtnAddorModify.Name = "BtnAddorModify";
            this.BtnAddorModify.Size = new System.Drawing.Size(89, 28);
            this.BtnAddorModify.TabIndex = 19;
            this.BtnAddorModify.Text = "Add / Modify";
            this.BtnAddorModify.UseVisualStyleBackColor = false;
            this.BtnAddorModify.Click += new System.EventHandler(this.BtnAddorModify_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlay.FlatAppearance.BorderSize = 0;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.ForeColor = System.Drawing.Color.Black;
            this.BtnPlay.Location = new System.Drawing.Point(403, 258);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(127, 38);
            this.BtnPlay.TabIndex = 22;
            this.BtnPlay.Text = "PLAY";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // UserControlServersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnAddorModify);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LbServersList);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UserControlServersList";
            this.Size = new System.Drawing.Size(530, 300);
            this.Load += new System.EventHandler(this.UserControlServersList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox LbServersList;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAddorModify;
        private System.Windows.Forms.Button BtnPlay;
    }
}
