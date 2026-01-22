using DixKontrol.MVVM.Vistas.ArchivoHistorico;

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
        Navigation.PushAsync(new MenuPage());
    }

    private void Docu_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MenuPage());
    }
    private void Transmedia_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MenuPage());
    }
    private void Testimonios_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MenuPage());
    }
  
}