namespace DixKontrol;

public partial class DermiurgoPage : BasePage
{
	public DermiurgoPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Estado inicial
        OjoImage.Opacity = 0;
        OjoImage.Scale = 0.5;

        TituloLabel.Opacity = 0;
        TituloLabel.TranslationY = 30;

        FraseLabel.Opacity = 0;

        // Animación del ojo (más lenta y mística)
        await OjoImage.FadeTo(1, 3500, Easing.CubicInOut);
        await OjoImage.ScaleTo(1, 3000, Easing.CubicOut);

        // Animación del título (más lenta)
        await Task.WhenAll(
            TituloLabel.FadeTo(1, 2500, Easing.CubicInOut),
            TituloLabel.TranslateTo(0, 0, 2500, Easing.CubicOut)
        );

        // Animación de la frase (muy suave)
        await FraseLabel.FadeTo(1, 3000, Easing.CubicInOut);

        // Pausa final para que respire
        await Task.Delay(1200);

        // Redirección a otra página
        await Navigation.PushAsync(new PresentacionForm());
    }
}