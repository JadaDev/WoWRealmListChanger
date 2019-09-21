using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWRealmListChanger
{
    public partial class CMessageBox : Form
    {
        public CMessageBox()
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

        ///<summary>
        ///Parameters:
        ///Title,
        ///Text,
        ///Title Color,
        ///Text Color
        ///</summary>
        public DialogResult Show(string m_title, string m_text, Color? m_title_forecolor = null, Color? m_text_color = null, bool alert = false)
        {
            LabelTitle.Text = m_title;
            LabelTitle.ForeColor = m_title_forecolor ?? LabelTitle.ForeColor;

            LabelMessage.Text = m_text;
            LabelMessage.ForeColor = m_text_color ?? LabelMessage.ForeColor;

            if (alert)
            {
                BtnOK.Show();
                BtnYES.Hide();
                BtnNO.Hide();
            }
            else
            {
                BtnOK.Hide();
                BtnYES.Show();
                BtnNO.Show();
            }

            return ShowDialog();
        }

        private void CMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
