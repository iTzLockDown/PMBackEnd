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
    [Route(Ruta.UriEducacionPersona.Prefijo)]
    [ApiController]
    //[Authorize]
    public class EducacionController : Controller
    {
        private readonly ILogger<EducacionController> _logger;

        public EducacionController(ILogger<EducacionController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriEducacionPersona.ListaTodos)]
        [AllowAnonymous]
        public IActionResult TraerTodos()
        {
            IEnumerable<PEMEducacionPersonalResponse> oLista = null;
            using (IEducacionPersonaDominio oDominio = new EducacionPersonaDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriEducacionPersona.Grabar)]
        public IActionResult Grabar(PEMEducacionPersonalRequest oPEMEducacionPersonalRequest)
        {
            bool respuesta = false;
            using (IEducacionPersonaDominio oDominio = new EducacionPersonaDominio())
            {
                respuesta = oDominio.Grabar(oPEMEducacionPersonalRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriEducacionPersona.Editar)]
        public IActionResult Editar(PEMEducacionPersonalRequest oPEMEducacionPersonalRequest)
        {
            bool respuesta = false;
            using (IEducacionPersonaDominio oDominio = new EducacionPersonaDominio())
            {
                respuesta = oDominio.Editar(oPEMEducacionPersonalRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }


    }
}
