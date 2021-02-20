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
using PeruMoney.WS.Dominio;
using PeruMoney.WS.Dominio.Contrato;

namespace PeruMoney.WS.Cliente.Controllers.API
{
    [Route(Ruta.UriEstadoCivil.Prefijo)]
    [ApiController]
    [Authorize]
    public class EstadoCivilController : Controller
    {
        private readonly ILogger<EstadoCivilController> _logger;

        public EstadoCivilController(ILogger<EstadoCivilController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriEstadoCivil.Lista)]
        [AllowAnonymous]
        public IActionResult TraerTodos()
        {
            IEnumerable<PEMEstadoCivilResponse> oLista = null;
            using (IEstadoCivilDominio oDominio = new EstadoCivilDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


    }
}
