using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeruMoney.WS.Bloque.SqlServer.Datos;
using Microsoft.Extensions.Configuration;

namespace PeruMoney.WS.Cliente.Providers
{
    public class ProviderBase
    {
        public readonly IConfiguration _config;
        public ProviderBase(IConfiguration config)
        {
            _config = config;
            AsignaVariablesGlobales();
            
        }

        public void AsignaVariablesGlobales()
        {
            Globales.KeyJwt = _config["Jqt:Key"];
            Globales.IssueJwt = _config["Jwt:Issuer"];
        }
    }
}
