using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using PeruMoney.WS.Bloque.SqlServer;
using PeruMoney.WS.Bloque.SqlServer.Clases;
using PeruMoney.WS.Bloque.SqlServer.Funciones;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato;
using PeruMoney.WS.Repositorio.Contrato.SqlServer;

namespace PeruMoney.WS.Repositorio.Seguridad
{
    public class LoginRepositorio:ILoginRepositorio
    {
        #region Metodos

        public bool Autentificacion(string usuario, string password)
        {
            bool respuesta = false;
            PEMUsuarioResponse oUsuario = null;
            string sp = StoredProcedure.USP_USUARIO_AUTH;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cCodUsuSis", SqlDbType.VarChar, usuario));
            parametros.Add(new SqlParameterItem("@x_cConUsuSis", SqlDbType.VarChar, password));
            
            using (SqlHelperWS oSqlHelperWS = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = oSqlHelperWS.ExecuteReader(sp, parametros))
                {
                    oUsuario = reader.Select(DesdeDataReader).FirstOrDefault();
                }
            }

            respuesta = oUsuario != null ? true:false;
            return respuesta;

        }

        public PEMUsuarioResponse TraerUsuario(string usuario, string password)
        {
            PEMUsuarioResponse oUsuario = null;
            string sp = StoredProcedure.USP_USUARIO_AUTH;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cCodUsuSis", SqlDbType.VarChar, usuario));
            parametros.Add(new SqlParameterItem("@x_cConUsuSis", SqlDbType.VarChar, password));

            using (SqlHelperWS oSqlHelperWS = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = oSqlHelperWS.ExecuteReader(sp, parametros))
                {
                    oUsuario = reader.Select<PEMUsuarioResponse>(DesdeDataReader).First();
                }
            }
            return oUsuario;
        }

        public bool CambiarContrasenia(string usuario, string password, string nuevoPassword)
        {
            return false;
        }
        #endregion

        #region DataReader

        public PEMUsuarioResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMUsuarioResponse()
            {
                Codigo = reader.GetValue(0).ToString(),
                Usuario = reader.GetValue(1).ToString(),
                CodigEstadoo = reader.GetValue(2).ToString(),

            };
        }

        #endregion

        #region Dispose
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
       
    }
}
