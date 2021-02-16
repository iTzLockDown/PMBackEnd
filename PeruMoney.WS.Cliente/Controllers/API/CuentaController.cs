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
    [Route(Ruta.UriCuentaPersona.Prefijo)]
    [ApiController]
    [Authorize]
    public class CuentaController : Controller
    {
        private readonly ILogger<CuentaController> _logger;

        public CuentaController(ILogger<CuentaController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriCuentaPersona.ListaTodos)]
        [AllowAnonymous]
        public IActionResult TraerTodos(int codigoPersona)
        {
            IEnumerable<PEMCuentaPersonaResponse> oLista = null;
            using (ICuentaPersonaRepositorio oDominio = new CuentaPersonaRepositorio())
            {
                oLista = oDominio.TraerTodos(codigoPersona);
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriCuentaPersona.Grabar)]
        public IActionResult Grabar(PEMCuentaPersonaRequest oPEMCuentaPersonaRequest)
        {
            bool respuesta = false;
            using (ICuentaPersonaRepositorio oDominio = new CuentaPersonaRepositorio())
            {
                respuesta = oDominio.Grabar(oPEMCuentaPersonaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriCuentaPersona.Editar)]
        public IActionResult Editar(PEMCuentaPersonaRequest oPEMCuentaPersonaRequest)
        {
            bool respuesta = false;
            using (ICuentaPersonaRepositorio oDominio = new CuentaPersonaRepositorio())
            {
                respuesta = oDominio.Editar(oPEMCuentaPersonaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriCuentaPersona.Eliminar)]
        public IActionResult Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (ICuentaPersonaRepositorio oDominio = new CuentaPersonaRepositorio())
            {
                respuesta = oDominio.Eliminar(oPEMEliminaObjetoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}
