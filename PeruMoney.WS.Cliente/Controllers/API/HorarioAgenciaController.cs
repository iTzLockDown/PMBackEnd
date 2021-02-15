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
    [Route(Ruta.UriHorarioAgencia.Prefijo)]
    [ApiController]
    //[Authorize]
    public class HorarioAgenciaController : Controller
    {
        private readonly ILogger<HorarioAgenciaController> _logger;

        public HorarioAgenciaController(ILogger<HorarioAgenciaController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriHorarioAgencia.ListaTodos)]
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
        [Route(Ruta.UriHorarioAgencia.Grabar)]
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
        [Route(Ruta.UriHorarioAgencia.Eliminar)]
        public IActionResult Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (ISedeDominio oDominio = new SedeDominio())
            {
                respuesta = oDominio.Eliminar(oPEMEliminaObjetoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}
