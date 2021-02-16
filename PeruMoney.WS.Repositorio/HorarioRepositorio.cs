﻿using System;
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
    public class HorarioRepositorio : IHorarioRepositorio
    {
        public IEnumerable<PEMHorarioReponse> TraerTodos()
        {
            IEnumerable<PEMHorarioReponse> oLista = null;
            string sp = StoredProcedure.USP_HORARIO_TRAERTODOS;
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }

            return oLista;
        }
        public bool Grabar(PEMHorarioRequest oPEMHorarioRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_HORARIO_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cDescriHor", SqlDbType.VarChar, oPEMHorarioRequest.DEscripcion));
            parametros.Add(new SqlParameterItem("@x_nHorIniHor", SqlDbType.VarChar, oPEMHorarioRequest.HoraIni));
            parametros.Add(new SqlParameterItem("@x_nHorFinHor", SqlDbType.VarChar, oPEMHorarioRequest.HoraFin));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMHorarioRequest.UsuarioRegistra));

        
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Editar(PEMHorarioRequest oPEMHorarioRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_HORARIO_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoHor", SqlDbType.Int, oPEMHorarioRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_cDescriHor", SqlDbType.VarChar, oPEMHorarioRequest.DEscripcion));
            parametros.Add(new SqlParameterItem("@x_nHorIniHor", SqlDbType.VarChar, oPEMHorarioRequest.HoraIni));
            parametros.Add(new SqlParameterItem("@x_nHorFinHor", SqlDbType.VarChar, oPEMHorarioRequest.HoraFin));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMHorarioRequest.UsuarioRegistra));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_HORARIO_ELIMINAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoHor", SqlDbType.Int, oPEMEliminaObjetoRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMEliminaObjetoRequest.CodigoUsuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public PEMHorarioReponse DesdeDataReader(IDataReader reader)
        {
            return new PEMHorarioReponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                Descripcion = reader.GetValue(1).ToString().Trim(),
                Inicio = reader.GetValue(2).ToString().Trim(),
                Fin = reader.GetValue(3).ToString().Trim(),
                Estado = reader.GetValue(4).ToString().Trim(),

            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
