using DixKontrol.MVVM.Vistas.ArchivoHistorico;
using DixKontrol.MVVM.Vistas.RelatoDocumental;

namespace DixKontrol;

public partial class MenuPage : BasePage
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
    

    private void ArchivodePrensa_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MVVM.Vistas.ArchivoHistorico.ArchivodePrensaPage());
    }
    private void Bibliografialaboral_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BibliografiaRelatoDocumentalPage());
    }
    private void Transmedia_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SesionesPage());
    }
    private void RedesSociales_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EnlacesPage());
    }

    private void SesionesClubBrione_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SesionesClubBrionePage());
    }
    

    // Animación. 
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Animación secuencial
        await AnimateIn(Bloque1, 250);
        await AnimateIn(Bloque2, 180);

    }

    private async Task AnimateIn(View view, int delay = 0)
    {
        view.Opacity = 0;
        view.Scale = 0.85;
        view.TranslationY = 30;

        await Task.Delay(delay);

        await Task.WhenAll(
            view.FadeTo(1, 600, Easing.CubicOut),
            view.TranslateTo(0, 0, 600, Easing.CubicOut),
            view.ScaleTo(1, 600, Easing.CubicOut)
        );
    }
}
