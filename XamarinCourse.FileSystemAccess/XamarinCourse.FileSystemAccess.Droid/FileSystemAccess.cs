using System;
using Xamarin.Forms;
using XamarinCourse.FileSystemAccess.Droid;
using System.IO;

[assembly: Dependency(typeof(FileSystemAccess))]
namespace XamarinCourse.FileSystemAccess.Droid
{
    class FileSystemAccess : IFileSystemAccess
    {
        public void SaveText(string filename, string text)
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            File.WriteAllText(filePath, text);
        }

        public string LoadText(string filename)
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            return !File.Exists(filePath) ? null : File.ReadAllText(filePath);
        }
    }
}