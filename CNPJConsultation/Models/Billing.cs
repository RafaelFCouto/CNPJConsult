using System.Text.Json.Serialization;

namespace CNPJConsultation.Models
{
    public class Billing
    {

        [JsonPropertyName("free")]
        public bool Free {  get; set; }

        [JsonPropertyName("database")]
        public bool Database { get; set; }

    }
}
