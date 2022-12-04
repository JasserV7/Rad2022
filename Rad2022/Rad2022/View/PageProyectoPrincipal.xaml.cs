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
    public partial class PageProyectoPrincipal : ContentPage
    {
        public PageProyectoPrincipal()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listacliente.ItemsSource = await Controller.ClientController.getCliente();
        }

        private async void btnconsumir_Clicked(object sender, EventArgs e)
        {
            await Controller.ClientController.getCliente();
        }

        private void agregar_Clicked(object sender, EventArgs e)
        {

        }

        private void toolupdate_Clicked(object sender, EventArgs e)
        {

        }

        private void listalumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}