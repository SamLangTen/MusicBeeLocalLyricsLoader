using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MusicBeePlugin
{
    public class Configuration
    {

        public class SerializedConfig
        {
            public string SearchPath { get; set; }
            public string FilePattern { get; set; }
        }

        public static List<string> SearchPaths { get; set; }
        public static List<string> FilePatterns { get; set; }

        public static void SaveConfig(string path)
        {
            var config = new SerializedConfig()
            {
                FilePattern = string.Join("\n", FilePatterns),
                SearchPath = string.Join("\n", SearchPaths)
            };

            var xms = new XmlSerializer(typeof(SerializedConfig));
            var writer = new StringWriter();
            xms.Serialize(writer, config);
            File.WriteAllText(path, writer.ToString(), Encoding.UTF8);
        }

        public static void LoadConfig(string path)
        {
            if (!File.Exists(path))
            {
                SearchPaths = new List<string>() { "%" };
                FilePatterns = new List<string>() { "{title}.lrc" };
            }
            else
            {
                var xmlText = File.ReadAllText(path, Encoding.UTF8);
                var sr = new StringReader(xmlText);
                var xms = new XmlSerializer(typeof(SerializedConfig));
                var config = (SerializedConfig)xms.Deserialize(sr);

                FilePatterns = config.FilePattern.Split('\n').ToList();
                SearchPaths = config.SearchPath.Split('\n').ToList();
            }
        }
    }
}
