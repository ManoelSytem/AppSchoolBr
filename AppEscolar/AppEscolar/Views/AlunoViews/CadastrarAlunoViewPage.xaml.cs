using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEscolar.Views.AlunoViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastrarAlunoViewPage : ContentPage
	{
		public CadastrarAlunoViewPage ()
		{
			InitializeComponent ();
            FotoAluno.Source = ImageSource.FromResource("AppEscolar.Resource.fotoperfilaluno.png");
        }
	}
}