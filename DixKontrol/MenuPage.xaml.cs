using DixKontrol.MVVM.Vistas.ArchivoHistorico;
using DixKontrol.MVVM.Vistas.RelatoDocumental;

namespace DixKontrol;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}

    private void Bio_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BibliografiaPage());
    }

    private void Linea_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LineaTemporal());
    }

    private void Clips_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MaterialHistoricoPage());
    }

    private void Makina_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EscenaMaquinaPage());
    }

    private void Bibliografialaboral_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BibliografiaPage());
    }
    private void Transmedia_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SesionesPage());
    }
    private void RedesSociales_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EnlacesPage());
    }

    // Animación. 
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Animación secuencial
        await FadeIn(Bloque1);
        await FadeIn(Bloque2);
    }

    private async Task FadeIn(View view)
    {
        view.Opacity = 0;
        await view.FadeTo(1, 800, Easing.CubicInOut);
    }
}
