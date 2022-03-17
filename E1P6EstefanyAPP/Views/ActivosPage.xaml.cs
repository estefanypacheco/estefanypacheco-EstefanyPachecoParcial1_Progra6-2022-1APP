using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace E1P6EstefanyAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivosPage : ContentPage
    {
        public ActivosPage()
        {
            InitializeComponent();
        }

        private async void CmdVolverARegistro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}