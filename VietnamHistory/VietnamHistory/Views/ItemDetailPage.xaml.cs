using System;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using VietnamHistory.Models;
using VietnamHistory.ViewModels;
using VietnamHistory.Data;
using System.Collections.Generic;
using System.Diagnostics;

namespace VietnamHistory.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        FirebaseHelper firebaseHelper = new FirebaseHelper();

        List<Period> periods = new List<Period>();

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            periods = await firebaseHelper.GetAllPeriods();
            listViewPeriods.ItemsSource = periods;
            Debug.WriteLine("hello" + periods.Count);
        }
    }
}