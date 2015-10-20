using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.FileProperties;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace task16th
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderPicker fp = new FolderPicker();
            fp.SuggestedStartLocation = PickerLocationId.Desktop;
            fp.FileTypeFilter.Add(".jpg");
            fp.FileTypeFilter.Add(".jpeg");
            fp.FileTypeFilter.Add(".png");
            fp.ViewMode = PickerViewMode.Thumbnail;
            StorageFolder sf = await fp.PickSingleFolderAsync();
            if(sf!=null)
            {
               IReadOnlyList<IStorageItem> i = await sf.GetItemsAsync();
             

               flip.ItemsSource = i;
              // BitmapImage b = new BitmapImage();
             }
        }

        private void flip_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            map.Visibility = Visibility.Visible;

        }
    }
}
