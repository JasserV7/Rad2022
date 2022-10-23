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
    public partial class PageEmple : ContentPage
    {
        public PageEmple()
        {
            InitializeComponent();
        }

        private  async void btnagregar_empple_Clicked(object sender, EventArgs e)
        {
            var emple = new Model.Empleado
            {
                Id = Convert.ToInt32(txtcodigo.Text),
                nombre = txtnombre.Text,
                apellidos = txtapellido.Text,
                telefono = Convert.ToInt32(txttelefono.Text),
                email = txtemail.Text

            };

            if (await App.dbemple.StoreEmple(emple) > 0)
                await DisplayAlert("Aviso", "Registro ingresado con exito", "Ok");

        }
    }
}