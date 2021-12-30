using iRacingSettingsManager.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace iRacingSettingsManager.Windows
{
    public partial class MainWindow : Form
    {
        public static string DownloadLink = "https://github.com/byBlurr/iRacingSettingsManager/releases";
        public static string Version = "v21.9.3";

        public static string IRFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "iRacing");
        public static string IRConfigPath = Path.Combine(IRFolder, "app.ini");
        public static string SMFolder = Path.Combine(IRFolder, "blurr", "configs");
        public static string SMConfigPath = Path.Combine(SMFolder, "app");

        private List<IRConfig> Configs = new List<IRConfig>();

        public MainWindow()
        {
            InitializeComponent();

            // Make sure our folders exist
            if (!Directory.Exists(SMFolder)) Directory.CreateDirectory(SMFolder);
            if (!Directory.Exists(SMConfigPath)) Directory.CreateDirectory(SMConfigPath);

            LoadConfigs();
        }

        private void LoadConfigs()
        {
            // Get list of app.ini files
            Configs.Clear();

            if (Directory.Exists(SMConfigPath))
            {
                foreach (string path in Directory.GetFiles(SMConfigPath))
                {
                    if (path.ToLower().EndsWith(".ini"))
                    {
                        string configFile = path.Split('\\').Last();
                        string configName = configFile.Substring(0, configFile.Length - 4);
                        Configs.Add(new IRConfig(configFile, configName));
                    }
                }
            }

            ConfigsData.ClearSelection();
            ConfigsData.Rows.Clear();

            foreach (var conf in Configs)
            {
                ConfigsData.Rows.Add(conf.Name, conf.File);
            }
        }

        private void SaveConfigButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(IRConfigPath))
            {
                if (string.IsNullOrEmpty(ConfigNameBox.Text))
                {
                    MessageBox.Show("You need to provide a name for the config.", "Error");
                    return;
                }

                string newName = ConfigNameBox.Text + ".ini";

                if (File.Exists(Path.Combine(SMConfigPath, newName)))
                {
                    MessageBox.Show("A config already exists with this name...", "Error");
                    return;
                }

                File.Copy(IRConfigPath, Path.Combine(SMConfigPath, newName));
                LoadConfigs();
            }
            else
            {
                MessageBox.Show("Your app.ini can't be found...", "Error");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (ConfigsData.Rows.Count <= 0)
            {
                MessageBox.Show("No valid configs to load...", "Error loading config...");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to load the '{ConfigsData.SelectedRows[0].Cells[0].Value.ToString()}' config? Make sure your current config is saved!", "Load Config?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            if (File.Exists(IRConfigPath))
            {
                //string path = Path.Combine(SMConfigPath, $"backup-{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}_{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.ini");
                //if (File.Exists(path)) File.Delete(path);
                //File.Copy(IRConfigPath, path);

                LoadConfigs();
                File.Delete(IRConfigPath);
            }

            string file = ConfigsData.SelectedRows[0].Cells[1].Value.ToString();
            File.Copy(Path.Combine(SMConfigPath, file), IRConfigPath);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ConfigsData.Rows.Count <= 0)
            {
                MessageBox.Show("No valid configs to load...", "Error loading config...");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the '{ConfigsData.SelectedRows[0].Cells[0].Value.ToString()}' config?", "Delete Config?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            string file = ConfigsData.SelectedRows[0].Cells[1].Value.ToString();
            File.Delete(Path.Combine(SMConfigPath, file));
            LoadConfigs();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ConfigsData.Rows.Count <= 0)
            {
                MessageBox.Show("No valid configs to edit...", "Error editing config...");
                return;
            }

            string file = ConfigsData.SelectedRows[0].Cells[1].Value.ToString();
            string data = File.ReadAllText(Path.Combine(SMConfigPath, file));
            Dictionary<string, Dictionary<string, string>> config = Reader.ReadConfig(data);

            foreach (KeyValuePair<string, Dictionary<string, string>> item in config)
            {
                Debug.WriteLine($"{item.Key}:");
                foreach (var setting in item.Value)
                {
                    Debug.WriteLine($"{setting.Key} == {setting.Value}");
                }
            }

            MessageBox.Show("Functionality has not yet been implemented. You will be able to easily modify your setups!", "Unimplemented Feature");

            return;
        }

        private void OptionsMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // TODO: Check for updates...
            MessageBox.Show($"Functionality has not yet been implemented. Check {DownloadLink} for updates for now!", "Unimplemented Feature");
            return;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Settings not changing in iRacing? Make sure your simulator is closed when you load a new config.\n\n" +
                $"If you have any issues/bugs or need help, message Blurr#9789 on Discord.\n\n" +
                $"You are running iRacingSettingsManager {Version}", "Help");
            return;
        }
    }

    class IRConfig
    {
        public string File { get; set; }
        public string Name { get; set; }

        public IRConfig(string file, string name)
        {
            File = file;
            Name = name;
        }
    }
}
