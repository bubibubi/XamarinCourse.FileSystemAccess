using System;
using Windows.Storage;
using Xamarin.Forms;
using XamarinCourse.FileSystemAccess.WinPhone;

[assembly:Dependency(typeof(FileSystemAccess))]
namespace XamarinCourse.FileSystemAccess.WinPhone
{
    class FileSystemAccess : IFileSystemAccess
    {
        public void SaveText(string filename, string text)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile sampleFile = storageFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting).GetResults();
            FileIO.WriteTextAsync(sampleFile, text).GetResults();
        }
        public string LoadText(string filename)
        {
            try
            {
                StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
                StorageFile storageFile = storageFolder.GetFileAsync(filename).GetResults();
                string text = FileIO.ReadTextAsync(storageFile).GetResults();
                return text;
            }
            catch
            {
                return null;
            }
        }
    }
}