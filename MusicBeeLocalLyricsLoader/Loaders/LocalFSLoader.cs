using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace MusicBeePlugin.LocalLyricsLoader.Loaders
{
    class LocalFSLoader : ILyricsLoader
    {
        private string RemoveInvalidFileNameChars(string filename, char replacement)
        {
            foreach (var item in Path.GetInvalidFileNameChars())
                filename = filename.Replace(item, replacement);
            return filename;
        }

        public string RetrieveLyrics(string sourceFileUrl, string artist, string trackTitle, string album, bool synchronisedPreferred, string provider)
        {
            string clearArtist = RemoveInvalidFileNameChars(artist, '_');
            string clearTitle = RemoveInvalidFileNameChars(trackTitle, '_');
            string clearAlbum = RemoveInvalidFileNameChars(album, '_');
            string clearFilename = RemoveInvalidFileNameChars(Path.GetFileNameWithoutExtension(sourceFileUrl), '_');
            string folderPath = Path.GetDirectoryName(sourceFileUrl);

            var filePatterns = from f in Regex.Split(Configuration.FilePattern, "\r\n|\r|\n") select f.Replace("{filename}", clearFilename).Replace("{title}", clearTitle).Replace("{artist}", clearArtist).Replace("{album}", clearAlbum);
            var searchPathes = from f in Regex.Split(Configuration.SearchPath, "\r\n|\r|\n") select f.Replace("%", folderPath).Replace("{filename}", clearFilename).Replace("{title}", clearTitle).Replace("{artist}", clearArtist).Replace("{album}", clearAlbum);
            var allFiles = from p in searchPathes from f in filePatterns select Path.Combine(p, f);


            var availableFile = allFiles.FirstOrDefault(f => File.Exists(f));
            if (availableFile != null)
                return File.ReadAllText(availableFile);
            else
                return null;
        }
    }
}
