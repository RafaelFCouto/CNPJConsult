using System.Text.Json.Serialization;

namespace CNPJConsultation.Models
{
    public class Company
    {

        [JsonPropertyName("abertura")]
        public string? Opening { get; set; }

        [JsonPropertyName("situacao")]
        public string? Situation { get; set; }

        [JsonPropertyName("tipo")]
        public string? Type { get; set; }

        [JsonPropertyName("nome")]
        public string? CompanyName { get; set; }

        [JsonPropertyName("porte")]
        public string? CompanySize { get; set; }

        [JsonPropertyName("natureaza_juridica")]
        public string? LegalNature { get; set; }

        [JsonPropertyName("qsa")]
        public List<Qsa>? Qsa {  get; set; }

        //public Address? Address { get; set; }

        [JsonPropertyName("logradouro")]
        public string? Logradouro { get; set; }

        [JsonPropertyName("numero")]
        public string? Number { get; set; }

        [JsonPropertyName("bairro")]
        public string? Neighborhood { get; set; }

        [JsonPropertyName("municipio")]
        public string? City { get; set; }

        [JsonPropertyName("uf")]
        public string? Uf { get; set; }

        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("data_situacao")]
        public string? DateSituation { get; set; }

        [JsonPropertyName("motivo_situacao")]
        public string? ReasonSituation { get; set; }

        [JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        [JsonPropertyName("ultima_atualizacao")]
        public DateTime LastUpdate { get; set; }

        [JsonPropertyName("status")]
        public string? Status {  get; set; }

        [JsonPropertyName("fantasia")]
        public string? TradeName { get; set; }

        [JsonPropertyName("complemento")]
        public string? Complement { get; set; }


        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("efr")]
        public string? Efr {  get; set; }

        [JsonPropertyName("situacao_especial")]
        public string? SpecialSituation { get; set; }

        [JsonPropertyName("data_situacao_especial")]
        public string? DateSpecialSituation { get; set; }

        [JsonPropertyName("atividade_principal")]
        public List<MainActivity>? MainActivity { get; set; }

        [JsonPropertyName("atividades_secundarias")]
        public List<SecondaryActivity>? SecondaryActivity { get; set; }

        [JsonPropertyName("capital_social")]
        public string? ShareCapital {  get; set; }

        [JsonPropertyName("extra")]
        public Extra? Extra { get; set; }


        [JsonPropertyName("billing")]
        public Billing? Billing { get; set; }


    }
}
