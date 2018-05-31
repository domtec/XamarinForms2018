using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Vagas.Modelo;
using App1_Vagas.Banco;

namespace App1_Vagas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MinhasVagasCadastradas : ContentPage
	{
        List<Vaga> Lista { get; set; }
        public MinhasVagasCadastradas ()
		{
			InitializeComponent ();
            ConsultarVagas();

        }

        private void ConsultarVagas()
        {

            Database database = new Database();
            Lista = database.Consultar();
            ListaVagas.ItemsSource = Lista;

            lblCount.Text = Lista.Count.ToString();
        }

        private void EditarAction(object sender, EventArgs args)
        {
            Label lblEditar = (Label)sender;
            Vaga vaga = ((TapGestureRecognizer)lblEditar.GestureRecognizers[0]).CommandParameter as Vaga;
            Navigation.PushAsync(new EditarVaga(vaga));
        }

        private void ExcluirAction(object sender, EventArgs args)
        {
            Label lblExcluir = (Label)sender;
            Vaga vaga = ((TapGestureRecognizer)lblExcluir.GestureRecognizers[0]).CommandParameter as Vaga;
            Database database = new Database();
            database.Exclusao(vaga);
            ConsultarVagas();
        }

        private void PesquisarAction(object sender, TextChangedEventArgs args)
        {
            ListaVagas.ItemsSource = Lista.Where(a => a.NomeVaga.Contains(args.NewTextValue)).ToList();
        }
    }
}