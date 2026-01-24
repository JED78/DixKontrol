namespace DixKontrol.MVVM.Vistas.RelatoDocumental;

public partial class EnlacesPage : ContentPage
{
	public EnlacesPage()
	{
		InitializeComponent();
	}

    private async void OpenSpotify(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://open.spotify.com/playlist/7rev5Z269C22Y35h1EUX3f");
    }

    private async void OpenFacebook(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.facebook.com/nandodixkontrol/photos");
    }

    private async void OpenInstagram(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.instagram.com/nando.dixkontrol/");
    }

    private async void OpenYouTube(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.youtube.com/user/nandixkontrolix");
    }

}