using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace MusicBeePlugin
{
    class LoaderManager
    {
        public static List<ILyricsLoader> GetLyricsLoaders()
        {
            var loaderTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "MusicBeePlugin.LocalLyricsLoader.Loaders" && t.GetInterfaces().Contains(typeof(ILyricsLoader))).ToList();
            var loaders = loaderTypes.Select(t => (ILyricsLoader)Activator.CreateInstance(t)).ToList();
            return loaders;
        }

        public static ILyricsLoader GetLyricsLoader(string loaderName)
        {
            var loaderType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Namespace == "MusicBeePlugin.LocalLyricsLoader.Loaders" && t.GetInterfaces().Contains(typeof(ILyricsLoader)) && t.Name == loaderName);
            return loaderType != null ? (ILyricsLoader)Activator.CreateInstance(loaderType) : null;
        }

        public static string[] GetLyricsLoaderNames()
        {
            var loaderTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "MusicBeePlugin.LocalLyricsLoader.Loaders" && t.GetInterfaces().Contains(typeof(ILyricsLoader))).ToList();
            return loaderTypes.Select(t => t.Name).ToArray();
        }
    }
}
