using CommunityToolkit.Maui.Views;

namespace DixKontrol.MVVM.Vistas.ArchivoHistorico;

public partial class FlyerGalleryPopup : Popup
{
    public FlyerGalleryPopup(List<string> images, int startIndex = 0)
    {
        InitializeComponent();

        FlyerCarousel.ItemsSource = images;
        FlyerCarousel.Position = startIndex;
    }
}
