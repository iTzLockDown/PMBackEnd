using PeruMoney.WS.Bloque.SqlServer;
using PeruMoney.WS.Bloque.SqlServer.Clases;
using PeruMoney.WS.Bloque.SqlServer.Funciones;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        #region Metodos
        public IEnumerable<PEMUserResponse> TraerTodos()
        {
            IEnumerable<PEMUserResponse> oLista = null;

            string sp = StoredProcedure.USP_USUARIO_TRAERTODOS;
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }

                return oLista;
        }
        public bool Grabar(PEMUsuarioRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_USUARIO_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMSedeRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_nCodUsuSis", SqlDbType.VarChar, oPEMSedeRequest.Usuario));
            parametros.Add(new SqlParameterItem("@x_cConUsuSis", SqlDbType.VarChar, oPEMSedeRequest.Contrasenia));
            parametros.Add(new SqlParameterItem("@x_cCodUsuIns", SqlDbType.Int, oPEMSedeRequest.UsuarioRegistra));

            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Editar(PEMUsuarioRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_USUARIO_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoUsu", SqlDbType.Int, oPEMSedeRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMSedeRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_nCodUsuSis", SqlDbType.VarChar, oPEMSedeRequest.Usuario));
            parametros.Add(new SqlParameterItem("@x_cConUsuSis", SqlDbType.VarChar, oPEMSedeRequest.Contrasenia));
            parametros.Add(new SqlParameterItem("@x_cCodUsuUpd", SqlDbType.Int, oPEMSedeRequest.UsuarioRegistra));

            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_USUARIO_ELIMINAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoUsu", SqlDbType.VarChar, oPEMEliminaObjetoRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_cCodUsuDel", SqlDbType.Int, oPEMEliminaObjetoRequest.CodigoUsuario));

            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        #endregion

        #region DataReader
        public PEMUserResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMUserResponse()
            {
                Codigo = reader.GetValue(0).ToString(),
                CodigoPersona = reader.GetValue(1).ToString(),
                Informacion = reader.GetValue(2).ToString(),
                CodigoSistema = reader.GetValue(3).ToString(),
                Estado = reader.GetValue(4).ToString()
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
