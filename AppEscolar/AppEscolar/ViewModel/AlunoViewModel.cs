﻿using AppEscolar.DAL;
using AppEscolar.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppEscolar.ViewModel
{
    public class AlunoViewModel : BaseViewModel
    {
        AlunoDAL alunoDAL = new AlunoDAL();

        private ObservableCollection<Aluno> _alunos;
        private ObservableCollection<Aluno> Alunos
        {
            get { return _alunos;}
            set
            {
                if(_alunos !=value)
                {
                    _alunos = value;
                    OnPropertyChanged(nameof(Alunos));
                }
            }

        }


        private long? _id;
        private string _nome;
        private int _idade;
        private string _rg;
        private string _bairro;
        private string _telefone;
        private string _foto;

        public AlunoViewModel()
        {
           // Alunos = new ObservableCollection<Aluno>(alunoDAL.GetAlunos());
        }

        public AlunoViewModel(Aluno aluno)
        {
            this._id = aluno.Id;
            this._nome = aluno.Nome;
            this._bairro = aluno.Bairro;
            this._idade = aluno.idade;
            this._rg = aluno.Rg;
            this._telefone = aluno.Telefone;
            this._foto = aluno.Foto;
        }

        public long? Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; OnPropertyChanged(); }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; OnPropertyChanged(); }
        }

        public string Rg
        {
            get { return _rg; }
            set { _rg = value; OnPropertyChanged(); }
        }

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; OnPropertyChanged(); }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; OnPropertyChanged(); }
        }

        public string Foto
        {
            get { return _foto; }
            set { _foto = value; OnPropertyChanged(); }
        }

        public ICommand Gravar
        {
            get
            {
                var alunoDal = new AlunoDAL();
                return new Command(() =>
                {
                    Aluno newAluno = GetAluno();

                    if(newAluno.Nome != null && newAluno.Bairro !=null && newAluno.Foto != null)
                    {
                        alunoDAL.InserirAluno(newAluno);
                        App.Current.MainPage.DisplayAlert("Novo Aluno", "Inclusão realizada com sucesso!", "OK");
                    }
                    else
                    {
                        App.Current.MainPage.DisplayAlert("Dados Inválidos!", "Verifique os dados do aluno!", "OK");
                    }
                }
                );
            }

        }

        private Aluno GetAluno()
        {
            return new Aluno()
            {
                Id = this.Id,
                Nome = this.Nome,
                Bairro = this.Bairro,
                Foto = this.Foto,
                idade = this.Idade,
                Rg = this.Rg,
                Telefone = this.Telefone

            };
        }
    }
}
