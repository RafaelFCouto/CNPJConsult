using System.Text.Json.Serialization;

namespace CNPJConsultation.Models
{
    public class SecondaryActivity
    {


        [JsonPropertyName("code")]
        public string? SecondaryActivityCode { get; set; }

        [JsonPropertyName("text")]
        public string? SecondaryActivityText { get; set; }
    }
}
