using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace MusicBeePlugin.LocalLyricsLoader.Loaders
{
    class SameDirectoryLoader : ILyricsLoader
    {
        public string RetrieveLyrics(string sourceFileUrl, string artist, string trackTitle, string album, bool synchronisedPreferred, string provider)
        {
            try
            {
                foreach (var item in Path.GetInvalidFileNameChars())
                    trackTitle = trackTitle.Replace(item, '_');
                if (File.Exists(Path.GetDirectoryName(sourceFileUrl) + @"/" + trackTitle + @".lrc"))
                    return File.ReadAllText(Path.GetDirectoryName(sourceFileUrl) + @"/" + trackTitle + @".lrc");
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            
            
        }
    }
}
