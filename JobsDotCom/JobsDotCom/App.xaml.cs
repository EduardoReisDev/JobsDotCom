using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JobsDotCom
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new JobsDotCom.Paginas.ConsultaVagas());
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
