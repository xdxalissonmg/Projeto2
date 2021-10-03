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
    public class Cadastro_Veiculos2Controller : ControllerBase
    {
        // GET: api/Cadastro_Veiculos
        [HttpGet]
        public String Listar()
        {
            return "Licenciamentos pago, Multas em aberto";
        }

       
    }
}
