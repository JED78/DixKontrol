namespace DixKontrol.MVVM.Vistas.ArchivoHistorico;

public partial class EscenaMaquinaPage : ContentPage
{
	public EscenaMaquinaPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await FadeIn(Bloque1);
        await FadeIn(Bloque2);
        await FadeIn(Bloque3);
        await FadeIn(Bloque4);
        await FadeIn(Bloque5);
    }

    private async Task FadeIn(View view)
    {
        view.Opacity = 0;
        await view.FadeTo(1, 800, Easing.CubicInOut);
    }
}
