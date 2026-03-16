using System.Net.Http;
using System.Text.Json;
using PokemonAPI.Models;

namespace PokemonAPI.Services
{
    public class PokemonService
    {
        private HttpClient client = new HttpClient();

        public async Task<Pokemon?> BuscarPokemon(string nome)
        {
            try
            {
                var resposta = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{nome.ToLower()}");

                if (!resposta.IsSuccessStatusCode)
                    return null;

                var json = await resposta.Content.ReadAsStringAsync();
                var pokemon = JsonSerializer.Deserialize<Pokemon>(json);
                return pokemon;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Pokemon?> BuscarPokemonAleatorio()
        {
            var random = new Random();
            int id = random.Next(1, 1026);
            return await BuscarPokemon(id.ToString());
        }
    }
}
