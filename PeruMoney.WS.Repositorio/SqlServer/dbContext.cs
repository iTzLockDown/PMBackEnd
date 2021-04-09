using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Microsoft.Extensions.Configuration;
namespace PeruMoney.WS.Repositorio.Contrato
{
    public class dbContext
    {
        #region Variables y Parametros

        private static IConfiguration _configuration;
        
        #endregion

        #region Constructor
        public dbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        #endregion


        #region Metodos

        public static string PLAPERUMONEY()
        {
            string ambiente = "DESARROLLO";
            string cadenaConexion =string.Empty; 

            switch (ambiente)
            {
                case "DESARROLLO":
                    cadenaConexion = "Data Source=LAPTOP-FJQRMKR9\\SQLEXPRESS;Initial Catalog=PERUMONEY;Integrated Security=True";
                    //cadenaConexion =
                    //    "Server = tcp:perumoneydb.database.windows.net,1433; Initial Catalog = perumoney; Persist Security Info = False; User ID = adminperumoney; Password = Jhulisax123; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
                    break;
                case "PRODUCCION":
                    cadenaConexion = _configuration.GetSection("cnSeguridadProdDB").Value;
                    break;
                default:
                    break;
            }

            return cadenaConexion;
        }

        #endregion

        
    }
}
