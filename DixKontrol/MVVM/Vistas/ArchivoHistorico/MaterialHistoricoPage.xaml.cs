using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Maui.Views;
using Plugin.Maui.Audio;

namespace DixKontrol.MVVM.Vistas.ArchivoHistorico;

public partial class MaterialHistoricoPage : BasePage
{
	public MaterialHistoricoPage()
	{
		InitializeComponent();
	}

    private async void ReproducirAudio1_Clicked(object sender, EventArgs e)
    {
        // Cargar el archivo de audio desde Resources/Raw
        var stream = await FileSystem.OpenAppPackageFileAsync("psicodromo.mp3");

        // Crear el reproductor
        var player = AudioManager.Current.CreatePlayer(stream);

        player.Stop();

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
                Source = "flyer.jpg",
                Aspect = Aspect.AspectFit
            }
        };

        await this.ShowPopupAsync(popup);

    }

    private async void Imagenes_Clicked(object sender, EventArgs e)
    {
        var images = new List<string>
    {
        "Foto_001.jpg",
        "Foto_002.jpg",
        "Foto_003.jpg",
        "Foto_004.jpg",
        "Foto_005.jpg",
        "Foto_006.jpg",
        "Foto_007.jpg",
        "Foto_008.jpg",
        "Foto_009.jpg",
        "Foto_010.jpg",
        "Foto_011.jpg",
        "Foto_012.jpg",
        "Foto_013.jpg",
        "Foto_014.jpg",
        "Foto_015.jpg",
        "Foto_016.jpg"
       
    };

        var popup = new FlyerGalleryPopup(images, startIndex: 1); 

        await this.ShowPopupAsync(popup);


    }
}