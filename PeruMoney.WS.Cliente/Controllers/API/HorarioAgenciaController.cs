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
using PeruMoney.WS.Repositorio.SqlServer;

namespace PeruMoney.WS.Cliente.Controllers.API
{
    [Route(Ruta.UriHorarioAgencia.Prefijo)]
    [ApiController]
    [Authorize]
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
        public IActionResult TraerTodos(int codigoSede)
        {
            IEnumerable<PEMHorarioAgenciaResponse> oLista = null;
            using (IHorarioAgenciaDominio oDominio = new HorarioAgenciaDominio())
            {
                oLista = oDominio.TraerTodos(codigoSede);
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriHorarioAgencia.Grabar)]
        public IActionResult Grabar(PEMHorarioAgenciaRequest oPEMHorarioAgenciaRequest)
        {
            bool respuesta = false;
            using (IHorarioAgenciaDominio oDominio = new HorarioAgenciaDominio())
            {
                respuesta = oDominio.Grabar(oPEMHorarioAgenciaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriHorarioAgencia.Eliminar)]
        public IActionResult Eliminar(PEMHorarioAgenciaRequest oPEMHorarioAgenciaRequest)
        {
            bool respuesta = false;
            using (IHorarioAgenciaDominio oDominio = new HorarioAgenciaDominio())
            {
                respuesta = oDominio.Eliminar(oPEMHorarioAgenciaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}
