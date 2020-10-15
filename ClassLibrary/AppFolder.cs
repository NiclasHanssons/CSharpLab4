using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AppFolder
    {
        public static string LocalAppFolder { get; private set; }

        public string DirectoryCreator { get; set; }

        public static void CheckForLocalDirectory()
        {
            string ProjectName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            LocalAppFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ProjectName + "\\");
            Directory.CreateDirectory(LocalAppFolder);
        }
    }
}
