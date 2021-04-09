using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeruMoney.WS.Dominio;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruMoney.WS.Cliente.Controllers.API
{
    [Route(Ruta.UriEquipo.Prefijo)]
    [ApiController]
    [Authorize]
    public class EquipoController : Controller
    {
        private readonly ILogger<EquipoController> _logger;

        public EquipoController(ILogger<EquipoController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriEquipo.Lista)]
        public IActionResult Lista()
        {
            IEnumerable<PEMEquipoResponse> oLista = null;
            using (IEquipoDominio oDominio = new EquipoDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }
        [HttpPut]
        [Route(Ruta.UriEquipo.Habilitar)]
        public IActionResult Habilitar(PEMEquipo oPemEquipo)
        {
            bool respuesta = false;
            using (IEquipoDominio oDominio = new EquipoDominio())
            {
                respuesta = oDominio.Habilitar(oPemEquipo);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriEquipo.Eliminar)]
        public IActionResult Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IEquipoDominio oDominio = new EquipoDominio())
            {
                respuesta = oDominio.Eliminar(oPEMEliminaObjetoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}
