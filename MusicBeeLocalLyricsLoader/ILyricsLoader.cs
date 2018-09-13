using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicBeePlugin
{
    interface ILyricsLoader
    {
        string RetrieveLyrics(string sourceFileUrl, string artist, string trackTitle, string album, bool synchronisedPreferred, string provider);
        
    }
}
