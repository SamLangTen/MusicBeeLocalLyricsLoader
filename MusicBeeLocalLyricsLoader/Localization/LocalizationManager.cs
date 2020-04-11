using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicBeePlugin
{
    class LocalizationManager
    {
        public static void SetByMBField173(string mbField173Text)
        {
            var langDic = new Dictionary<string, string>();
            langDic["Language"] = "en";
            langDic["语言"] = "zh-Hans";
            Language = langDic.ContainsKey(mbField173Text) ? langDic[mbField173Text] : "en";
        }
        public static string Language { get; set; }
        public static string ConfigPanelSearchPath
        {
            get
            {
                var langDic = new Dictionary<string, string>();
                langDic["en"] = "Search Path";
                langDic["zh-Hans"] = "搜索路径";
                return langDic[Language];
            }
        }

        public static string ConfigPanelFilePattern
        {
            get
            {
                var langDic = new Dictionary<string, string>();
                langDic["en"] = "File Pattern";
                langDic["zh-Hans"] = "文件名匹配";
                return langDic[Language];
            }
        }

        public static string ConfigPanelFilePatternDescription
        {
            get
            {
                var langDic = new Dictionary<string, string>();
                langDic["en"] = "Available Pattern:\n% - Directory containing music file(available in SearchPath)\n{filename} - Filename without extension\n{artist} - Aritst Name\n{title}\n - Title\n{album} - Album";
                langDic["zh-Hans"] = "可用的匹配项:\n% - 文件所在目录（只用于搜索路径）\n{filename} - 文件名（不含扩展名）\n{artist} - 艺术家\n{title} - 标题\n{album} - 专辑名";
                return langDic[Language];
            }
        }


    }
}
