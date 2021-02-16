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
    public class DisciplinaPersonaRepositorio : IDisciplinaPersonaRepositorio
    {
        public IEnumerable<PEMActosDisciplinarioResponse> TraerTodos(int codigoPersona)
        {
            IEnumerable<PEMActosDisciplinarioResponse> oLista = null;
            string sp = StoredProcedure.USP_DISCIPLINA_TRAERTODOS;
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
        public bool Grabar(PEMActosDisciplinariosRequest oPEMActosDisciplinariosRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_DISCIPLINA_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMActosDisciplinariosRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_cTipSanDis", SqlDbType.VarChar, oPEMActosDisciplinariosRequest.TipoSancion));
            parametros.Add(new SqlParameterItem("@x_dFecSanDis", SqlDbType.DateTime, oPEMActosDisciplinariosRequest.FechaSancion));
            parametros.Add(new SqlParameterItem("@x_cMotSanDis", SqlDbType.VarChar, oPEMActosDisciplinariosRequest.MotivoSancion));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMActosDisciplinariosRequest.UsuarioRegistra));

            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Editar(PEMActosDisciplinariosRequest oPEMActosDisciplinariosRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_DISCIPLINA_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoDis", SqlDbType.Int, oPEMActosDisciplinariosRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_cTipSanDis", SqlDbType.VarChar, oPEMActosDisciplinariosRequest.TipoSancion));
            parametros.Add(new SqlParameterItem("@x_cMotSanDis", SqlDbType.VarChar, oPEMActosDisciplinariosRequest.MotivoSancion));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMActosDisciplinariosRequest.UsuarioRegistra));

            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_DISCIPLINA_ELIMINAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoDis", SqlDbType.Char, oPEMEliminaObjetoRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Char, oPEMEliminaObjetoRequest.CodigoUsuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }


        public PEMActosDisciplinarioResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMActosDisciplinarioResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                CodigoPersona = reader.GetValue(1).ToString().Trim(),
                TipoSancion= reader.GetValue(2).ToString().Trim(),
                FechaSancion= reader.GetValue(3).ToString().Trim(),
                MotivoSancion= reader.GetValue(4).ToString().Trim(),
            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
