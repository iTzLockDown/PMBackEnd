using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using PeruMoney.WS.Dominio;
using PeruMoney.WS.Dominio.Contrato;
using PeruMoney.WS.Modelo.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using PeruMoney.WS.Bloque.SqlServer.Seguridad;
using PeruMoney.WS.Dominio.Contrato.Seguridad;
using PeruMoney.WS.Dominio.Seguridad;
using PeruMoney.WS.Cliente.Seguridad;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace PeruMoney.WS.Cliente.Controllers
{
    [Route(Ruta.UriLogin.Prefijo)]
    [ApiController]
    public class LoginController : ControllerBase
    {
        
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route(Ruta.UriLogin.Autentificacion)]
        public IActionResult GetAutentificacion(LoginServer oLoginServer)
        {
            IActionResult response = Unauthorized();
            if (oLoginServer.Usuario == null || oLoginServer.Contrasenia == null)
            {
                return NotFound("Usuario no encontrado");
            }
            if (oLoginServer.ValidaInicioSesion())
            {
                //oLoginResponse = new LoginResponse();
                PEMUsuarioResponse oUsuario = null;
                using (ILoginDominio oDominio = new LoginDominio())
                {
                    oUsuario = oDominio.TraerUsuario(oLoginServer.Usuario, oLoginServer.Contrasenia);
                }
                if (oUsuario != null)
                {
                    var tokenStr = GenerarTokenJwt.GenerarteTokenJwt(oUsuario);
                    response = Ok(new { token = tokenStr.TokenJwt});
                }
            }
            else
            {
                response = NotFound("Inicio de Sesion Fallido.");
            }
            return response;
        }

       
    }
}
