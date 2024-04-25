using System.Text.Json.Serialization;

namespace CNPJConsultation.Models
{
    public class MainActivity
    {

        [JsonPropertyName("code")]
        public string? MainActivityCode { get; set; }

        [JsonPropertyName("text")]
        public string? MainActivityText { get; set; }
    }
}
