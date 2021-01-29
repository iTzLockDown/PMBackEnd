using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeruMoney.WS.Modelo;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruMoney.WS.Cliente.Controllers.API
{
    [Route(Ruta.UriPersona.Prefijo)]
    [ApiController]
    [Authorize]
    public class PersonalController : Controller
    {
        private readonly ILogger<PersonalController> _logger;

        public PersonalController(ILogger<PersonalController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriPersona.ListaTodos)]
        public IActionResult TraerTodos()
        {
            IEnumerable<PEMPersonaResponse> oLista = null;
            using (IPersonaDominio oDominio = new PersonaDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }

        [HttpGet]
        [Route(Ruta.UriPersona.ListaUno)]
        public IActionResult TraerUno(string documento)
        {
            PEMPersonaResponse oObjeto = null;
            using (IPersonaDominio oDominio = new PersonaDominio())
            {
                oObjeto = oDominio.TraerUno(documento);
            }
            if (oObjeto == null) return NotFound();

            return Ok(oObjeto);
        }


        [HttpPost]
        [Route(Ruta.UriPersona.Grabar)]
        public IActionResult TraerUno(PEMPersonaRequest oPEMPersonaRequest)
        {
            bool respuesta = false;
            using (IPersonaDominio oDominio = new PersonaDominio())
            {
                respuesta = oDominio.Grabar(oPEMPersonaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriPersona.Editar)]
        public IActionResult Editar(PEMPersonaRequest oPEMPersonaRequest)
        {
            bool respuesta = false;
            using (IPersonaDominio oDominio = new PersonaDominio())
            {
                respuesta = oDominio.Editar(oPEMPersonaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriPersona.Eliminar)]
        public IActionResult Eliminar(int codigoPersona, int codigoUsuario)
        {
            bool respuesta = false;
            using (IPersonaDominio oDominio = new PersonaDominio())
            {
                respuesta = oDominio.Eliminar(codigoPersona, codigoUsuario);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPost]
        [Route(Ruta.UriPersona.Entrada)]
        public IActionResult Entrada(PEMAsistenciaRequest oPEMAsistenciaRequest)
        {
            bool respuesta = false;
            using (IPersonaDominio oDominio = new PersonaDominio())
            {
                respuesta = oDominio.Entrada(oPEMAsistenciaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriPersona.Salida)]
        public IActionResult Salida(PEMAsistenciaRequest oPEMAsistenciaRequest)
        {
            //backdor
            bool respuesta = false;
            using (IPersonaDominio oDominio = new PersonaDominio())
            {
                respuesta = oDominio.Salida(oPEMAsistenciaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}





