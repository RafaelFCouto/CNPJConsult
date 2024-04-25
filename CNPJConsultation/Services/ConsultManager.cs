


using CNPJConsultation.Interfaces;
using CNPJConsultation.Models;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CNPJConsultation.Services
{
    public class ConsultManager: IConsult
    {


        public Company GetDataByCnpj(string cnpj)
        {
            try
            {
                string url = "https://www.receitaws.com.br/v1/cnpj/" + cnpj;

                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                
                string json = client.DownloadString(url);

                var company= JsonSerializer.Deserialize<Company>(json);

                return company;

            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao consumir api {ex.Message}");

            }

        }








    }
}
