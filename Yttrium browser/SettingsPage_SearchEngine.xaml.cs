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
using winui = Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Yttrium_browser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage_SearchEngine : Page
    {
        public SettingsPage_SearchEngine()
        {
            this.InitializeComponent();
        }
        SearchEngine se = new SearchEngine();
        private void SearchEngineChanged(object sender, RoutedEventArgs e)
        {
            var selectedSearchEngine = SearchEngineSelector.SelectedItem.ToString();
            switch(selectedSearchEngine)
            {
                case "Google":
                    se.defaultEngine = "https://www.google.com/search?q=";
                    break;
                case "Bing":
                    se.defaultEngine = "https://www.bing.com/search?q=";
                    break;
                case "DuckDuckGo":
                    se.defaultEngine = "https://duckduckgo.com/?q=";
                    break;
                case "Ecosia":
                    se.defaultEngine = "https://www.ecosia.org/search?q=";
                    break;
                default:
                    se.defaultEngine = "https://www.google.com/search?q=";
                    break;
            }
        }
    }
}
