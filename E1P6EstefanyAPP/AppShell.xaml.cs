using E1P6EstefanyAPP.ViewModels;
using E1P6EstefanyAPP.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace E1P6EstefanyAPP
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
