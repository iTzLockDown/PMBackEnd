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
using PeruMoney.WS.Repositorio.Contrato;
using PeruMoney.WS.Repositorio.Contrato.SqlServer;

namespace PeruMoney.WS.Repositorio.SqlServer
{
    public class HorarioAgenciaRepositorio : IHorarioAgenciaRepositorio

    {
        public IEnumerable<PEMHorarioAgenciaResponse> TraerTodos(int codigoSede)
        {
            IEnumerable<PEMHorarioAgenciaResponse> oLista = null;
            string sp = StoredProcedure.USP_HORARIO_AGENCIA_TRAERTODOS;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoSed", SqlDbType.Int, codigoSede));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }

            return oLista;
        }
        public bool Grabar(PEMHorarioAgenciaRequest oPEMHorarioAgenciaRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_HORARIO_AGENCIA_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoHor", SqlDbType.Int, oPEMHorarioAgenciaRequest.CodigoHorario));
            parametros.Add(new SqlParameterItem("@x_nCodigoSed", SqlDbType.Int, oPEMHorarioAgenciaRequest.CodigoSede));

            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Eliminar(PEMHorarioAgenciaRequest oPEMHorarioAgenciaRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_HORARIO_AGENCIA_ELIMINAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoHor", SqlDbType.Int, oPEMHorarioAgenciaRequest.CodigoHorario));
            parametros.Add(new SqlParameterItem("@x_nCodigoSed", SqlDbType.Int, oPEMHorarioAgenciaRequest.CodigoSede));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public PEMHorarioAgenciaResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMHorarioAgenciaResponse()
            {
                CodigoSede = reader.GetValue(0).ToString().Trim(),
                NombreSede = reader.GetValue(1).ToString().Trim(),
                CodigoHora = reader.GetValue(2).ToString().Trim(),
                HoraInicio = reader.GetValue(3).ToString().Trim(),
                HoraFin = reader.GetValue(4).ToString().Trim(),
            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
