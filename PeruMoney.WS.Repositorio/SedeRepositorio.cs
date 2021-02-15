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
    public class SedeRepositorio : ISedeRepositorio
    {
        #region Metodos
        public IEnumerable<PEMSedeResponse> TraerTodos()
        {
            IEnumerable<PEMSedeResponse> oLista = null;
            string sp = StoredProcedure.USP_SEDE_TRAERTODOS;
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reade = db.ExecuteReader(sp))
                {
                    oLista = reade.Select(DesdeDataReader).ToList();
                }
            }
            return oLista;
        }
        public bool Grabar(PEMSedeRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_SEDE_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cNombreSed", SqlDbType.VarChar, oPEMSedeRequest.Nombre));
            parametros.Add(new SqlParameterItem("@x_cDireccSed", SqlDbType.VarChar, oPEMSedeRequest.Direccion));
            parametros.Add(new SqlParameterItem("@x_cTelefoSed", SqlDbType.VarChar, oPEMSedeRequest.Telefono));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMSedeRequest.UsuarioRegistra));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;

	
        }
        public bool Editar(PEMSedeRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_SEDE_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoSed", SqlDbType.Int, oPEMSedeRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_cNombreSed", SqlDbType.VarChar, oPEMSedeRequest.Nombre));
            parametros.Add(new SqlParameterItem("@x_cDireccSed", SqlDbType.VarChar, oPEMSedeRequest.Direccion));
            parametros.Add(new SqlParameterItem("@x_cTelefoSed", SqlDbType.VarChar, oPEMSedeRequest.Telefono));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMSedeRequest.UsuarioRegistra));


            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;

        }

        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_SEDE_ELIMINAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoSed", SqlDbType.Int, oPEMEliminaObjetoRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodUsuDel", SqlDbType.Int, oPEMEliminaObjetoRequest.CodigoUsuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        #endregion

        #region DataReader
        public PEMSedeResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMSedeResponse()
            {
                Codigo = reader.GetValue(0).ToString(),
                Nombre = reader.GetValue(1).ToString(),
                Direccion = reader.GetValue(2).ToString(),
                Estado = reader.GetValue(3).ToString()
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
