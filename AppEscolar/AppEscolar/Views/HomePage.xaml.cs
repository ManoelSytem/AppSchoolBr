﻿using AppEscolar.Views.AlunoViews;
using System;
using System.Collections.Generic;
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
		public HomePage ()
		{
			InitializeComponent ();
		}

        private async void ClikedAdicionarAluno(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarAlunoViewPage());
        }
    }
}