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
                AvatarContainer.ScaleToAsync(1, 3000, Easing.CubicOut),
                AvatarContainer.FadeToAsync(1, 3000, Easing.CubicOut)
            );
        });

        // Espera a que termine la animación del avatar
        await Task.Delay(500);

        // Animación del nombre
        NombreLabel.Opacity = 0;
        NombreLabel.TranslationY = 40;

        await Task.WhenAll(
            NombreLabel.FadeToAsync(1, 1500, Easing.CubicOut),
            NombreLabel.TranslateToAsync(0, 0, 1500, Easing.CubicOut)
        );

        // Animación de la descripción
        DescripcionLabel.Opacity = 0;
        DescripcionLabel.TranslationY = 20;

        await Task.WhenAll(
            DescripcionLabel.FadeToAsync(1, 2000, Easing.CubicOut),
            DescripcionLabel.TranslateToAsync(0, 0, 2000, Easing.CubicOut)
        );
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new MenuPage());
        }
        catch (Exception ex)
        {
            File.AppendAllText(
                Path.Combine(FileSystem.AppDataDirectory, "nav_error.log"),
                $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {ex}\n");
        }
    }
}
