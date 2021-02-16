using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using PeruMoney.WS.Bloque.SqlServer;
using PeruMoney.WS.Bloque.SqlServer.Clases;
using PeruMoney.WS.Bloque.SqlServer.Funciones;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato.SqlServer;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class OcupacionRepositorio : IOcupacionRepositorio

    {
        public IEnumerable<PEMOcupacionResponse> TraerTodos()
        {
            IEnumerable<PEMOcupacionResponse> oLista = null;
            string sp = StoredProcedure.USP_OCUPACION_TRAERTODOS;
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }

            return oLista;
        }
        public bool Grabar(PEMOcupacionRequest oPEMOcupacionRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_OCUPACION_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cDescriOcu", SqlDbType.VarChar, oPEMOcupacionRequest.Descripcion));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMOcupacionRequest.UsuarioRegistra));
        
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Editar(PEMOcupacionRequest oPEMOcupacionRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_OCUPACION_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoOcu", SqlDbType.VarChar, oPEMOcupacionRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_cDescriOcu", SqlDbType.VarChar, oPEMOcupacionRequest.Descripcion));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMOcupacionRequest.UsuarioRegistra));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_OCUPACION_ELIMINAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoOcu", SqlDbType.VarChar, oPEMEliminaObjetoRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMEliminaObjetoRequest.CodigoUsuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public PEMOcupacionResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMOcupacionResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                DEscripcion = reader.GetValue(1).ToString().Trim(),

            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
