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
    [Route(Ruta.UriFamiliaPersona.Prefijo)]
    [ApiController]
    //[Authorize]
    public class FamiliarController : Controller
    {
        private readonly ILogger<FamiliarController> _logger;

        public FamiliarController(ILogger<FamiliarController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriFamiliaPersona.ListaTodos)]
        [AllowAnonymous]
        public IActionResult TraerTodos()
        {
            IEnumerable<PEMFamiliaPersonaResponse> oLista = null;
            using (IFamiliaPersonaIDominio oDominio = new FamiliaPersonaIDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriFamiliaPersona.Grabar)]
        public IActionResult Grabar(PEMFamiliaPersonalRequest oPEMFamiliaPersonalRequest)
        {
            bool respuesta = false;
            using (IFamiliaPersonaIDominio oDominio = new FamiliaPersonaIDominio())
            {
                respuesta = oDominio.Grabar(oPEMFamiliaPersonalRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriFamiliaPersona.Editar)]
        public IActionResult Editar(PEMFamiliaPersonalRequest oPEMFamiliaPersonalRequest)
        {
            bool respuesta = false;
            using (IFamiliaPersonaIDominio oDominio = new FamiliaPersonaIDominio())
            {
                respuesta = oDominio.Editar(oPEMFamiliaPersonalRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriFamiliaPersona.Eliminar)]
        public IActionResult Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IFamiliaPersonaIDominio oDominio = new FamiliaPersonaIDominio())
            {
                respuesta = oDominio.Eliminar(oPEMEliminaObjetoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}
