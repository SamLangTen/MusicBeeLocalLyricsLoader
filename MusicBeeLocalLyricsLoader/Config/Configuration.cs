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

        public static string SearchPath { get; set; }
        public static string FilePattern { get; set; }

        public static void SaveConfig(string path)
        {
            var config = new SerializedConfig()
            {
                FilePattern = FilePattern,
                SearchPath = SearchPath
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
                SearchPath = "%";
                FilePattern = "{title}.lrc";
            }
            else
            {
                var xmlText = File.ReadAllText(path, Encoding.UTF8);
                var sr = new StringReader(xmlText);
                var xms = new XmlSerializer(typeof(SerializedConfig));
                var config = (SerializedConfig)xms.Deserialize(sr);

                FilePattern = config.FilePattern;
                SearchPath = config.SearchPath;
            }
        }
    }
}
