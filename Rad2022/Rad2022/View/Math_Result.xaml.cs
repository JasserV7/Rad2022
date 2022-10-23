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
    public partial class Math_Result : ContentPage
    {
        public Math_Result(double resultado)
        {
            InitializeComponent();

            LblResultado.Text = "El resultado de tu operacion matematica es: " + resultado;
        }


        
    }
}