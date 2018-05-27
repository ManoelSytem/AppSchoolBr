using AppEscolar.Model;
using AppEscolar.ViewModel;
using Plugin.Media;
using Plugin.Media.Abstractions;
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
        
		public CadastrarAlunoViewPage (Aluno aluno)
		{
			InitializeComponent ();
            if(aluno.Id == null)
            {
                btnAlterar.IsVisible = false;
            }
            else
            {
                Title = "Alterar Aluno";
                btnAlterar.IsVisible = true;
                btnSalvar.IsVisible = false;
                
            }
            FotoAluno.Source = ImageSource.FromResource("AppEscolar.Resource.fotoperfilaluno.png");

           // var alunoViewModel = new AlunoViewModel(aluno);
            //BindingContext = alunoViewModel;
        }

        private async void btnCamera_Clicked(object send, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                await DisplayAlert("Aluno", "Informe o nome do Aluno", "OK");
                txtNome.Focus();
                return;
            }

            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Nenhuma Câmera", ":( Nenuma Câmera disponível.", "OK");
                return;
            }

            try
            {
                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    SaveToAlbum = true,
                    Name = txtNome+".jpg"
                });
               

                if (file == null)
                    return;
                FotoAluno.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;
                });
            }
            catch(Exception ex)
            {
                await DisplayAlert("Erro Camera", ex.Message, "OK");
            }
          
        }

        private async void btnSelecionarImagem_Clicked(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagem = await CrossMedia.Current.PickPhotoAsync();
                if (imagem != null)
                {
                    FotoAluno.Source = ImageSource.FromStream(() =>
                    {
                        var stream = imagem.GetStream();
                        imagem.Dispose();
                        return stream;
                    });
                }
            }
        }
    }
}