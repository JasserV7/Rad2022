using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rad2022.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Listemple.ItemsSource = await App.dbemple.ListaEmpleados();
        }

        private async void tooladd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.PageEmple());
        }

        private void Listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}