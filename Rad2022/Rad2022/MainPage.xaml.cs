using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Rad2022
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Aviso", txtnombre.Text + " " +txtapellido.Text,"OK");
        }

        private async void btnseguir_Clicked(object sender, EventArgs e)
        {
            var empleado = new Model.Empleado
            {
                nombre= txtnombre.Text,
                apellidos= txtapellido.Text,
                telefono = Convert.ToInt32(txttelefono.Text),
                email = txtemail.Text,

            };

            var page = new View.Page2();
            page.BindingContext = empleado;
            await Navigation.PushAsync(page);
        }
    }
}
