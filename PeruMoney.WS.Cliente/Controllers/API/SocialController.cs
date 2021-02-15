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
    [Route(Ruta.UriSocial.Prefijo)]
    [ApiController]
    //[Authorize]
    public class SocialController : Controller
    {
        private readonly ILogger<SocialController> _logger;

        public SocialController(ILogger<SocialController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriSocial.ListaTodos)]
        [AllowAnonymous]
        public IActionResult TraerTodos()
        {
            IEnumerable<PEMSocialPersonaResponse> oLista = null;
            using (ISocialPersonaDominio oDominio = new SocialPersonaDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriSocial.Grabar)]
        public IActionResult TraerUno(PEMSocialPersonaRequest oPEMSocialPersonaRequest)
        {
            bool respuesta = false;
            using (ISocialPersonaDominio oDominio = new SocialPersonaDominio())
            {
                respuesta = oDominio.Grabar(oPEMSocialPersonaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriSocial.Editar)]
        public IActionResult Editar(PEMSocialPersonaRequest oPEMSocialPersonaRequest)
        {
            bool respuesta = false;
            using (ISocialPersonaDominio oDominio = new SocialPersonaDominio())
            {
                respuesta = oDominio.Editar(oPEMSocialPersonaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }


    }
}
