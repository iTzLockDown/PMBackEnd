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
    [Route(Ruta.UriDocumento.Prefijo)]
    [ApiController]
    [Authorize]
    public class DocumentoController : Controller
    {
        private readonly ILogger<DocumentoController> _logger;

        public DocumentoController(ILogger<DocumentoController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriDocumento.Lista)]
        [AllowAnonymous]
        public IActionResult TraerTodos()
        {
            IEnumerable<PEMDocumentoResponse> oLista = null;
            using (IDocumentoDominio oDominio = new DocumentoDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }
    }
}
