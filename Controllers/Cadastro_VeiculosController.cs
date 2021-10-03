using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Veiculos.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Cadastro_VeiculosController : ControllerBase
    {
        // GET: api/Cadastro_Veiculos
        [HttpGet]
        public String Listar()
        {
            return "Vermelho, Preto, Branco, Laranja, Verde, Prata";
        }

         [HttpGet]
        public String Listar2()
        {
            return "Air Bag, Direção Hidraulica, Freios ABS, Ar condicionado";
        }

    }
}
