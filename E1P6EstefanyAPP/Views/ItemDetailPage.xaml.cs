using E1P6EstefanyAPP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace E1P6EstefanyAPP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}