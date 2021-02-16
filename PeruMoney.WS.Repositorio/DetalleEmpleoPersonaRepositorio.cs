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
    public class DetalleEmpleoPersonaRepositorio : IDetalleEmpleoPersonaRepositorio
    {
        public IEnumerable<PEMEmpleoPersonaResponse> TraerTodos()
        {
            IEnumerable<PEMEmpleoPersonaResponse> oLista = null;
            string sp = StoredProcedure.USP_EMPLEOPERSONA_TRAERTODOS;
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }

            return oLista;
        }
        public bool Grabar(PEMEmpleoPersonaRequest oPEMEmpleoPersonaRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_EMPLEOPERSONA_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMEmpleoPersonaRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_nCodigoAfp", SqlDbType.Int, oPEMEmpleoPersonaRequest.CodigoAFP));
            parametros.Add(new SqlParameterItem("@x_nCodigoOcu", SqlDbType.Int, oPEMEmpleoPersonaRequest.COdigoOcupacion));
            parametros.Add(new SqlParameterItem("@x_cDesCarEmp", SqlDbType.VarChar, oPEMEmpleoPersonaRequest.DescripcionCargo));
            parametros.Add(new SqlParameterItem("@x_nSueBasEmp", SqlDbType.Decimal, oPEMEmpleoPersonaRequest.SueldoBase));
            parametros.Add(new SqlParameterItem("@x_nCodigoSed", SqlDbType.Int, oPEMEmpleoPersonaRequest.CodigoSede));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMEmpleoPersonaRequest.UsuarioRegistra));

            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Editar(PEMEmpleoPersonaRequest oPEMEmpleoPersonaRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_EMPLEOPERSONA_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodEmpPer", SqlDbType.Int, oPEMEmpleoPersonaRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodigoAfp", SqlDbType.Int, oPEMEmpleoPersonaRequest.CodigoAFP));
            parametros.Add(new SqlParameterItem("@x_nCodigoOcu", SqlDbType.Int, oPEMEmpleoPersonaRequest.COdigoOcupacion));
            parametros.Add(new SqlParameterItem("@x_cDesCarEmp", SqlDbType.VarChar, oPEMEmpleoPersonaRequest.DescripcionCargo));
            parametros.Add(new SqlParameterItem("@x_nSueBasEmp", SqlDbType.Decimal, oPEMEmpleoPersonaRequest.SueldoBase));
            parametros.Add(new SqlParameterItem("@x_nCodigoSed", SqlDbType.Int, oPEMEmpleoPersonaRequest.CodigoSede));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMEmpleoPersonaRequest.UsuarioRegistra));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public PEMEmpleoPersonaResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMEmpleoPersonaResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                CodigoPersona = reader.GetValue(1).ToString().Trim(),
                CodigoAFP = reader.GetValue(2).ToString().Trim(),
                CodigoOcupacion = reader.GetValue(3).ToString().Trim(),
                DescripcionCargo = reader.GetValue(4).ToString().Trim(),
                SueldoBase = reader.GetValue(5).ToString().Trim(),
                CodigoSede = reader.GetValue(6).ToString().Trim(),

 
            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


    }
}
