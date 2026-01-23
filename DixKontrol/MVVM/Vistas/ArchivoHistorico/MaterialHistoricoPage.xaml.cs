using Plugin.Maui.Audio;

namespace DixKontrol.MVVM.Vistas.ArchivoHistorico;

public partial class MaterialHistoricoPage : ContentPage
{
	public MaterialHistoricoPage()
	{
		InitializeComponent();
	}

    private async void ReproducirAudio1_Clicked(object sender, EventArgs e)
    {
        // Cargar el archivo de audio desde Resources/Raw
        var stream = await FileSystem.OpenAppPackageFileAsync("Psicodromo.mp3");

        // Crear el reproductor
        var player = AudioManager.Current.CreatePlayer(stream);

        // Reproducir la canción
        player.Play();
    }


    private void VerClip2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VideoPage());
    }

    private async void VerFlyer3_Clicked(object sender, EventArgs e)
    {
        var popup = new Popup
        {
            Content = new Image
            {
                Source = "flyer.jpg"
                Aspect = Aspect.AspectFit
            }
        };

        await this.ShowPopupAsync(popup);

    }

}