using AppEscolar.Model;
using AppEscolar.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppEscolar.Service
{
    public class ItemService
    {
        private static ObservableCollection<MasterPageItem> menuLista { get; set; }

        public static ObservableCollection<MasterPageItem> GetMenuItens()
        {
            menuLista = new ObservableCollection<MasterPageItem>();
            // Criando as paginas para navegação
            // Definimos o titulo para o item
            // o icone do lado esquerdo e a pagina que vamos abrir
            var DesciplinasView = new MasterPageItem() { Title = "Desciplinas", TargetType = typeof(DisciplinaPage) };
            var AddAlunoView = new MasterPageItem() { Title = "Cadastror Aluno", TargetType = typeof(AlunoPage) };
            var LancarNotasView = new MasterPageItem() { Title = "Lançar Notas", TargetType = typeof(NotasPage) };
            // Adicionando items no menuLista
            menuLista.Add(DesciplinasView);
            menuLista.Add(AddAlunoView);
            menuLista.Add(LancarNotasView);
            //retorna a lista de itens 
            return menuLista;
        }
    }
}
