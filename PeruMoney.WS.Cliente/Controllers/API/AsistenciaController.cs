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
    [Route(Ruta.UriAsistencia.Prefijo)]
    [ApiController]
    public class AsistenciaController : Controller
    {
        private readonly ILogger<AsistenciaController> _logger;

        public AsistenciaController(ILogger<AsistenciaController> logger)
        {
            _logger = logger;
        }
 

        [HttpPost]
        [Route(Ruta.UriAsistencia.Entrada)]
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
        [Route(Ruta.UriAsistencia.Salida)]
        public IActionResult Salida(PEMAsistenciaRequest oPEMAsistenciaRequest)
        {
            bool respuesta = false;
            using (IPersonaDominio oDominio = new PersonaDominio())
            {
                respuesta = oDominio.Salida(oPEMAsistenciaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPost]
        [Route(Ruta.UriAsistencia.EntradaExtra)]
        public IActionResult EntradaExtra(PEMAsistenciaRequest oPEMAsistenciaRequest)
        {
            bool respuesta = false;
            using (IPersonaDominio oDominio = new PersonaDominio())
            {
                respuesta = oDominio.EntradaExtra(oPEMAsistenciaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriAsistencia.SalidaExtra)]
        public IActionResult SalidaExtra(PEMAsistenciaRequest oPEMAsistenciaRequest)
        {
            bool respuesta = false;
            using (IPersonaDominio oDominio = new PersonaDominio())
            {
                respuesta = oDominio.SalidaExtra(oPEMAsistenciaRequest);
            }
            if (!respuesta) return NotFound();

            return Ok(respuesta);
        }

        [HttpGet]
        [Route(Ruta.UriAsistencia.TraerPersonal)]

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
        [HttpGet]
        [Route(Ruta.UriAsistencia.TraerAsistencia)]

        public IActionResult AsistenciaDiaria(string documento)
        {
            PEMRegistroAsistenciaResponse oObjeto = null;
            using (IPersonaDominio oDominio = new PersonaDominio())
            {
                oObjeto = oDominio.AsistenciaDiaria(documento);
            }
            if (oObjeto == null) return NotFound();

            return Ok(oObjeto);
        }
    }
}





