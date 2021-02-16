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
    public class AFPRepositorio : IAFPRepositorio
    {
        public IEnumerable<PEMAFPResponse> TraerTodos()
        {
            IEnumerable<PEMAFPResponse> oLista = null;
            string sp = StoredProcedure.USP_AFP_TRAERTODOS;
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }

            return oLista;
        }

        public bool Grabar(PEMAFPRequest oPEMAFPRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_AFP_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nComFijAfp", SqlDbType.Decimal, oPEMAFPRequest.ComisionFija));
            parametros.Add(new SqlParameterItem("@x_nComMixSob", SqlDbType.Decimal, oPEMAFPRequest.ComisionMixta));
            parametros.Add(new SqlParameterItem("@x_nComMixAnu", SqlDbType.Decimal, oPEMAFPRequest.ComisionMixtaAnual));
            parametros.Add(new SqlParameterItem("@x_nPriSegAfp", SqlDbType.Decimal, oPEMAFPRequest.PrimaSeguro));
            parametros.Add(new SqlParameterItem("@x_cAdmFonPen", SqlDbType.Decimal, oPEMAFPRequest.AFP));
            parametros.Add(new SqlParameterItem("@x_nComSobFlu", SqlDbType.Decimal, oPEMAFPRequest.ComisionSobreFlujo));
            parametros.Add(new SqlParameterItem("@x_nPorOblAfp", SqlDbType.Decimal, oPEMAFPRequest.PorcentajeObligatorio));
            parametros.Add(new SqlParameterItem("@x_nRemMaxAse", SqlDbType.Decimal, oPEMAFPRequest.RemuneracionMaxima));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMAFPRequest.UsuarioRegistra));
            
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Editar(PEMAFPRequest oPEMAFPRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_AFP_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoAfp", SqlDbType.Int, oPEMAFPRequest.Codigo));

            parametros.Add(new SqlParameterItem("@x_nComFijAfp", SqlDbType.Decimal, oPEMAFPRequest.ComisionFija));
            parametros.Add(new SqlParameterItem("@x_nComMixSob", SqlDbType.Decimal, oPEMAFPRequest.ComisionMixta));
            parametros.Add(new SqlParameterItem("@x_nComMixAnu", SqlDbType.Decimal, oPEMAFPRequest.ComisionMixtaAnual));
            parametros.Add(new SqlParameterItem("@x_nPriSegAfp", SqlDbType.Decimal, oPEMAFPRequest.PrimaSeguro));
            parametros.Add(new SqlParameterItem("@x_cAdmFonPen", SqlDbType.Decimal, oPEMAFPRequest.AFP));
            parametros.Add(new SqlParameterItem("@x_nComSobFlu", SqlDbType.Decimal, oPEMAFPRequest.ComisionSobreFlujo));
            parametros.Add(new SqlParameterItem("@x_nPorOblAfp", SqlDbType.Decimal, oPEMAFPRequest.PorcentajeObligatorio));
            parametros.Add(new SqlParameterItem("@x_nRemMaxAse", SqlDbType.Decimal, oPEMAFPRequest.RemuneracionMaxima));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMAFPRequest.UsuarioRegistra));


            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_AFP_ELIMINAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoAfp", SqlDbType.Int, oPEMEliminaObjetoRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMEliminaObjetoRequest.CodigoUsuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public PEMAFPResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMAFPResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                ComisionFija = reader.GetValue(1).ToString().Trim(),
                ComisionMixtra = reader.GetValue(2).ToString().Trim(),
                ComisionMixtaAnual = reader.GetValue(3).ToString().Trim(),
                PrimaSeguro = reader.GetValue(4).ToString().Trim(),
                AFP = reader.GetValue(5).ToString().Trim(),
                ComisionFijaFlujo = reader.GetValue(6).ToString().Trim(),
                PorcentajeObligatoriaAFP=  reader.GetValue(7).ToString().Trim(),
                RemuneracionMaxima= reader.GetValue(8).ToString().Trim(),
            };
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
