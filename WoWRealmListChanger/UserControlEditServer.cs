using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WoWRealmListChanger
{
    public partial class UserControlEditServer : UserControl
    {
        public UserControlEditServer()
        {
            InitializeComponent();
        }

        private void UserControlEditServer_Load(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Properties.Settings.Default.XMLServersListFile);
                foreach (XmlNode node in xmlDoc.SelectNodes("/Servers/Server"))
                {
                    if (node.Attributes["name"].InnerText == Properties.Settings.Default.SelectedServer)
                    {
                        TxbServerName.Text = node.Attributes["name"].InnerText;
                        TxbRealmlist.Text = node["Realmlist"].InnerText;
                        TxbAccount.Text = node["Account"].InnerText;
                        TxbWoWPath.Text = node["WoWPath"].InnerText;
                        CbCache.Checked = Convert.ToBoolean(node.Attributes["cache"].InnerText);
                        CbFill.Checked = Convert.ToBoolean(node.Attributes["fill"].InnerText);
                    }
                }
            }
            catch(Exception ex)
            {
                CMessageBox myAlertBox = new CMessageBox();
                myAlertBox.Show("Alertbox", ex.Message, Color.Red, Color.IndianRed, true);
                myAlertBox.Dispose();
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            CMessageBox myCMessageBox = new CMessageBox();
            DialogResult result = myCMessageBox.Show("New Server", "Add new server to list?\n\n" + TxbServerName.Text);
            if (result == DialogResult.Yes)
            {
                bool IsDuplicate = false;

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Properties.Settings.Default.XMLServersListFile);
                XmlNodeList nodes = xmlDoc.SelectNodes("/Servers/Server");

                foreach (XmlNode node in nodes)
                    if (node.Attributes["name"].InnerText == TxbServerName.Text)
                        IsDuplicate = true;

                if (IsDuplicate)
                {
                    CMessageBox myAlertBox = new CMessageBox();
                    myAlertBox.Show("Alertbox", "That server name already exists, please chose another name!", Color.Red, Color.IndianRed, true);
                    myAlertBox.Dispose();
                }
                else
                {
                    XDocument xdoc = XDocument.Load(Properties.Settings.Default.XMLServersListFile);
                    XElement root = xdoc.Element("Servers");
                    root.Add(new XElement("Server",
                        new XAttribute("name", TxbServerName.Text),
                        new XAttribute("cache", CbCache.Checked.ToString()),
                        new XAttribute("fill", CbFill.Checked.ToString()),

                        new XElement("Realmlist", TxbRealmlist.Text),
                        new XElement("Account", TxbAccount.Text),
                        new XElement("WoWPath", TxbWoWPath.Text)
                        )
                    );

                    xdoc.Save(Properties.Settings.Default.XMLServersListFile);

                    WoWRealmListChanger MWL = (WoWRealmListChanger)FindForm();
                    MWL.ClearDisplayPanel();
                    MWL.PanelDisplay.Controls.Add(new UserControlServersList());
                }
            }
            myCMessageBox.Dispose();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            CMessageBox myCMessageBox = new CMessageBox();
            DialogResult result = myCMessageBox.Show("Edit Server", "Do you really want to modify this server?");
            if (result == DialogResult.Yes)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Properties.Settings.Default.XMLServersListFile);
                foreach (XmlNode node in xmlDoc.SelectNodes("/Servers/Server"))
                {
                    if (node.Attributes["name"].InnerText == Properties.Settings.Default.SelectedServer)
                    {
                        node.Attributes["name"].InnerText = TxbServerName.Text;
                        node["Realmlist"].InnerText = TxbRealmlist.Text;
                        node["Account"].InnerText = TxbAccount.Text;
                        node["WoWPath"].InnerText = TxbWoWPath.Text;
                        node.Attributes["cache"].InnerText = CbCache.Checked.ToString();
                        node.Attributes["fill"].InnerText = CbFill.Checked.ToString();
                    }
                }
                xmlDoc.Save(Properties.Settings.Default.XMLServersListFile);

                Properties.Settings.Default.SelectedServer = TxbServerName.Text;
                Properties.Settings.Default.Save();

                WoWRealmListChanger MWL = (WoWRealmListChanger)FindForm();
                MWL.ClearDisplayPanel();
                MWL.PanelDisplay.Controls.Add(new UserControlServersList());
            }
        }

        private void BtnServersList_Click(object sender, EventArgs e)
        {
            WoWRealmListChanger MWL = (WoWRealmListChanger)FindForm();
            MWL.ClearDisplayPanel();
            MWL.PanelDisplay.Controls.Add(new UserControlServersList());
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            string defaultPath = string.Empty;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Properties.Settings.Default.XMLServersListFile);
            foreach (XmlNode node in xmlDoc.SelectNodes("/Servers/Server"))
                if (node.Attributes["name"].InnerText == Properties.Settings.Default.SelectedServer)
                    defaultPath = node["WoWPath"].InnerText;

            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = defaultPath;
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    TxbWoWPath.Text = fbd.SelectedPath;
            }
        }
        public class WoW
        {
            public static string Directory
            {
                get
                {
                    RegistryKey registryKey = Registry.LocalMachine;
                    if (Environment.Is64BitOperatingSystem)
                        registryKey = registryKey.OpenSubKey(@"SOFTWARE\Wow6432Node\Blizzard Entertainment\World Of Warcraft");
                    else
                        registryKey = registryKey.OpenSubKey(@"SOFTWARE\Blizzard Entertainment\World Of Warcraft");
                    if (registryKey == null)
                        return null;
                    return Convert.ToString(registryKey.GetValue("InstallPath"));
                }
            }

        }
        private void DetectionWoW_Click(object sender, EventArgs e)
        {
            TxbWoWPath.Text = WoW.Directory;
            string RemoveSlash = TxbWoWPath.Text.Remove(TxbWoWPath.Text.Length - 1, 1);
            TxbWoWPath.Text = RemoveSlash;
        }
        
    }
}
