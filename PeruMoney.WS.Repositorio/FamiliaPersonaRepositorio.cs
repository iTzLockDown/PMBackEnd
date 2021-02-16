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
    public class FamiliaPersonaRepositorio : IFamiliaPersonaRepositorio
    {
        public IEnumerable<PEMFamiliaPersonaResponse> TraerTodos(int codigoPersona)
        {
            IEnumerable<PEMFamiliaPersonaResponse> oLista = null;
            string sp = StoredProcedure.USP_FAMILIA_TRAERTODOS;
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
        public bool Grabar(PEMFamiliaPersonalRequest oPEMFamiliaPersonalRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_FAMILIA_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, oPEMFamiliaPersonalRequest.CodigoPersona));
            parametros.Add(new SqlParameterItem("@x_cApePatFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.ApellidoPaterno));
            parametros.Add(new SqlParameterItem("@x_cApeMatFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.ApellidoMaterno));
            parametros.Add(new SqlParameterItem("@x_cNombreFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Nombre));
            parametros.Add(new SqlParameterItem("@x_cTipDocFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.TipoDocumento));
            parametros.Add(new SqlParameterItem("@x_cDocIdeFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Documento));
            parametros.Add(new SqlParameterItem("@x_cDireccFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Direccion));
            parametros.Add(new SqlParameterItem("@x_cTelefoFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Telefono));
            parametros.Add(new SqlParameterItem("@x_cTelMovFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Celular));
            parametros.Add(new SqlParameterItem("@x_cCorEleFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Correo));
            parametros.Add(new SqlParameterItem("@x_cGeneroFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Genero));
            parametros.Add(new SqlParameterItem("@x_cRelaciFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Relacion));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMFamiliaPersonalRequest.UsuarioRegistra));

       
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Editar(PEMFamiliaPersonalRequest oPEMFamiliaPersonalRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_FAMILIA_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoFam", SqlDbType.Int, oPEMFamiliaPersonalRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_cApePatFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.ApellidoPaterno));
            parametros.Add(new SqlParameterItem("@x_cApeMatFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.ApellidoMaterno));
            parametros.Add(new SqlParameterItem("@x_cNombreFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Nombre));
            parametros.Add(new SqlParameterItem("@x_cTipDocFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.TipoDocumento));
            parametros.Add(new SqlParameterItem("@x_cDocIdeFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Documento));
            parametros.Add(new SqlParameterItem("@x_cDireccFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Direccion));
            parametros.Add(new SqlParameterItem("@x_cTelefoFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Telefono));
            parametros.Add(new SqlParameterItem("@x_cTelMovFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Celular));
            parametros.Add(new SqlParameterItem("@x_cCorEleFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Correo));
            parametros.Add(new SqlParameterItem("@x_cGeneroFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Genero));
            parametros.Add(new SqlParameterItem("@x_cRelaciFam", SqlDbType.VarChar, oPEMFamiliaPersonalRequest.Relacion));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMFamiliaPersonalRequest.UsuarioRegistra));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_FAMILIA_ELIMINAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoFam", SqlDbType.Char, oPEMEliminaObjetoRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Char, oPEMEliminaObjetoRequest.CodigoUsuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public PEMFamiliaPersonaResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMFamiliaPersonaResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                CodigoPersona = reader.GetValue(1).ToString().Trim(),
                ApellidoPaterno = reader.GetValue(2).ToString().Trim(),
                ApellidoMaterno = reader.GetValue(3).ToString().Trim(),
                Nombre = reader.GetValue(4).ToString().Trim(),
                TipoDocumento = reader.GetValue(5).ToString().Trim(),
                Documento = reader.GetValue(6).ToString().Trim(),
                Direccion = reader.GetValue(7).ToString().Trim(),
                Telefono= reader.GetValue(8).ToString().Trim(),
                Celular= reader.GetValue(9).ToString().Trim(),
                Correo= reader.GetValue(10).ToString().Trim(),
                Genero= reader.GetValue(11).ToString().Trim(),
                Relacion= reader.GetValue(12).ToString().Trim(),


            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
