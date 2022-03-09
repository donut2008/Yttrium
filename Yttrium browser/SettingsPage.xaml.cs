using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Yttrium_browser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            this.InitializeComponent();
            settingsNavView.SelectedItem = FavoritesItem;
        }

        private void settingsNavView_BackRequested(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewBackRequestedEventArgs args)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }


        private void settingsNavView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            FrameNavigationOptions navOptions = new FrameNavigationOptions();
            navOptions.TransitionInfoOverride = args.RecommendedNavigationTransitionInfo;
            navOptions.IsNavigationStackEnabled = false;
            Type pageType = null;
            string snvsel = settingsNavView.SelectedItem.ToString();
            switch(snvsel)
            {
                case "Favourites":
                    pageType = typeof(SettingsPage_Favorites);
                    settingsNavView.Header = "Favourites";
                    this.Frame.Navigate(typeof(SettingsPage_Favorites),null);
                    break;
                case "History":
                    pageType = typeof(SettingsPage_History);
                    settingsNavView.Header = "History";
                    this.Frame.Navigate(typeof(SettingsPage_History),null);
                    break;
                case "Search Engine":
                    pageType = typeof(SettingsPage_SearchEngine);
                    settingsNavView.Header = "Search Engine";
                    this.Frame.Navigate(typeof(SettingsPage_SearchEngine),null);
                    break;
                case "About":
                    pageType = typeof(SettingsPage_About);
                    settingsNavView.Header = "About";
                    this.Frame.Navigate(typeof(SettingsPage_About),null);
                    break;
            }
        }

        private void dragTitleBar_Loaded(object sender, RoutedEventArgs e)
        {
            Window.Current.SetTitleBar(sender as Border);
        }
    }
}
