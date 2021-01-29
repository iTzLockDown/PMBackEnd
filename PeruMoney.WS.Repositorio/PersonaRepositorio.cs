using PeruMoney.WS.Bloque.SqlServer;
using PeruMoney.WS.Bloque.SqlServer.Clases;
using PeruMoney.WS.Bloque.SqlServer.Funciones;
using PeruMoney.WS.Modelo;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class PersonaRepositorio : IPersonaRepositorio
    {
        #region Metodos

        public IEnumerable<PEMPersonaResponse> TraerTodos()
        {
            IEnumerable<PEMPersonaResponse> oLista = null;
            string sp = StoredProcedure.USP_PERSONAL_TRAERTODOS;
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }
            return oLista;
        }

        public PEMPersonaResponse TraerUno(string documento)
        {
            PEMPersonaResponse oObjeto = null;
            string sp = StoredProcedure.USP_PERSONAL_TRAERUNO;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cDocIdePer", SqlDbType.VarChar, documento));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oObjeto = reader.Select(DesdeDataReader).FirstOrDefault();
                }
            }
            return oObjeto;
        }

        public bool Editar(PEMPersonaRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_PERSONAL_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem( "@x_nCodigoPer", SqlDbType.VarChar, oPEMSedeRequest.Codigo));
            parametros.Add(new SqlParameterItem( "@x_cApePatPer", SqlDbType.VarChar, oPEMSedeRequest.ApellidoPaterno));
            parametros.Add(new SqlParameterItem( "@x_cApeMatPer", SqlDbType.VarChar, oPEMSedeRequest.ApellidoMaterno));
            parametros.Add(new SqlParameterItem( "@x_cNombrePer", SqlDbType.VarChar, oPEMSedeRequest.Nombre));
            parametros.Add(new SqlParameterItem( "@x_cDocIdePer", SqlDbType.VarChar, oPEMSedeRequest.Documento));
            parametros.Add(new SqlParameterItem( "@x_cDireccPer", SqlDbType.VarChar, oPEMSedeRequest.Direccion));
            parametros.Add(new SqlParameterItem( "@x_cTelefoPer", SqlDbType.VarChar, oPEMSedeRequest.Telefono));
            parametros.Add(new SqlParameterItem( "@x_cCorElePer", SqlDbType.VarChar, oPEMSedeRequest.Email));
            parametros.Add(new SqlParameterItem( "@x_cCodUsuUpd", SqlDbType.Int, oPEMSedeRequest.UsuarioRegistra));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public bool Eliminar(int codigoPersona, int codigoUsuario)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_PERSONAL_ELIMINAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.VarChar, codigoPersona));
            parametros.Add(new SqlParameterItem("@x_cCodUsuDel", SqlDbType.VarChar, codigoUsuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public bool Grabar(PEMPersonaRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_PERSONAL_GRABAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();

            parametros.Add(new SqlParameterItem("@x_cApePatPer", SqlDbType.VarChar, oPEMSedeRequest.ApellidoPaterno));
            parametros.Add(new SqlParameterItem("@x_cApeMatPer", SqlDbType.VarChar, oPEMSedeRequest.ApellidoMaterno));
            parametros.Add(new SqlParameterItem("@x_cNombrePer", SqlDbType.VarChar, oPEMSedeRequest.Nombre));
            parametros.Add(new SqlParameterItem("@x_cDocIdePer", SqlDbType.VarChar, oPEMSedeRequest.Documento));
            parametros.Add(new SqlParameterItem("@x_cDireccPer", SqlDbType.VarChar, oPEMSedeRequest.Direccion));
            parametros.Add(new SqlParameterItem("@x_cTelefoPer", SqlDbType.VarChar, oPEMSedeRequest.Telefono));
            parametros.Add(new SqlParameterItem("@x_cCorElePer", SqlDbType.VarChar, oPEMSedeRequest.Email));
            parametros.Add(new SqlParameterItem("@x_cCodUsuIns", SqlDbType.Int, oPEMSedeRequest.UsuarioRegistra));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public bool Entrada(PEMAsistenciaRequest oPEMAsistenciaRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_PERSONAL_REGISTRAENTRADA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cDocIdePer", SqlDbType.VarChar, oPEMAsistenciaRequest.DocumentoPersona));
            parametros.Add(new SqlParameterItem("@x_nCodigoSed", SqlDbType.VarChar, oPEMAsistenciaRequest.CodigoSede));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Salida(PEMAsistenciaRequest oPEMAsistenciaRequest)
        {

            bool respuesta = false;
            string sp = StoredProcedure.USP_PERSONAL_REGISTRASALIDA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cDocIdePer", SqlDbType.VarChar, oPEMAsistenciaRequest.DocumentoPersona));
            parametros.Add(new SqlParameterItem("@x_nCodigoSed", SqlDbType.VarChar, oPEMAsistenciaRequest.CodigoSede));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        #endregion

        #region DataReader
        public PEMPersonaResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMPersonaResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                ApellidoPaterno = reader.GetValue(1).ToString().Trim(),
                ApellidoMaterno = reader.GetValue(2).ToString().Trim(),
                Nombre = reader.GetValue(3).ToString().Trim(),
                Documento = reader.GetValue(4).ToString().Trim(),
                Direccion = reader.GetValue(5).ToString().Trim(),
                Telefono = reader.GetValue(6).ToString().Trim(),
                Email = reader.GetValue(7).ToString().Trim(),
                Estado = reader.GetValue(8).ToString().Trim(),

            };
        }
    #endregion

        #region Dispose
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
