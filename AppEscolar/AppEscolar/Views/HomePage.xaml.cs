using AppEscolar.Model;
using AppEscolar.Views.AlunoViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEscolar.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        private ObservableCollection<Aluno> _alunos;
        public HomePage ()
		{
			InitializeComponent ();
		}

        private async void ClikedAdicionarAluno(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            await Navigation.PushAsync(new CadastrarAlunoViewPage(aluno));
        }
    }
}