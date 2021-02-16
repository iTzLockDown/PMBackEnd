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
    [Route(Ruta.UriPlanilla.Prefijo)]
    [ApiController]
    [Authorize]
    public class PlanillaController : Controller
    {
        private readonly ILogger<PlanillaController> _logger;

        public PlanillaController(ILogger<PlanillaController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriPlanilla.ListaTodos)]
        [AllowAnonymous]
        public IActionResult TraerTodos(int codigoEmpleado)
        {
            IEnumerable<PEMPlanillaResponse> oLista = null;
            using (IPlanillaDominio oDominio = new PlanillaDominio())
            {
                oLista = oDominio.TraerTodos(codigoEmpleado);
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriPlanilla.Grabar)]
        public IActionResult TraerUno(PEMPlanillaRequest PEMPlanillaRequest)
        {
            bool respuesta = false;
            using (IPlanillaDominio oDominio = new PlanillaDominio())
            {
                respuesta = oDominio.Grabar(PEMPlanillaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

    }
}
