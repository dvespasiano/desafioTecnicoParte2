using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace desafioTecnicoParte2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosControllerr : ControllerBase
    {
        // GET: api/<JurosControllerr>
        [HttpGet]
        [Route("calculajuros")]
        public double GetCalculaJuros(double valorInicial, double juros, double tempo)
        {
            //consultar a API 1 para buscar os juros
            var valorFinal = valorInicial * Math.Pow((1 + juros), tempo);
            return Math.Truncate(valorFinal);
        }

        [HttpGet]
        [Route("/showmethecode")]
        public string GetTheCode()
        {
            return ;
        }
    }
}
