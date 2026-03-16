using System.Text.Json.Serialization;

namespace PokemonAPI.Models
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("base_experience")]
        public int BaseExperience { get; set; }

        [JsonPropertyName("types")]
        public List<TipoSlot> Types { get; set; }
    }

    public class TipoSlot
    {
        [JsonPropertyName("type")]
        public TipoInfo Type { get; set; }
    }

    public class TipoInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
