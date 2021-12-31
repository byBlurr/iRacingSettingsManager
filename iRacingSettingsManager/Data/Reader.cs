using iRacingSettingsManager.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingSettingsManager.Data
{
    public class Reader
    {
        public static Dictionary<string, Dictionary<string, string>> ReadConfig(string data)
        {
            Dictionary<string, Dictionary<string, string>> config = new Dictionary<string, Dictionary<string, string>>();
            string section = "";

            string[] lines = data.Split('\n');
            foreach (string line in lines)
            {
                if (!String.IsNullOrEmpty(line) && !String.IsNullOrWhiteSpace(line))
                {
                    if (line.Trim().StartsWith('['))
                    {
                        section = line.Trim();
                        config.Add(section, new Dictionary<string, string>());
                    }
                    else
                    {
                        string d = line.Split(';')[0].Trim();

                        string param = d.Split('=')[0].Trim();
                        string value = d.Split('=')[1].Trim();

                        config[section].Add(param, value);
                    }
                }
            }

            return config;
        }

        public static void SaveConfig(Dictionary<string, Dictionary<string, string>> config, string name)
        {
            string data = "";

            foreach (var section in config)
            {
                data += $"\n\n[{section.Key}]";
                foreach (var param in section.Value)
                {
                    data += $"\n{param.Key}={param.Value}";
                }
            }

            File.WriteAllText(Path.Combine(MainWindow.SMConfigPath, $"{name}"), data);
        }
    }
}
