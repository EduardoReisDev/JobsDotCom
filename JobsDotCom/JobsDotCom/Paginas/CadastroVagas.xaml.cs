using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using JobsDotCom.Modelos;
using JobsDotCom.Banco;

namespace JobsDotCom.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroVagas : ContentPage
    {
        public CadastroVagas()
        {
            InitializeComponent();
        }

        private void SalvarAction(object sender, EventArgs args)
        {
            //Obter dados da tela
            Vaga vaga = new Vaga();
            vaga.NomeVaga = NomeVaga.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Empresa = Empresa.Text;
            vaga.Cidade = Cidade.Text;
            vaga.Descricao = Descricao.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;

            //Salvar informacoes no banco
            Database database = new Database();
            database.Cadastro(vaga);

            //Voltar para tela de pesquisa
            App.Current.MainPage = new NavigationPage(new ConsultaVagas());
        }
    }
}