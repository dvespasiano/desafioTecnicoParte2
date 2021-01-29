using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioTecnicoParte2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        [HttpGet]
        [Route("/calculajuros")]
        public string GetCalculaJuros(double valorinicial, double meses)
        {
            //consultar a API 1 para buscar os juros
            var juros = 0.01;
            var valorFinal = valorinicial * Math.Pow((1 + juros), meses);
            //var valorFinalTruncado = valorFinal.ToString("0.00");
            return valorFinal.ToString("0.00");
        }

        [HttpGet]
        [Route("/showmethecode")]
        public string GetTheCode()
        {
            return "https://github.com/dvespasiano/desafioTecnicoParte2";

        }
    }
}
