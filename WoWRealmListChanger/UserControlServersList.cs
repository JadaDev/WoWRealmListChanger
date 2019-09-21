using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WoWRealmListChanger
{
    public partial class UserControlServersList : UserControl
    {
        public UserControlServersList()
        {
            InitializeComponent();
        }

        private void UpdateWoWConfigAndStart(string WoWPath, string realmlist, string account, bool cache)
        {
            using (var outputFile = new StreamWriter(WoWPath + @"\WTF\Config.wtf", true))
                outputFile.WriteLine("SET realmList " + realmlist);

            using (var outputFile = new StreamWriter(WoWPath + @"\WTF\Config.wtf", true))
                outputFile.WriteLine("SET accountName " + account);

            if (cache && Directory.Exists(WoWPath + @"\Cache"))
            {
                var dir = new DirectoryInfo(WoWPath + @"\Cache");
                dir.Delete(true); // true => recursive delete
            }

            try
            {
                if (!File.Exists(WoWPath + @"\Wow.exe"))
                {
                    CMessageBox myAlertBox = new CMessageBox();
                    myAlertBox.Show("Alertbox", "The WoW.exe file could not be located!", Color.Red, Color.IndianRed, true);
                    myAlertBox.Dispose();
                    return;
                }
                else
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = WoWPath + @"\Wow.exe";
                    proc.Start();
                }
            }
            catch (Exception ex)
            {
                CMessageBox myAlertBox = new CMessageBox();
                myAlertBox.Show("Alertbox", ex.Message, Color.Red, Color.IndianRed, true);
                myAlertBox.Dispose();
            }
        }

        private void UserControlServersList_Load(object sender, EventArgs e)
        {
            try
            {
                // load data into servers list
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Properties.Settings.Default.XMLServersListFile);

                // Begin Servers List Update
                LbServersList.BeginUpdate();

                // Clear Servers List
                LbServersList.Items.Clear();

                foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                    LbServersList.Items.Add(node.Attributes["name"].InnerText);

                // set a selected index if none
                if (LbServersList.SelectedIndex == -1)
                    LbServersList.SelectedIndex = 0;

                // End Servers List Update
                LbServersList.EndUpdate();

                // set current selected server id
                LbServersList.SelectedItem = Properties.Settings.Default.SelectedServer;
                Properties.Settings.Default.SelectedServer = LbServersList.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            }
            catch(Exception ex)
            {
                CMessageBox myAlertBox = new CMessageBox();
                myAlertBox.Show("Alertbox", ex.Message, Color.Red, Color.IndianRed, true);
                myAlertBox.Dispose();
            }
        }

        private void LbServersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedServer = LbServersList.SelectedItem.ToString();

            Properties.Settings.Default.Save();

            if (LbServersList.SelectedIndex >= 0)
            {
                BtnAddorModify.Enabled = true;
                BtnDelete.Enabled = true;
                BtnPlay.Enabled = true;
            }
            else
            {
                BtnAddorModify.Enabled = false;
                BtnDelete.Enabled = false;
                BtnPlay.Enabled = false;
            }
        }

        private void BtnAddorModify_Click(object sender, EventArgs e)
        {
            WoWRealmListChanger MWL = (WoWRealmListChanger)FindForm();
            MWL.ClearDisplayPanel();
            MWL.PanelDisplay.Controls.Add(new UserControlEditServer());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CMessageBox myCMessageBox = new CMessageBox();
                DialogResult result = myCMessageBox.Show("Confirm Removal", "Do you really want to remove that server?");
                if (result == DialogResult.Yes)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(Properties.Settings.Default.XMLServersListFile);
                    XmlNodeList nodes = xmlDoc.SelectNodes("/Servers/Server");
                    XmlNode parent = xmlDoc.SelectSingleNode("/Servers");

                    foreach (XmlNode node in nodes)
                    {
                        if (node.Attributes["name"].InnerText == Properties.Settings.Default.SelectedServer)
                        {
                            parent.RemoveChild(node);
                        }
                    }

                    xmlDoc.Save(Properties.Settings.Default.XMLServersListFile);

                    WoWRealmListChanger MWL = (WoWRealmListChanger)FindForm();
                    MWL.ClearDisplayPanel();
                    MWL.PanelDisplay.Controls.Add(new UserControlServersList());
                }
                myCMessageBox.Dispose();
            }
            catch(Exception ex)
            {
                CMessageBox myAlertBox = new CMessageBox();
                myAlertBox.Show("Alertbox", ex.Message, Color.Red, Color.IndianRed, true);
                myAlertBox.Dispose();
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Properties.Settings.Default.XMLServersListFile);
            XmlNodeList nodes = xmlDoc.SelectNodes("/Servers/Server");
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes["name"].InnerText == Properties.Settings.Default.SelectedServer)
                {
                    UpdateWoWConfigAndStart
                    (
                        node["WoWPath"].InnerText,
                        node["Realmlist"].InnerText,
                        Convert.ToBoolean(node.Attributes["fill"].InnerText) ? node["Account"].InnerText : string.Empty,
                        Convert.ToBoolean(node.Attributes["cache"].InnerText)
                    );
                }
            }
            xmlDoc.Save(Properties.Settings.Default.XMLServersListFile);

            WoWRealmListChanger MWL = (WoWRealmListChanger)FindForm();
            // send app to system tray
            MWL.WindowState = FormWindowState.Minimized;
            MWL.notifyIcon.ShowBalloonTip(1000);
        }
    }
}
