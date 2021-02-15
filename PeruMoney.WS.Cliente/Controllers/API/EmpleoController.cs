﻿using Microsoft.AspNetCore.Mvc;
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
    [Route(Ruta.UriEmpleo.Prefijo)]
    [ApiController]
    //[Authorize]
    public class EmpleoController : Controller
    {
        private readonly ILogger<EmpleoController> _logger;

        public EmpleoController(ILogger<EmpleoController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route(Ruta.UriEmpleo.ListaTodos)]
        [AllowAnonymous]
        public IActionResult TraerTodos()
        {
            IEnumerable<PEMEmpleoResponse> oLista = null;
            using (IEmpleoDominio oDominio = new EmpleoDominio())
            {
                oLista = oDominio.TraerTodos();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpPost]
        [Route(Ruta.UriEmpleo.Grabar)]
        public IActionResult Grabar(PEMEmpleoRequest oPEMEmpleoRequest)
        {
            bool respuesta = false;
            using (IEmpleoDominio oDominio = new EmpleoDominio())
            {
                respuesta = oDominio.Grabar(oPEMEmpleoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
        [HttpPut]
        [Route(Ruta.UriEmpleo.Editar)]
        public IActionResult Editar(PEMEmpleoRequest oPEMEmpleoRequest)
        {
            bool respuesta = false;
            using (IEmpleoDominio oDominio = new EmpleoDominio())
            {
                respuesta = oDominio.Editar(oPEMEmpleoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriEmpleo.Eliminar)]
        public IActionResult Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IEmpleoDominio oDominio = new EmpleoDominio())
            {
                respuesta = oDominio.Eliminar(oPEMEliminaObjetoRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }
    }
}
