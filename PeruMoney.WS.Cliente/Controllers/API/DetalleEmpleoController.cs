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
    [Route(Ruta.UriDetalleEmpleo.Prefijo)]
    [ApiController]
    [Authorize]
    public class DetalleEmpleoController : Controller
    {
        private readonly ILogger<DetalleEmpleoController> _logger;

        public DetalleEmpleoController(ILogger<DetalleEmpleoController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriDetalleEmpleo.ListaTodos)]

        public IActionResult TraerTodos()
        {
            IEnumerable<PEMEmpleoPersonaResponse> oLista = null;
            using (IDetalleEmpleoPersonaDominio oDominio = new DetalleEmpleoPersonaDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriDetalleEmpleo.Grabar)]
        public IActionResult Grabar(PEMEmpleoPersonaRequest oPEMEmpleoPersonaRequest)
        {
            bool respuesta = false;
            using (IDetalleEmpleoPersonaDominio oDominio = new DetalleEmpleoPersonaDominio())
            {
                respuesta = oDominio.Grabar(oPEMEmpleoPersonaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriDetalleEmpleo.Editar)]
        public IActionResult Editar(PEMEmpleoPersonaRequest oPEMEmpleoPersonaRequest)
        {
            bool respuesta = false;
            using (IDetalleEmpleoPersonaDominio oDominio = new DetalleEmpleoPersonaDominio())
            {
                respuesta = oDominio.Editar(oPEMEmpleoPersonaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }


    }
}
