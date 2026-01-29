namespace DixKontrol.MVVM.Vistas.ArchivoHistorico;

public partial class BibliografiaPage : BasePage
{
	public BibliografiaPage()
	{
		InitializeComponent();

        // Estado inicial invisible
        Titulo.Opacity = 0;
        Bloque1.Opacity = 0;
        Bloque2.Opacity = 0;

        // Desplazamiento inicial hacia abajo
        Titulo.TranslationY = 20;
        Bloque1.TranslationY = 20;
        Bloque2.TranslationY = 20;

    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Animación del título
        await Task.WhenAll(
            Titulo.FadeTo(1, 600, Easing.CubicOut),
            Titulo.TranslateTo(0, 0, 600, Easing.CubicOut)
        );

        // Animación del bloque 1
        await Task.WhenAll(
            Bloque1.FadeTo(1, 600, Easing.CubicOut),
            Bloque1.TranslateTo(0, 0, 600, Easing.CubicOut)
        );

        // Animación del bloque 2
        await Task.WhenAll(
            Bloque2.FadeTo(1, 600, Easing.CubicOut),
            Bloque2.TranslateTo(0, 0, 600, Easing.CubicOut)
        );
    }
}

