using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PokemonXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public HttpClient HttpClient = new HttpClient() { BaseAddress = new Uri("https://pokeapi.co/api/v2/") };
        public ObservableCollection<Pokemon> ObservablePokemonList = new ObservableCollection<Pokemon>();
        public ListOfPokemon PokemonList = new ListOfPokemon();
        public MainPage()
        {
            InitializeComponent();
            //GetPokemonList();
            PokemonView.ItemsSource = ObservablePokemonList;
            BindingContext = this;
        }

        public async Task<ListOfPokemon> GetPokemonList()
        {
            var pokemonResponse = await HttpClient.GetAsync("pokemon");
            pokemonResponse.EnsureSuccessStatusCode();
            var responseBody = await pokemonResponse.Content.ReadAsStringAsync();
            var ListOfPokemon = JsonSerializer.Deserialize<ListOfPokemon>(responseBody);
            return ListOfPokemon;
        }

        public async Task<PokemonDetails> GetPokemonDetails(Pokemon pokemon)
        {
            var pokemonResponse = await HttpClient.GetAsync("pokemon/" + pokemon.Name);
            pokemonResponse.EnsureSuccessStatusCode();
            var responseBody = await pokemonResponse.Content.ReadAsStringAsync();
            var PokemonDetails = JsonSerializer.Deserialize<PokemonDetails>(responseBody);
            return PokemonDetails;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var listOfPokemon = await GetPokemonList();
            foreach (var pokemon in listOfPokemon.Results)
            {
                pokemon.Details = await GetPokemonDetails(pokemon);
                ObservablePokemonList.Add(pokemon);
            }
        }
        public async void ListView_ItemTappedAsync(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var details = e.Item as Pokemon;
                await Navigation.PushModalAsync(new DetailPage(details));
            }
        }

    }
}
