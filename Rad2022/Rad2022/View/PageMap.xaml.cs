using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Xamarin.Forms.Maps;

namespace Rad2022.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMap : ContentPage
    {
        public PageMap()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing(); 


            var localizacion= await Geolocation.GetLocationAsync(); 

            Pin ubicacion=new Pin();
            ubicacion.Label = "UCENM Tocoa";
            ubicacion.Address = "Tocoa Colon";
            ubicacion.Position = new Position(localizacion.Latitude, localizacion.Longitude);
            mapas.Pins.Add(ubicacion);

            mapas.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(localizacion.Latitude, localizacion.Longitude), Distance.FromKilometers(1)));


        }

    }
}