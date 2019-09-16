using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace MyAuthen.iOS.Helpes
{
    class DatabaseAccess
    {
        public static string GetDatabasePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string dbPath = Path.Combine(path, "..", "Documents", filename);
            if (!File.Exists(dbPath))
            {
                var bundlePath = NSBundle.MainBundle.PathForResource(filename, null);
                File.Copy(bundlePath, dbPath);
            }
            Console.WriteLine(dbPath);
            return dbPath;
        }
    }
}