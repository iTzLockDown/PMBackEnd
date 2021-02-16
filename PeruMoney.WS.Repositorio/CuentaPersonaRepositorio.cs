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
    public class CuentaPersonaRepositorio : ICuentaPersonaRepositorio
    {
        public IEnumerable<PEMCuentaPersonaResponse> TraerTodos(int codigoPersona)
        {
            IEnumerable<PEMCuentaPersonaResponse> oLista = null;
            string sp = StoredProcedure.USP_CUENTA_TRAERTODOS;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, codigoPersona));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }

            return oLista;
        }
        public bool Grabar(PEMCuentaPersonaRequest oPEMCuentaPersonaRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_CUENTA_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMCuentaPersonaRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_cBanCobCue", SqlDbType.VarChar, oPEMCuentaPersonaRequest.Banco));
            parametros.Add(new SqlParameterItem("@x_cNumCuenta", SqlDbType.VarChar, oPEMCuentaPersonaRequest.Numero));
            parametros.Add(new SqlParameterItem("@x_cTipMoneda", SqlDbType.VarChar, oPEMCuentaPersonaRequest.TipoMoneda));
            parametros.Add(new SqlParameterItem("@x_cBanCobCts", SqlDbType.VarChar, oPEMCuentaPersonaRequest.BancoCTS));
            parametros.Add(new SqlParameterItem("@x_cNumCueCts", SqlDbType.VarChar, oPEMCuentaPersonaRequest.NumeroCTS));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMCuentaPersonaRequest.UsuarioRegistra));



            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Editar(PEMCuentaPersonaRequest oPEMCuentaPersonaRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_CUENTA_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoCue", SqlDbType.Int, oPEMCuentaPersonaRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMCuentaPersonaRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_cBanCobCue", SqlDbType.VarChar, oPEMCuentaPersonaRequest.Banco));
            parametros.Add(new SqlParameterItem("@x_cNumCuenta", SqlDbType.VarChar, oPEMCuentaPersonaRequest.Numero));
            parametros.Add(new SqlParameterItem("@x_cTipMoneda", SqlDbType.VarChar, oPEMCuentaPersonaRequest.TipoMoneda));
            parametros.Add(new SqlParameterItem("@x_cBanCobCts", SqlDbType.VarChar, oPEMCuentaPersonaRequest.BancoCTS));
            parametros.Add(new SqlParameterItem("@x_cNumCueCts", SqlDbType.VarChar, oPEMCuentaPersonaRequest.NumeroCTS));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMCuentaPersonaRequest.UsuarioRegistra));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_CUENTA_ELIMINA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoCue", SqlDbType.Int, oPEMEliminaObjetoRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMEliminaObjetoRequest.CodigoUsuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public PEMCuentaPersonaResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMCuentaPersonaResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                CodigoPersona = reader.GetValue(1).ToString().Trim(),
                Banco = reader.GetValue(2).ToString().Trim(),
                NumeroCuenta = reader.GetValue(3).ToString().Trim(),
                TipoMoneda = reader.GetValue(4).ToString().Trim(),
                BancoCTS = reader.GetValue(5).ToString().Trim(),
                NumeroCuentaCTS = reader.GetValue(6).ToString().Trim()
            };
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
