﻿using MyRecipiesApp.Models;
using MyRecipiesApp.ViewModel;
using System.Collections.ObjectModel;
using static MyRecipiesApp.Common.RecipesViewModel;
using static MyRecipiesApp.Pages.HomePage;

namespace MyRecipiesApp.Pages
{
    public partial class RecepiePage : ContentPage
    {
        public ObservableCollection<string> toto { get; set; } = new ObservableCollection<string> { };

        public RecepiePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            this.BindingContext = this;
        }

        public async void OnTappedGoBack(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }
    }
}