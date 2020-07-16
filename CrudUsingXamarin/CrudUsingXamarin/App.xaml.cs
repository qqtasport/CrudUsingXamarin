using CrudUsingXamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrudUsingXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Cambiamos el nombre a la vista que queremos que inicie
            MainPage = new NavigationPage(new HomePage());
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
