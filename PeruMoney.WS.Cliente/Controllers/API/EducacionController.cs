using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PeruMoney.WS.Cliente.Controllers.API
{
    [Route(Ruta.UriEducacionPersona.Prefijo)]
    [ApiController]
    //[Authorize]
    public class EducacionController : Controller
    {
        private readonly ILogger<EducacionController> _logger;

        public EducacionController(ILogger<EducacionController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriEducacionPersona.ListaTodos)]
        [AllowAnonymous]
        public IActionResult TraerTodos()
        {
            IEnumerable<PEMSedeResponse> oLista = null;
            using (ISedeDominio oDominio = new SedeDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriEducacionPersona.Grabar)]
        public IActionResult TraerUno(PEMSedeRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            using (ISedeDominio oDominio = new SedeDominio())
            {
                respuesta = oDominio.Grabar(oPEMSedeRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriEducacionPersona.Editar)]
        public IActionResult Editar(PEMSedeRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            using (ISedeDominio oDominio = new SedeDominio())
            {
                respuesta = oDominio.Editar(oPEMSedeRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }


    }
}
