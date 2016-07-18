using AdebtlyAdaptiveChallenge.model;
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
using System.Diagnostics;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AdebtlyAdaptiveChallenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<NewsItem> newsItemList;
        private ObservableCollection<NewsItem> financialnewsItemList;
        private ObservableCollection<NewsItem> foodnewsItemList;

        public MainPage()
        {
            this.InitializeComponent();
 
            newsItemList = NewsItemManager.GetNewsItems();
            financialnewsItemList = new ObservableCollection<NewsItem>( newsItemList.Where(p => p.Category == "Financial").ToList());
            foodnewsItemList =      new ObservableCollection<NewsItem>( newsItemList.Where(p => p.Category == "Food").ToList());

            hamburgerListView.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            hamburgerSplitview.IsPaneOpen = !hamburgerSplitview.IsPaneOpen;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = (ListView)sender;
            
            if (selected.SelectedIndex == 0)
            {
                pageTitleText.Text = "Financial";
                ContentGridView.ItemsSource = financialnewsItemList;
            }
            else if (selected.SelectedIndex == 1)
            {
                pageTitleText.Text = "Food";
                ContentGridView.ItemsSource = foodnewsItemList;
            }
        }

        private void ContentGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedItem = (NewsItem) e.ClickedItem;
            if (selectedItem.Category == "Financial")
            {
                financialnewsItemList.Remove(selectedItem);
            }
            else if (selectedItem.Category == "Food")
            {
                foodnewsItemList.Remove(selectedItem);
            }

            newsItemList.Remove(selectedItem);
        }
    }
}
