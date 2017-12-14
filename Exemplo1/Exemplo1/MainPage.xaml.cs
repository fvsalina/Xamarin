using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Exemplo1
{
	public partial class MainPage : ContentPage
	{
        internal ObservableCollection<Pokemon> Pokemons = new ObservableCollection<Pokemon>
        {
            new Pokemon
            {
                Imagem="abra.png",
                Nome="Abra",
                Tipo="Psi"
            },
            new Pokemon
            {
                Imagem="alakazam.png",
                Nome="Alakazam",
                Tipo="Psi"
            },
             new Pokemon
            {
                Imagem="blastoise.png",
                Nome="Blastoise",
                Tipo="Água"
            },
             new Pokemon
            {
                Imagem="Bulbasaur.png",
                Nome="Bullbasaur",
                Tipo="Grama"
            }
      };

        public MainPage()
		{
			InitializeComponent();
            lstPokemon.ItemsSource = Pokemons;
		}

        public void OnSelection(object sender, SelectedItemChangedEventArgs e)
        { 
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            //DisplayAlert("Item Selecionado", ((Pokemon)e.SelectedItem).Nome, "Ok");
            var detailPage = new DetailPage();
            detailPage.BindingContext = e.SelectedItem as Pokemon;
            lstPokemon.SelectedItem = null;
            Navigation.PushModalAsync(detailPage);

        }


    }
}
