using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rad2022.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Math : ContentPage
    {
        public Page_Math()
        {
            InitializeComponent();

            pkOperacion.Items.Add("Suma");
            pkOperacion.Items.Add("Resta");
            pkOperacion.Items.Add("Multiplicacion");
            pkOperacion.Items.Add("Division");

        }

        private async void BtnSuma_Clicked(object sender, EventArgs e)
        {


        }

        private async void BtnResta_Clicked(object sender, EventArgs e)
        {


        }

        private async void BtnMultiplicar_Clicked(object sender, EventArgs e)
        {

        }

        private async void BtnDivision_Clicked(object sender, EventArgs e)
        {

        }

        private async void pkOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            String seleccion = pkOperacion.SelectedItem.ToString();

            int Num1 = Int32.Parse(txtNumero1.Text);
            int Num2 = Int32.Parse(txtNumero2.Text);

            double resultado = 0;

            if(seleccion== "Suma")
                resultado= Num1+Num2;    
            else if (seleccion=="Resta")
                resultado= Num1 - Num2; 
            else if(seleccion=="Multiplicacion")
                resultado= Num1 * Num2;
            else
                resultado= Num1 / Num2;

            await Navigation.PushAsync(new Math_Result(resultado));


        }

        private async void BtnPagina2_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}