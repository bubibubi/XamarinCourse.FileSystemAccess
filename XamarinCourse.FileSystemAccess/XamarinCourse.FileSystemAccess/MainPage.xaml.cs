using System;
using Xamarin.Forms;

namespace XamarinCourse.FileSystemAccess
{
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        IFileSystemAccess fileSystemAccess = DependencyService.Get<IFileSystemAccess>();
        TextEditor.Text = fileSystemAccess.LoadText("MyFile.txt");

        SaveButton.Clicked += SaveButton_Clicked;
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        IFileSystemAccess fileSystemAccess = DependencyService.Get<IFileSystemAccess>();
        fileSystemAccess.SaveText("MyFile.txt", TextEditor.Text);
    }
}
}
