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
    public class EmpleoRepositorio : IEmpleoRepositorio
    {
        public IEnumerable<PEMEmpleoResponse> TraerTodos(int codigoPersona)
        {
            IEnumerable<PEMEmpleoResponse> oLista = null;
            string sp = StoredProcedure.USP_DETALLEEMPLEO_TRAERTODOS;
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
        public bool Grabar(PEMEmpleoRequest oPEMEmpleoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_DETALLEEMPLEO_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMEmpleoRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_cRegLabEmp", SqlDbType.VarChar, oPEMEmpleoRequest.RegimenLaboral));
            parametros.Add(new SqlParameterItem("@x_cTipTraEmp", SqlDbType.VarChar, oPEMEmpleoRequest.TipoTrabajo));
            parametros.Add(new SqlParameterItem("@x_cTipConEmp", SqlDbType.VarChar, oPEMEmpleoRequest.TipoContrato));
            parametros.Add(new SqlParameterItem("@x_cModConEmp", SqlDbType.VarChar, oPEMEmpleoRequest.ModoContrato));
            parametros.Add(new SqlParameterItem("@x_dFecIniCon", SqlDbType.DateTime, oPEMEmpleoRequest.FechaIniciaContrato));
            parametros.Add(new SqlParameterItem("@x_dFecFinCon", SqlDbType.DateTime, oPEMEmpleoRequest.FechaFinContrato));
            parametros.Add(new SqlParameterItem("@x_dFecConEmp", SqlDbType.DateTime, oPEMEmpleoRequest.FechaContrato));
            parametros.Add(new SqlParameterItem("@x_dFecIniPro", SqlDbType.DateTime, oPEMEmpleoRequest.FechaIniciaProrroga));
            parametros.Add(new SqlParameterItem("@x_dFecFinPro", SqlDbType.DateTime, oPEMEmpleoRequest.FechaFinProrroga));
            parametros.Add(new SqlParameterItem("@x_cEscSalEmp", SqlDbType.Char, oPEMEmpleoRequest.Escala));
            parametros.Add(new SqlParameterItem("@x_cCategoEmp", SqlDbType.VarChar, oPEMEmpleoRequest.Categoria));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMEmpleoRequest.UsuaioRegistra));
            
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Editar(PEMEmpleoRequest oPEMEmpleoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_DETALLEEMPLEO_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMEmpleoRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_cRegLabEmp", SqlDbType.VarChar, oPEMEmpleoRequest.RegimenLaboral));
            parametros.Add(new SqlParameterItem("@x_cTipTraEmp", SqlDbType.VarChar, oPEMEmpleoRequest.TipoTrabajo));
            parametros.Add(new SqlParameterItem("@x_cTipConEmp", SqlDbType.VarChar, oPEMEmpleoRequest.TipoContrato));
            parametros.Add(new SqlParameterItem("@x_cModConEmp", SqlDbType.VarChar, oPEMEmpleoRequest.ModoContrato));
            parametros.Add(new SqlParameterItem("@x_dFecIniCon", SqlDbType.DateTime, oPEMEmpleoRequest.FechaIniciaContrato));
            parametros.Add(new SqlParameterItem("@x_dFecFinCon", SqlDbType.DateTime, oPEMEmpleoRequest.FechaFinContrato));
            parametros.Add(new SqlParameterItem("@x_dFecConEmp", SqlDbType.DateTime, oPEMEmpleoRequest.FechaContrato));
            parametros.Add(new SqlParameterItem("@x_dFecIniPro", SqlDbType.DateTime, oPEMEmpleoRequest.FechaIniciaProrroga));
            parametros.Add(new SqlParameterItem("@x_dFecFinPro", SqlDbType.DateTime, oPEMEmpleoRequest.FechaFinProrroga));
            parametros.Add(new SqlParameterItem("@x_cEscSalEmp", SqlDbType.Char, oPEMEmpleoRequest.Escala));
            parametros.Add(new SqlParameterItem("@x_cCategoEmp", SqlDbType.VarChar, oPEMEmpleoRequest.Categoria));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMEmpleoRequest.UsuaioRegistra));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }


        public PEMEmpleoResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMEmpleoResponse()
            {
                Codigo =  reader.GetValue(0).ToString().Trim(),
                CodigoPersona = reader.GetValue(1).ToString().Trim(),
                RegimenLaboral = reader.GetValue(2).ToString().Trim(),
                TipoTrabajador = reader.GetValue(3).ToString().Trim(),
                TipoContrato = reader.GetValue(4).ToString().Trim(),
                ModoContrato = reader.GetValue(5).ToString().Trim(),
                FechaInicio = reader.GetValue(6).ToString().Trim(),
                FechaFin = reader.GetValue(7).ToString().Trim(),
                FechaContrato = reader.GetValue(8).ToString().Trim(),
                FechaInicioProrroga = reader.GetValue(9).ToString().Trim(),
                FechaFinProrroga = reader.GetValue(10).ToString().Trim(),
                EscalaSalarial = reader.GetValue(11).ToString().Trim(),
                Categoria = reader.GetValue(12).ToString().Trim(),

            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
