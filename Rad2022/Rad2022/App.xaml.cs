using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rad2022
{
    public partial class App : Application
    {
        static Controller.DBEmple dbEmple;
        public static Controller.DBEmple dbemple
        {
            get
            { 
                if(dbEmple == null)
                {
                    string DBName = "emple.db3";
                    string PathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName);
                    dbEmple= new Controller.DBEmple(PathDB);  
                }
                return dbEmple;
            
            }
        }   
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
