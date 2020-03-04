using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using JobsDotCom.Banco;
using JobsDotCom.Modelos;

namespace JobsDotCom.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaVagas : ContentPage
    {
        public ConsultaVagas()
        {
            InitializeComponent();
            Database database = new Database();
            var Lista = database.Consultar();
            ListaVagas.ItemsSource = database.Consultar();

            lblCount.Text = Lista.Count.ToString();
        }

        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroVagas());
        }

        public void GoMinhasVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new VagasCadastradas());
        }

        public void MaisDetalheAction(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Navigation.PushAsync(new DetalhesVagas(vaga));
        }
    }
}