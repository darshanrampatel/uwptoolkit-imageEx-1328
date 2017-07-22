using System;
using Microsoft.Toolkit.Uwp.UI.Controls;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace ImageExIssue.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void Image_ImageFailed(object sender, Windows.UI.Xaml.ExceptionRoutedEventArgs e)
        {
            Image img = sender as Image;
            string fallbackImage = "ms-appx:///Assets/StoreLogo.png";
            img.Source = new BitmapImage(new Uri(fallbackImage));
        }

        private void Image_ImageExFailed(object sender, Microsoft.Toolkit.Uwp.UI.Controls.ImageExFailedEventArgs e)
        {
            ImageEx img = sender as ImageEx;
            string fallbackImage = "ms-appx:///Assets/StoreLogo.png";
            img.Source = fallbackImage;
        }
    }
}