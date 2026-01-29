using DixKontrol.MVVM.Servicios;

namespace DixKontrol.MVVM.Vistas.RelatoDocumental;

public partial class SesionesClubBrionePage : BasePage
{
	public SesionesClubBrionePage()
	{
		InitializeComponent();
	}

    private async void OnSesion1Clicked(object sender, EventArgs e)
    {
        AudioService.Stop();

        var stream = await FileSystem.OpenAppPackageFileAsync("sesionbrione1.mp3");
        AudioService.Play(stream);
    }

    private async void OnSesion2Clicked(object sender, EventArgs e)
    {
        AudioService.Stop();

        var stream = await FileSystem.OpenAppPackageFileAsync("sesionbrione2.mp3");
        AudioService.Play(stream);
    }

}