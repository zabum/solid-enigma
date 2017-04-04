using System;
using System.IO;
using Einkaufszettel.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper_Android))]
namespace Einkaufszettel.Droid
{
    public class FileHelper_Android : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}