using miemss_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace miemss_xamarin
{
    class SearchBarResults : ContentPage
    {
        ListView listView;

        public SearchBarResults()
        {
            Title = "Code Realtime SearchBar";
            Padding = 10;

            SearchBar searchBar = new SearchBar
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Placeholder = "Search fruits...",
                CancelButtonColor = Color.Orange,
                PlaceholderColor = Color.Orange
            };

            listView = new ListView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };

            Content = new StackLayout
            {
                Children =
                {
                    searchBar,
                    listView
                }
            };

            searchBar.TextChanged += OnTextChanged;
            listView.ItemsSource = DrugData.Drugs;
        }

        async void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = await App.Database.GetItemAsync(e.NewTextValue);
        }
    }
}
