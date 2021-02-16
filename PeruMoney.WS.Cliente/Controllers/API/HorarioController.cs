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
    [Route(Ruta.UriHorario.Prefijo)]
    [ApiController]
    [Authorize]
    public class HorarioController : Controller
    {
        private readonly ILogger<HorarioController> _logger;

        public HorarioController(ILogger<HorarioController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriHorario.ListaTodos)]

        public IActionResult TraerTodos()
        {
            IEnumerable<PEMHorarioReponse> oLista = null;
            using (IHorarioDominio oDominio = new HorarioDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriHorario.Grabar)]
        public IActionResult Grabar(PEMHorarioRequest oPEMHorarioRequest)
        {
            bool respuesta = false;
            using (IHorarioDominio oDominio = new HorarioDominio())
            {
                respuesta = oDominio.Grabar(oPEMHorarioRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriHorario.Editar)]
        public IActionResult Editar(PEMHorarioRequest oPEMHorarioRequest)
        {
            bool respuesta = false;
            using (IHorarioDominio oDominio = new HorarioDominio())
            {
                respuesta = oDominio.Editar(oPEMHorarioRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriHorario.Eliminar)]
        public IActionResult Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IHorarioDominio oDominio = new HorarioDominio())
            {
                respuesta = oDominio.Eliminar(oPEMEliminaObjetoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}
