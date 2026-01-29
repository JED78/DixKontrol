using CommunityToolkit.Maui.Views;
using DixKontrol.MVVM.Servicios;
using DixKontrol.MVVM.ViewModel;
using Plugin.Maui.Audio;

namespace DixKontrol.MVVM.Vistas.RelatoDocumental;

public partial class SesionesPage : BasePage
{
    private SesionesViewModel vm;

    public SesionesPage()
    {
        InitializeComponent();

        vm = new SesionesViewModel();
        BindingContext = vm;

        vm.PlayRequested += Vm_PlayRequested;
    }

    private async void Vm_PlayRequested(string archivo)
    {
        AudioService.Stop();

        // Cargar el archivo de audio desde Resources/Raw
        var stream = await FileSystem.OpenAppPackageFileAsync(archivo);

        // Reproducir la canción
        AudioService.Play(stream);

    }


}