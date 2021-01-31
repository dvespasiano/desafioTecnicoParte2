using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
            try
            {
                HttpClient http = new HttpClient();
                var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
                var url = configuration.GetValue<string>("enderecoApiTeste1:url");
                var juros = Convert.ToDouble(http.GetAsync(url + "/taxaJuros").Result.Content.ReadAsStringAsync().Result);
                var valorFinal = valorinicial * Math.Pow((1 + juros), meses);
                return valorFinal.ToString("0.00");
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        [HttpGet]
        [Route("/showmethecode")]
        public string GetTheCode()
        {
            return "https://github.com/dvespasiano/desafioTecnicoParte2";

        }
    }
}
