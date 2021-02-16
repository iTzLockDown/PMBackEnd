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
    public class PlanillaRepositorio: IPlanillaRepositorio
    {
        public IEnumerable<PEMPlanillaResponse> TraerTodos(int codigoEmpleado)
        {
            IEnumerable<PEMPlanillaResponse> oLista = null;
            string sp = StoredProcedure.USP_PLANILLA_TRAERTODOS;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodEmpPer", SqlDbType.Int, codigoEmpleado));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }

            return oLista;
        }
        public bool Grabar(PEMPlanillaRequest oPEMPlanillaRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_PLANILLA_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMPlanillaRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_nCodEmpPer", SqlDbType.Int, oPEMPlanillaRequest.CodigoEmpleado));
            parametros.Add(new SqlParameterItem("@x_nPeriodPla", SqlDbType.Decimal, oPEMPlanillaRequest.nPeriodPla));
            parametros.Add(new SqlParameterItem("@x_nNumDiaLab", SqlDbType.Decimal, oPEMPlanillaRequest.nNumDiaLab));
            parametros.Add(new SqlParameterItem("@x_nNumDiaVac", SqlDbType.Decimal, oPEMPlanillaRequest.nNumDiaVac));
            parametros.Add(new SqlParameterItem("@x_nHorOrdPla", SqlDbType.Decimal, oPEMPlanillaRequest.nHorOrdPla));
            parametros.Add(new SqlParameterItem("@x_nHorExtr25", SqlDbType.Decimal, oPEMPlanillaRequest.nHorExtr25));
            parametros.Add(new SqlParameterItem("@x_nHorExtr35", SqlDbType.Decimal, oPEMPlanillaRequest.nHorExtr35));
            parametros.Add(new SqlParameterItem("@x_nHorExt100", SqlDbType.Decimal, oPEMPlanillaRequest.nHorExt100));
            parametros.Add(new SqlParameterItem("@x_nSueOrdPla", SqlDbType.Decimal, oPEMPlanillaRequest.nSueOrdPla));
            parametros.Add(new SqlParameterItem("@x_nSueExtr25", SqlDbType.Decimal, oPEMPlanillaRequest.nSueExtr25));
            parametros.Add(new SqlParameterItem("@x_nSueExtr35", SqlDbType.Decimal, oPEMPlanillaRequest.nSueExtr35));
            parametros.Add(new SqlParameterItem("@x_nSueExt100", SqlDbType.Decimal, oPEMPlanillaRequest.nSueExt100));
            parametros.Add(new SqlParameterItem("@x_nAsiFamPla", SqlDbType.Decimal, oPEMPlanillaRequest.nAsiFamPla));
            parametros.Add(new SqlParameterItem("@x_nDesAdeSue", SqlDbType.Decimal, oPEMPlanillaRequest.nDesAdeSue));
            parametros.Add(new SqlParameterItem("@x_nDesPreCai", SqlDbType.Decimal, oPEMPlanillaRequest.nDesPreCai));
            parametros.Add(new SqlParameterItem("@x_nComTieTra", SqlDbType.Decimal, oPEMPlanillaRequest.nComTieTra));
            parametros.Add(new SqlParameterItem("@x_nGratifica", SqlDbType.Decimal, oPEMPlanillaRequest.nGratifica));
            parametros.Add(new SqlParameterItem("@x_nBonificac", SqlDbType.Decimal, oPEMPlanillaRequest.nBonificac));
            parametros.Add(new SqlParameterItem("@x_nDesApoObl", SqlDbType.Decimal, oPEMPlanillaRequest.nDesApoObl));
            parametros.Add(new SqlParameterItem("@x_nDesComVar", SqlDbType.Decimal, oPEMPlanillaRequest.nDesComVar));
            parametros.Add(new SqlParameterItem("@x_nDesImpQui", SqlDbType.Decimal, oPEMPlanillaRequest.nDesImpQui));
            parametros.Add(new SqlParameterItem("@x_nDesFalAsi", SqlDbType.Decimal, oPEMPlanillaRequest.nDesFalAsi));
            parametros.Add(new SqlParameterItem("@x_nApoEssPla", SqlDbType.Decimal, oPEMPlanillaRequest.nApoEssPla));
            parametros.Add(new SqlParameterItem("@x_nApoEssEps", SqlDbType.Decimal, oPEMPlanillaRequest.nApoEssEps));
            parametros.Add(new SqlParameterItem("@x_nTotIngPla", SqlDbType.Decimal, oPEMPlanillaRequest.nTotIngPla));
            parametros.Add(new SqlParameterItem("@x_nTotDesPla", SqlDbType.Decimal, oPEMPlanillaRequest.nTotDesPla));
            parametros.Add(new SqlParameterItem("@x_nNetPagPla", SqlDbType.Decimal, oPEMPlanillaRequest.nNetPagPla));
            parametros.Add(new SqlParameterItem("@x_nObservaci", SqlDbType.Decimal, oPEMPlanillaRequest.nObservaci));
            parametros.Add(new SqlParameterItem("@x_nDiaInasis", SqlDbType.Int, oPEMPlanillaRequest.nDiaInasis));
            parametros.Add(new SqlParameterItem("@x_nTotIngCom", SqlDbType.Decimal, oPEMPlanillaRequest.nTotIngCom));
            parametros.Add(new SqlParameterItem("@x_nDesTotCom", SqlDbType.Decimal, oPEMPlanillaRequest.nDesTotCom));
            parametros.Add(new SqlParameterItem("@x_nDesTotAfp", SqlDbType.Decimal, oPEMPlanillaRequest.nDesTotAfp));
            parametros.Add(new SqlParameterItem("@x_nDesTotOnp", SqlDbType.Decimal, oPEMPlanillaRequest.nDesTotOnp));
            parametros.Add(new SqlParameterItem("@x_nDesAdeGra", SqlDbType.Decimal, oPEMPlanillaRequest.nDesAdeGra));
            parametros.Add(new SqlParameterItem("@x_nDesAdeVac", SqlDbType.Decimal, oPEMPlanillaRequest.nDesAdeVac));
            parametros.Add(new SqlParameterItem("@x_nDesGraPla", SqlDbType.Decimal, oPEMPlanillaRequest.nDesGraPla));
            parametros.Add(new SqlParameterItem("@x_nDesJudPla", SqlDbType.Decimal, oPEMPlanillaRequest.nDesJudPla));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Decimal, oPEMPlanillaRequest.UsuarioRegistra));


            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public PEMPlanillaResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMPlanillaResponse()
            {
                nCodigoPla = reader.GetValue(0).ToString().Trim(),
                nCodEmpPer = reader.GetValue(1).ToString().Trim(),
                nCodigoPer = reader.GetValue(2).ToString().Trim(),
                nPeriodPla = reader.GetValue(3).ToString().Trim(),
                nNumDiaLab = reader.GetValue(4).ToString().Trim(),
                nNumDiaVac = reader.GetValue(5).ToString().Trim(),
                nHorOrdPla = reader.GetValue(6).ToString().Trim(),
                nHorExtr25 = reader.GetValue(7).ToString().Trim(),
                nHorExtr35 = reader.GetValue(8).ToString().Trim(),
                nHorExt100 = reader.GetValue(9).ToString().Trim(),
                nSueOrdPla = reader.GetValue(10).ToString().Trim(),
                nSueExtr25 = reader.GetValue(11).ToString().Trim(),
                nSueExtr35 = reader.GetValue(12).ToString().Trim(),
                nSueExt100 = reader.GetValue(13).ToString().Trim(),
                nAsiFamPla = reader.GetValue(14).ToString().Trim(),
                nDesAdeSue = reader.GetValue(15).ToString().Trim(),
                nDesPreCai = reader.GetValue(16).ToString().Trim(),
                nComTieTra = reader.GetValue(17).ToString().Trim(),
                nGratifica = reader.GetValue(18).ToString().Trim(),
                nBonificac = reader.GetValue(19).ToString().Trim(),
                nDesApoObl = reader.GetValue(20).ToString().Trim(),
                nDesComVar = reader.GetValue(21).ToString().Trim(),
                nDesImpQui = reader.GetValue(22).ToString().Trim(),
                nDesFalAsi = reader.GetValue(23).ToString().Trim(),
                nApoEssPla = reader.GetValue(24).ToString().Trim(),
                nApoEssEps = reader.GetValue(25).ToString().Trim(),
                nTotIngPla = reader.GetValue(26).ToString().Trim(),
                nTotDesPla = reader.GetValue(27).ToString().Trim(),
                nNetPagPla = reader.GetValue(28).ToString().Trim(),
                nObservaci = reader.GetValue(29).ToString().Trim(),
                nDiaInasis = reader.GetValue(30).ToString().Trim(),
                nTotIngCom = reader.GetValue(31).ToString().Trim(),
                nDesTotCom = reader.GetValue(32).ToString().Trim(),
                nDesTotAfp = reader.GetValue(33).ToString().Trim(),
                nDesTotOnp = reader.GetValue(34).ToString().Trim(),
                nDesAdeGra = reader.GetValue(35).ToString().Trim(),
                nDesAdeVac = reader.GetValue(36).ToString().Trim(),
                nDesGraPla = reader.GetValue(37).ToString().Trim(),
                nDesJudPla = reader.GetValue(38).ToString().Trim(),
                lEstadoPla = reader.GetValue(39).ToString().Trim()
            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
