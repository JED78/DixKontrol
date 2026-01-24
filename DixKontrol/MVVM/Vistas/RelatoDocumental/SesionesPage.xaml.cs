using DixKontrol.MVVM.ViewModel;

namespace DixKontrol.MVVM.Vistas.RelatoDocumental;

public partial class SesionesPage : ContentPage
{
	public SesionesPage()
	{
		InitializeComponent();
        BindingContext = new SesionesViewModel();

    }
}