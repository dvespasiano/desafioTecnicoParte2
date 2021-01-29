using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
            HttpClient http = new HttpClient();
            var juros = Convert.ToDouble(http.GetAsync("https://localhost:44378/taxaJuros").Result.Content.ReadAsStringAsync().Result);
            var valorFinal = valorinicial * Math.Pow((1 + juros), meses);
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
