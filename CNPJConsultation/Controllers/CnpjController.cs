using CNPJConsultation.Interfaces;
using CNPJConsultation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CNPJConsultation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CnpjController : ControllerBase
    {

        private readonly IConsult _IConsult;

        public CnpjController(IConsult iConsult)
        {
            _IConsult = iConsult;
        }








        [HttpGet("{cnpj}")]
        public ActionResult<Company> GetCompany(string cnpj)
        {
            try
            {
                var company = _IConsult.GetDataByCnpj(cnpj);


                if(company == null)
                {
                    return NotFound("Não encontrado");
                }

                return Ok(company);

            }
            catch (Exception ex) 
            {
                throw new Exception($"Api não respondida {ex.Message}");
            }
            
            







        }




    }
}
