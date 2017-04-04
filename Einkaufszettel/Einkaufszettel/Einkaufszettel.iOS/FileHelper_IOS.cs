using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Einkaufszettel.iOS;
using System.IO;

[assembly: Dependency(typeof(FileHelper_IOS))]
namespace Einkaufszettel.iOS
{
    public class FileHelper_IOS
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }
    }
}
