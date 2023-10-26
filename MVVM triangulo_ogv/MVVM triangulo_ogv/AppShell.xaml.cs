using MVVM_triangulo_ogv.ViewModels;
using MVVM_triangulo_ogv.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MVVM_triangulo_ogv
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
