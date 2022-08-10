using System.Configuration;

namespace DataLoader.Steps.Helpers
{
    public static class StringHelper
    {
        public static string Path2File { get => ConfigurationManager.AppSettings["DefaultPathToFile"]; }
        public static string FileSearchPattern { get => ConfigurationManager.AppSettings[""]; }


    }
}
