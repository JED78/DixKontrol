using System;
using System.Collections.Generic;
using System.Text;

namespace DixKontrol
{
    public class BasePage : ContentPage

    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ApplyPlatformBackground();
        }

        private void ApplyPlatformBackground()
        {
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                this.Background = (Brush)Application.Current.Resources["GradientAndroid"];
            }
            else
            {
                this.Background = (Brush)Application.Current.Resources["GradientWindows"];
            }
        }
    }
}
