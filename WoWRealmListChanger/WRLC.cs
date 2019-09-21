using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace WoWRealmListChanger
{
    public partial class WoWRealmListChanger : Form
    {
        public WoWRealmListChanger()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public void ClearDisplayPanel()
        {
            foreach (Control item in PanelDisplay.Controls.OfType<UserControl>())
            {
                PanelDisplay.Controls.Remove(item);
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MyBtn_MouseEnter(object sender, EventArgs e)
        {
            Label pButton = (Label)sender;
            pButton.ForeColor = Color.Gold;
        }

        private void MyBtn_MouseLeave(object sender, EventArgs e)
        {
            Label pButton = (Label)sender;
            pButton.ForeColor = Color.White;
        }

        private void WoWRealmListChanger_Load(object sender, EventArgs e)
        {
            ClearDisplayPanel();
            PanelDisplay.Controls.Add(new UserControlServersList());

            notifyIcon.ContextMenuStrip = contextMenuStrip;
        }

        private void WoWRealmListChanger_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void ExiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            // send app to system tray
            WindowState = FormWindowState.Minimized;
            notifyIcon.ShowBalloonTip(1000);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
