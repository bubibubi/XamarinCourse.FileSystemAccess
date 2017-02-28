using System;

namespace XamarinCourse.FileSystemAccess
{
    public interface IFileSystemAccess
    {
        void SaveText(string fileName, string text);
        string LoadText(string fileName);
    }
}
