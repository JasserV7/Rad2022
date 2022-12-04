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
    public partial class PageRAPrincipal : ContentPage
    {
        public PageRAPrincipal()
        {
            InitializeComponent();
        }

        private async void btnconsumir_Clicked(object sender, EventArgs e)
        {
            await Controller.AlumnController.GetAlumnos();
        }
    }
}