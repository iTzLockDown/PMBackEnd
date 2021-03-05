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
    public class EducacionPersonaRepositorio : IEducacionPersonaRepositorio
    {
        public PEMEducacionPersonalResponse TraerTodos(int codigoPersona)
        {
            PEMEducacionPersonalResponse oLista = null;
            string sp = StoredProcedure.USP_EDUCACION_TRAERTODOS;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, codigoPersona));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oLista = reader.Select(DesdeDataReader).First();
                }
            }

            return oLista;
        }
        public bool Grabar(PEMEducacionPersonalRequest oPEMEducacionPersonalRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_EDUCACION_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMEducacionPersonalRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_cNivAcaPer", SqlDbType.VarChar, oPEMEducacionPersonalRequest.NivelAcademico));
            parametros.Add(new SqlParameterItem("@x_cEntEduPer", SqlDbType.VarChar, oPEMEducacionPersonalRequest.EntidadEducativa));
            parametros.Add(new SqlParameterItem("@x_cCarrerPer", SqlDbType.VarChar, oPEMEducacionPersonalRequest.Carrera));
            parametros.Add(new SqlParameterItem("@x_dFecCulEst", SqlDbType.DateTime, oPEMEducacionPersonalRequest.FechaFinEstudio));
            parametros.Add(new SqlParameterItem("@x_cPostgrado", SqlDbType.VarChar, oPEMEducacionPersonalRequest.Postgrado));
            parametros.Add(new SqlParameterItem("@x_cEspeciPos", SqlDbType.VarChar, oPEMEducacionPersonalRequest.EspecializacionPostgrado));
            parametros.Add(new SqlParameterItem("@x_dFecFinEsp", SqlDbType.DateTime, oPEMEducacionPersonalRequest.FechaFinEspecializacion));
            parametros.Add(new SqlParameterItem("@x_cIdiomaEst", SqlDbType.Char, oPEMEducacionPersonalRequest.Idioma));
            parametros.Add(new SqlParameterItem("@x_cNivIdiEst", SqlDbType.Char, oPEMEducacionPersonalRequest.NivelIdioma));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMEducacionPersonalRequest.UsuarioRegistra));
            
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Editar(PEMEducacionPersonalRequest oPEMEducacionPersonalRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_EDUCACION_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();

            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMEducacionPersonalRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_cNivAcaPer", SqlDbType.VarChar, oPEMEducacionPersonalRequest.NivelAcademico));
            parametros.Add(new SqlParameterItem("@x_cEntEduPer", SqlDbType.VarChar, oPEMEducacionPersonalRequest.EntidadEducativa));
            parametros.Add(new SqlParameterItem("@x_cCarrerPer", SqlDbType.VarChar, oPEMEducacionPersonalRequest.Carrera));
            parametros.Add(new SqlParameterItem("@x_dFecCulEst", SqlDbType.DateTime, oPEMEducacionPersonalRequest.FechaFinEstudio));
            parametros.Add(new SqlParameterItem("@x_cPostgrado", SqlDbType.VarChar, oPEMEducacionPersonalRequest.Postgrado));
            parametros.Add(new SqlParameterItem("@x_cEspeciPos", SqlDbType.VarChar, oPEMEducacionPersonalRequest.EspecializacionPostgrado));
            parametros.Add(new SqlParameterItem("@x_dFecFinEsp", SqlDbType.DateTime, oPEMEducacionPersonalRequest.FechaFinEspecializacion));
            parametros.Add(new SqlParameterItem("@x_cIdiomaEst", SqlDbType.Char, oPEMEducacionPersonalRequest.Idioma));
            parametros.Add(new SqlParameterItem("@x_cNivIdiEst", SqlDbType.Char, oPEMEducacionPersonalRequest.NivelIdioma));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMEducacionPersonalRequest.UsuarioRegistra));

            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public PEMEducacionPersonalResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMEducacionPersonalResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                CodigoPersona = reader.GetValue(1).ToString().Trim(),
                NivelAcademico= reader.GetValue(2).ToString().Trim(),
                EntidadEducativa= reader.GetValue(3).ToString().Trim(),
                Carrera= reader.GetValue(4).ToString().Trim(),
                FechaCulminacion= reader.GetValue(5).ToString().Trim(),
                PostGrado= reader.GetValue(6).ToString().Trim(),
                EspecializacionPostgrado= reader.GetValue(7).ToString().Trim(),
                FechaFinEspecializacion= reader.GetValue(8).ToString().Trim(),
                Idioma= reader.GetValue(9).ToString().Trim(),
                NivelIdioma= reader.GetValue(10).ToString().Trim(),

            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
