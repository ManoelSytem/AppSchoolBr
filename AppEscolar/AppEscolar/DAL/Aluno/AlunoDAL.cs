using AppEscolar.Model;
using AppEscolar.Service;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AppEscolar.DAL
{
    public class AlunoDAL : IDisposable
    {
        private SQLiteConnection conexaoSQLite;
        public AlunoDAL()
        {
            var config = DependencyService.Get<IConfig>();
            conexaoSQLite = new SQLiteConnection(config.Plataforma, Path.Combine(config.DiretorioSQLite, "Cadastro.db3"));
            conexaoSQLite.CreateTable<Aluno>();
        }
        public void InserirAluno(Aluno aluno)
        {
            conexaoSQLite.Insert(aluno);
        }
        public void AtualizarAluno(Aluno aluno)
        {
            conexaoSQLite.Update(aluno);
        }
        public void DeletarAluno(Aluno aluno)
        {
            conexaoSQLite.Delete(aluno);
        }
        public Aluno GetAluno(int codigo)
        {
            return conexaoSQLite.Table<Aluno>().FirstOrDefault(c => c.Id == codigo);
        }
        public List<Aluno> GetAlunos()
        {
            return conexaoSQLite.Table<Aluno>().OrderBy(c => c.Nome).ToList();
        }
        public void Dispose()
        {
            conexaoSQLite.Dispose();
        }
    }
}
