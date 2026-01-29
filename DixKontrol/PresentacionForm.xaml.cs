namespace DixKontrol;

public partial class PresentacionForm : BasePage

{
    public PresentacionForm()
	{
		InitializeComponent();
        
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Animación del avatar
        Device.BeginInvokeOnMainThread(async () =>
        {
            AvatarContainer.Scale = 0.1;
            AvatarContainer.Opacity = 0;

            await Task.WhenAll(
                AvatarContainer.ScaleTo(1, 3000, Easing.CubicOut),
                AvatarContainer.FadeTo(1, 3000, Easing.CubicOut)
            );
        });

        // Espera a que termine la animación del avatar
        await Task.Delay(500);

        // Animación del nombre
        NombreLabel.Opacity = 0;
        NombreLabel.TranslationY = 40;

        await Task.WhenAll(
            NombreLabel.FadeTo(1, 1500, Easing.CubicOut),
            NombreLabel.TranslateTo(0, 0, 1500, Easing.CubicOut)
        );

        // Animación de la descripción
        DescripcionLabel.Opacity = 0;
        DescripcionLabel.TranslationY = 20;

        await Task.WhenAll(
            DescripcionLabel.FadeTo(1, 2000, Easing.CubicOut),
            DescripcionLabel.TranslateTo(0, 0, 2000, Easing.CubicOut)
        );
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MenuPage());
    }
}
