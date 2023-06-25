using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{

    [Route("Saludos")]
    [ApiController]
    public class Controlers:ControllerBase
    {
        [HttpGet("{nombre}") ]
        public ActionResult<string> ObtenerSaludo(string nombre)
        {
            return $"hola, {nombre}!";
        }


    }
}
