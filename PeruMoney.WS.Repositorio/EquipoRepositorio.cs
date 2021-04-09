using PeruMoney.WS.Bloque.SqlServer;
using PeruMoney.WS.Bloque.SqlServer.Clases;
using PeruMoney.WS.Bloque.SqlServer.Funciones;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato;
using PeruMoney.WS.Repositorio.Contrato.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PeruMoney.WS.Repositorio
{
    public class EquipoRepositorio: IEquipoRepositorio
    {
        public IEnumerable<PEMEquipoResponse> TraerTodos() 
        {
            IEnumerable<PEMEquipoResponse> oLista = null;
            string sp = StoredProcedure.USP_EQUIPO_LISTAR;
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }
            return oLista;
        }
        public bool GrabarEditar(PEMEquipo oPEMEquipo)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_EQUIPO_REGISTRAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cNombreTer", SqlDbType.VarChar, oPEMEquipo.Nombre));
            parametros.Add(new SqlParameterItem("@x_cDirMacTer", SqlDbType.VarChar, oPEMEquipo.MediaAccessControl));
            parametros.Add(new SqlParameterItem("@x_cIppublTer", SqlDbType.VarChar, oPEMEquipo.ProtocoloInternetPublico));
            parametros.Add(new SqlParameterItem("@x_cIpprivTer", SqlDbType.VarChar, oPEMEquipo.ProtocoloInternetPrivado));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMEquipo.Usuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Habilitar(PEMEquipo oPEMEquipo)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_EQUIPO_HABILITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoTer", SqlDbType.Int, oPEMEquipo.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodUsuUpd", SqlDbType.Int, oPEMEquipo.Usuario));
            parametros.Add(new SqlParameterItem("@x_nEstEquTer", SqlDbType.Bit, oPEMEquipo.Estado));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_EQUIPO_ELIMINAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoTer", SqlDbType.Int, oPEMEliminaObjetoRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_nCodUsuDel", SqlDbType.Int, oPEMEliminaObjetoRequest.CodigoUsuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public PEMEquipoResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMEquipoResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                Nombre = reader.GetValue(1).ToString().Trim(),
                MAC = reader.GetValue(2).ToString().Trim(),
                IPPub = reader.GetValue(3).ToString().Trim(),
                IPPri = reader.GetValue(4).ToString().Trim(),
                Estado = reader.GetValue(5).ToString().Trim(),

            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}