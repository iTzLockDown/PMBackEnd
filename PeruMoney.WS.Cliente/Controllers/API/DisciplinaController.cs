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
    [Route(Ruta.UriDisciplinaPersona.Prefijo)]
    [ApiController]
    [Authorize]
    public class DisciplinaController : Controller
    {
        private readonly ILogger<DisciplinaController> _logger;

        public DisciplinaController(ILogger<DisciplinaController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriDisciplinaPersona.ListaTodos)]

        public IActionResult TraerTodos(int codigoPersona)
        {
            IEnumerable<PEMActosDisciplinarioResponse> oLista = null;
            using (IDisciplinaPersonaDominio oDominio = new DisciplinaPersonaDominio())
            {
                oLista = oDominio.TraerTodos(codigoPersona);
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriDisciplinaPersona.Grabar)]
        public IActionResult Grabar(PEMActosDisciplinariosRequest oPEMActosDisciplinariosRequest)
        {
            bool respuesta = false;
            using (IDisciplinaPersonaDominio oDominio = new DisciplinaPersonaDominio())
            {
                respuesta = oDominio.Grabar(oPEMActosDisciplinariosRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriDisciplinaPersona.Editar)]
        public IActionResult Editar(PEMActosDisciplinariosRequest oPEMActosDisciplinariosRequest)
        {
            bool respuesta = false;
            using (IDisciplinaPersonaDominio oDominio = new DisciplinaPersonaDominio())
            {
                respuesta = oDominio.Editar(oPEMActosDisciplinariosRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriDisciplinaPersona.Eliminar)]
        public IActionResult Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IDisciplinaPersonaDominio oDominio = new DisciplinaPersonaDominio())
            {
                respuesta = oDominio.Eliminar(oPEMEliminaObjetoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}
