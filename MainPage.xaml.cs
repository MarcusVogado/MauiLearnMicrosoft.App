namespace MauiLearnMicrosoft;

public partial class MainPage : ContentPage
{
    public const double MyFontSize = 18;
    string _FileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public MainPage()
    {
        InitializeComponent();
        MyStackLayout.Padding =
         DeviceInfo.Platform == DevicePlatform.iOS// Verficicando se a plataforma é iOS através do DeviceInfo.Platform
        ? new Thickness(30, 60, 30, 30) // Se verdadeiro Reduziar 60 pontos no iOS
        : new Thickness(30); // Se Falso manter em 30 pontos nas outras plataformas
        if (File.Exists(_FileName))
        {
            editor.Text = File.ReadAllText(_FileName);
        }
    }

    private void onSaveNoteClicked(object sender, EventArgs e)
    {

    }

    private void onDeleteNoteClicked(object sender, EventArgs e)
    {

    }

    
}

