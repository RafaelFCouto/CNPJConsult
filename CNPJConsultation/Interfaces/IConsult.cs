using CNPJConsultation.Models;

namespace CNPJConsultation.Interfaces
{
    public interface IConsult
    {


        Company GetDataByCnpj(string cnpj);


    }
}
