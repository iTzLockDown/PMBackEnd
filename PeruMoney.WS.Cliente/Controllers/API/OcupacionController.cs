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
    [Route(Ruta.UriOcupacion.Prefijo)]
    [ApiController]
    [Authorize]
    public class OcupacionController : Controller
    {
        private readonly ILogger<OcupacionController> _logger;

        public OcupacionController(ILogger<OcupacionController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriOcupacion.ListaTodos)]

        public IActionResult TraerTodos()
        {
            IEnumerable<PEMOcupacionResponse> oLista = null;
            using (IOcupacionDominio oDominio = new OcupacionDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriOcupacion.Grabar)]
        public IActionResult Grabar(PEMOcupacionRequest oPEMOcupacionRequest)
        {
            bool respuesta = false;
            using (IOcupacionDominio oDominio = new OcupacionDominio())
            {
                respuesta = oDominio.Grabar(oPEMOcupacionRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriOcupacion.Editar)]
        public IActionResult Editar(PEMOcupacionRequest oPEMOcupacionRequest)
        {
            bool respuesta = false;
            using (IOcupacionDominio oDominio = new OcupacionDominio())
            {
                respuesta = oDominio.Editar(oPEMOcupacionRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriOcupacion.Eliminar)]
        public IActionResult Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IOcupacionDominio oDominio = new OcupacionDominio())
            {
                respuesta = oDominio.Eliminar(oPEMEliminaObjetoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}
