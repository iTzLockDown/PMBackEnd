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
    public class SocialPersonaRepositorio: ISocialPersonaRepositorio
    {
        public PEMSocialPersonaResponse TraerTodos(int codigoPersona)
        {
            PEMSocialPersonaResponse oObjeto = null;
            string sp = StoredProcedure.USP_SOCIAL_TRAERTODOS;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Char, codigoPersona));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oObjeto = reader.Select(DesdeDataReader).FirstOrDefault();
                }
            }

            return oObjeto;
        }

        public bool Grabar(PEMSocialPersonaRequest oPEMSocialPersonaRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_SOCIAL_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMSocialPersonaRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_cSegSocPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.SeguroSocial));
            parametros.Add(new SqlParameterItem("@x_cNomEpsPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.NombreEPS));
            parametros.Add(new SqlParameterItem("@x_cEstSppPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.EstadoSPP));
            parametros.Add(new SqlParameterItem("@x_cSisPenPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.SistemaPensiones));
            parametros.Add(new SqlParameterItem("@x_cTipComPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.TipoCompensacion));
            parametros.Add(new SqlParameterItem("@x_cCusppPers", SqlDbType.VarChar, oPEMSocialPersonaRequest.CUSPP));
            parametros.Add(new SqlParameterItem("@x_cApoActPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.AporteActivo));
            parametros.Add(new SqlParameterItem("@x_cSegVidLey", SqlDbType.VarChar, oPEMSocialPersonaRequest.SeguroVida));
            parametros.Add(new SqlParameterItem("@x_cNumPolVid", SqlDbType.VarChar, oPEMSocialPersonaRequest.NumeroPolizaVida));
            parametros.Add(new SqlParameterItem("@x_cSegComTra", SqlDbType.VarChar, oPEMSocialPersonaRequest.SCT));
            parametros.Add(new SqlParameterItem("@x_cNumPolEss", SqlDbType.VarChar, oPEMSocialPersonaRequest.NumeroPolizaESS));
            parametros.Add(new SqlParameterItem("@x_cNumPolPen", SqlDbType.VarChar, oPEMSocialPersonaRequest.NumeroPolizaPen));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMSocialPersonaRequest.UsuarioRegistra));

          
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public bool Editar(PEMSocialPersonaRequest oPEMSocialPersonaRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_SOCIAL_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMSocialPersonaRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_cSegSocPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.SeguroSocial));
            parametros.Add(new SqlParameterItem("@x_cNomEpsPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.NombreEPS));
            parametros.Add(new SqlParameterItem("@x_cEstSppPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.EstadoSPP));
            parametros.Add(new SqlParameterItem("@x_cSisPenPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.SistemaPensiones));
            parametros.Add(new SqlParameterItem("@x_cTipComPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.TipoCompensacion));
            parametros.Add(new SqlParameterItem("@x_cCusppPers", SqlDbType.VarChar, oPEMSocialPersonaRequest.CUSPP));
            parametros.Add(new SqlParameterItem("@x_cApoActPer", SqlDbType.VarChar, oPEMSocialPersonaRequest.AporteActivo));
            parametros.Add(new SqlParameterItem("@x_cSegVidLey", SqlDbType.VarChar, oPEMSocialPersonaRequest.SeguroVida));
            parametros.Add(new SqlParameterItem("@x_cNumPolVid", SqlDbType.VarChar, oPEMSocialPersonaRequest.NumeroPolizaVida));
            parametros.Add(new SqlParameterItem("@x_cSegComTra", SqlDbType.VarChar, oPEMSocialPersonaRequest.SCT));
            parametros.Add(new SqlParameterItem("@x_cNumPolEss", SqlDbType.VarChar, oPEMSocialPersonaRequest.NumeroPolizaESS));
            parametros.Add(new SqlParameterItem("@x_cNumPolPen", SqlDbType.VarChar, oPEMSocialPersonaRequest.NumeroPolizaPen));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMSocialPersonaRequest.UsuarioRegistra));

            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public PEMSocialPersonaResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMSocialPersonaResponse()
            {
                CodigoPersona = reader.GetValue(1).ToString().Trim(),
                SeguroSocial = reader.GetValue(2).ToString().Trim(),
                NombreEPS = reader.GetValue(3).ToString().Trim(),
                EstadoSPP = reader.GetValue(4).ToString().Trim(),
                SistemaPensiones = reader.GetValue(5).ToString().Trim(),
                TipoCompensacion = reader.GetValue(6).ToString().Trim(),
                CUSPP = reader.GetValue(7).ToString().Trim(),
                Aporte = reader.GetValue(8).ToString().Trim(),
                SeguroVida = reader.GetValue(9).ToString().Trim(),
                NumeroPolisaVida = reader.GetValue(10).ToString().Trim(),
                SCT = reader.GetValue(11).ToString().Trim(),
                NumeroPolisaESS = reader.GetValue(12).ToString().Trim(),
                NumeroPolisaPen = reader.GetValue(13).ToString().Trim(),

            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
