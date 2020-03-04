using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using JobsDotCom.Modelos;

namespace JobsDotCom.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesVagas : ContentPage
    {
        public DetalhesVagas(Vaga vaga)
        {
            InitializeComponent();

            BindingContext = vaga;
        }
    }
}