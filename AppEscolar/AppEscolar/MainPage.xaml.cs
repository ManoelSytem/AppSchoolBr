using AppEscolar.Model;
using AppEscolar.Service;
using AppEscolar.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ImageCircle.Forms.Plugin.Abstractions;


namespace AppEscolar
{
	public partial class MainPage : MasterDetailPage
    {

        private ObservableCollection<MasterPageItem> _menuLista;
        public MainPage()
        {
            InitializeComponent();
            ImgbackMenu.Source = ImageSource.FromResource("AppEscolar.Resource.backMenu.jpg");
            _menuLista = ItemService.GetMenuItens();
            navigationDrawerList.ItemsSource = _menuLista;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));

        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            //obtem o tipo de objeto 
            Type pagina = item.TargetType;

            //abre a pagina correspondente ao item selecionado
            //Cria uma instância do tipo especificado usando o construtor
            //que melhor se adequa ao parametro informado
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            IsPresented = false;
        }
    }
}
