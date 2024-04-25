using System.Text.Json.Serialization;

namespace CNPJConsultation.Models
{
    public class Qsa
    {
        [JsonPropertyName("nome")]
        public string? Name { get; set; }

        [JsonPropertyName("qual")]
        public string? Qual { get; set; }


    }
}
