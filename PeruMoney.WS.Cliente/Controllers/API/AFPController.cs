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
    [Route(Ruta.UriAFP.Prefijo)]
    [ApiController]
    //[Authorize]
    public class AFPController : Controller
    {
        private readonly ILogger<AFPController> _logger;

        public AFPController(ILogger<AFPController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriAFP.ListaTodos)]
        [AllowAnonymous]
        public IActionResult TraerTodos()
        {
            IEnumerable<PEMAFPResponse> oLista = null;
            using (IAFPDominio oDominio = new AFPDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriAFP.Grabar)]
        public IActionResult Grabar(PEMAFPRequest oPEMAFPRequest)
        {
            bool respuesta = false;
            using (IAFPDominio oDominio = new AFPDominio())
            {
                respuesta = oDominio.Grabar(oPEMAFPRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriAFP.Editar)]
        public IActionResult Editar(PEMAFPRequest oPEMAFPRequest)
        {
            bool respuesta = false;
            using (IAFPDominio oDominio = new AFPDominio())
            {
                respuesta = oDominio.Editar(oPEMAFPRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriAFP.Eliminar)]
        public IActionResult Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IAFPDominio oDominio = new AFPDominio())
            {
                respuesta = oDominio.Eliminar(oPEMEliminaObjetoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}
