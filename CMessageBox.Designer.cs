namespace WoWRealmListChanger
{
    partial class CMessageBox
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.BtnYES = new System.Windows.Forms.Button();
            this.BtnNO = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(417, 25);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "Custom Alert";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CMessageBox_MouseDown);
            // 
            // LabelMessage
            // 
            this.LabelMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelMessage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.LabelMessage.Location = new System.Drawing.Point(0, 25);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(417, 94);
            this.LabelMessage.TabIndex = 13;
            this.LabelMessage.Text = "Custom Message here";
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMessage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CMessageBox_MouseDown);
            // 
            // BtnYES
            // 
            this.BtnYES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(120)))), ((int)(((byte)(90)))));
            this.BtnYES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnYES.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnYES.FlatAppearance.BorderSize = 0;
            this.BtnYES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYES.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.BtnYES.ForeColor = System.Drawing.Color.White;
            this.BtnYES.Location = new System.Drawing.Point(79, 122);
            this.BtnYES.Name = "BtnYES";
            this.BtnYES.Size = new System.Drawing.Size(80, 30);
            this.BtnYES.TabIndex = 14;
            this.BtnYES.Text = "YES";
            this.BtnYES.UseVisualStyleBackColor = false;
            // 
            // BtnNO
            // 
            this.BtnNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.BtnNO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNO.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnNO.FlatAppearance.BorderSize = 0;
            this.BtnNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNO.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.BtnNO.ForeColor = System.Drawing.Color.White;
            this.BtnNO.Location = new System.Drawing.Point(251, 122);
            this.BtnNO.Name = "BtnNO";
            this.BtnNO.Size = new System.Drawing.Size(80, 30);
            this.BtnNO.TabIndex = 15;
            this.BtnNO.Text = "NO";
            this.BtnNO.UseVisualStyleBackColor = false;
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.FlatAppearance.BorderSize = 0;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.BtnOK.ForeColor = System.Drawing.Color.White;
            this.BtnOK.Location = new System.Drawing.Point(165, 122);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(80, 30);
            this.BtnOK.TabIndex = 16;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = false;
            // 
            // CMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(417, 164);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnNO);
            this.Controls.Add(this.BtnYES);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.LabelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CMessageBox";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CMessageBox_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Button BtnYES;
        private System.Windows.Forms.Button BtnNO;
        private System.Windows.Forms.Button BtnOK;
    }
}