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
    [Route(Ruta.UriUsuario.Prefijo)]
    [ApiController]
    //[Authorize]
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriUsuario.ListaTodos)]
        public IActionResult TraerTodos()
        {
            IEnumerable<PEMUserResponse> oLista = null;
            using (IUsuarioDominio oDominio = new UsuarioDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriUsuario.Grabar)]
        public IActionResult TraerUno(PEMUsuarioRequest oPEMUsuarioRequest)
        {
            bool respuesta = false;
            using (IUsuarioDominio oDominio = new UsuarioDominio())
            {
                respuesta = oDominio.Grabar(oPEMUsuarioRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriUsuario.Editar)]
        public IActionResult Editar(PEMUsuarioRequest oPEMUsuarioRequest)
        {
            bool respuesta = false;
            using (IUsuarioDominio oDominio = new UsuarioDominio())
            {
                respuesta = oDominio.Editar(oPEMUsuarioRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriUsuario.Eliminar)]
        public IActionResult Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IUsuarioDominio oDominio = new UsuarioDominio())
            {
                respuesta = oDominio.Eliminar(oPEMEliminaObjetoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}
