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
using Microsoft.VisualBasic.CompilerServices;

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

        public PEMPersonaResponse TraerUnoCodigo(int codigoPersona)
        {
            PEMPersonaResponse oObjeto = null;
            string sp = StoredProcedure.USP_PERSONAL_TRAERCODIGO;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.Int, codigoPersona));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oObjeto = reader.Select(DesdeDataReaderCodigo).FirstOrDefault();
                }
            }
            return oObjeto;
        }

        public IEnumerable<PEMAsistenciaPersonaResponse> TraerTodosDocumento(string documento)
        {
            IEnumerable<PEMAsistenciaPersonaResponse> oLista = null;
            string sp = StoredProcedure.USP_PERSONAL_TRAERDOCUMENTO;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cDocIdePer", SqlDbType.VarChar, documento));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oLista = reader.Select(DesdeDataReaderListaAsistencia).ToList();
                }
            }

            return oLista;
        }

        public bool Editar(PEMPersonaRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_PERSONAL_EDITAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem( "@x_nCodigoPer", SqlDbType.VarChar, oPEMSedeRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_cApePatPer", SqlDbType.VarChar, oPEMSedeRequest.ApellidoPaterno));
            parametros.Add(new SqlParameterItem("@x_cApeMatPer", SqlDbType.VarChar, oPEMSedeRequest.ApellidoMaterno));
            parametros.Add(new SqlParameterItem("@x_cNombrePer", SqlDbType.VarChar, oPEMSedeRequest.Nombre));
            parametros.Add(new SqlParameterItem("@x_nTipDocPer", SqlDbType.Int, oPEMSedeRequest.TipoDocumento));
            parametros.Add(new SqlParameterItem("@x_cDocIdePer", SqlDbType.VarChar, oPEMSedeRequest.Documento));
            parametros.Add(new SqlParameterItem("@x_cDireccPer", SqlDbType.VarChar, oPEMSedeRequest.Direccion));
            parametros.Add(new SqlParameterItem("@x_cTelefoPer", SqlDbType.VarChar, oPEMSedeRequest.Telefono));
            parametros.Add(new SqlParameterItem("@x_cTelMovPer", SqlDbType.VarChar, oPEMSedeRequest.Celular));
            parametros.Add(new SqlParameterItem("@x_cCorElePer", SqlDbType.VarChar, oPEMSedeRequest.Email));
            parametros.Add(new SqlParameterItem("@x_cGeneroPer", SqlDbType.VarChar, oPEMSedeRequest.Genero));
            parametros.Add(new SqlParameterItem("@x_nCodEstCiv", SqlDbType.Int, oPEMSedeRequest.EstadoCivil));
            parametros.Add(new SqlParameterItem("@x_nCodUsuUpd", SqlDbType.Int, oPEMSedeRequest.UsuarioRegistra));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_PERSONAL_ELIMINAR;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoPer", SqlDbType.VarChar, oPEMEliminaObjetoRequest.Codigo));
            parametros.Add(new SqlParameterItem("@x_NCodUsuDel", SqlDbType.VarChar, oPEMEliminaObjetoRequest.CodigoUsuario));
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
            parametros.Add(new SqlParameterItem("@x_cTipDocPer", SqlDbType.Int, oPEMSedeRequest.TipoDocumento));
            parametros.Add(new SqlParameterItem("@x_cDocIdePer", SqlDbType.VarChar, oPEMSedeRequest.Documento));
            parametros.Add(new SqlParameterItem("@x_cDireccPer", SqlDbType.VarChar, oPEMSedeRequest.Direccion));
            parametros.Add(new SqlParameterItem("@x_cTelefoPer", SqlDbType.VarChar, oPEMSedeRequest.Telefono));
            parametros.Add(new SqlParameterItem("@x_cTelMovPer", SqlDbType.VarChar, oPEMSedeRequest.Celular));
            parametros.Add(new SqlParameterItem("@x_cCorElePer", SqlDbType.VarChar, oPEMSedeRequest.Email));
            parametros.Add(new SqlParameterItem("@x_cGeneroPer", SqlDbType.VarChar, oPEMSedeRequest.Genero));
            parametros.Add(new SqlParameterItem("@x_nCodEstCiv", SqlDbType.Int, oPEMSedeRequest.EstadoCivil));
            parametros.Add(new SqlParameterItem("@x_nCodUsuIns", SqlDbType.Int, oPEMSedeRequest.UsuarioRegistra));

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
            parametros.Add(new SqlParameterItem("@x_nHorSedAsi", SqlDbType.Int, oPEMAsistenciaRequest.CodigoHorario ));
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

        public bool EntradaExtra(PEMAsistenciaRequest oPEMAsistenciaRequest)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_PERSONAL_REGISTRAENTRADA_EXTRA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cDocIdePer", SqlDbType.VarChar, oPEMAsistenciaRequest.DocumentoPersona));
            parametros.Add(new SqlParameterItem("@x_nCodigoSed", SqlDbType.VarChar, oPEMAsistenciaRequest.CodigoSede));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool SalidaExtra(PEMAsistenciaRequest oPEMAsistenciaRequest)
        {

            bool respuesta = false;
            string sp = StoredProcedure.USP_PERSONAL_REGISTRASALIDA_EXTRA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cDocIdePer", SqlDbType.VarChar, oPEMAsistenciaRequest.DocumentoPersona));
            parametros.Add(new SqlParameterItem("@x_nCodSedExt", SqlDbType.VarChar, oPEMAsistenciaRequest.CodigoSede));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public PEMRegistroAsistenciaResponse AsistenciaDiaria(string documento)
        {
            PEMRegistroAsistenciaResponse oObjeto = null;
            string sp = StoredProcedure.USP_PERSONAL_ASISTENCIA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cDocIdePer", SqlDbType.VarChar, documento));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oObjeto = reader.Select(DesdeDataReaderAsistencia).FirstOrDefault();
                }
            }
            return oObjeto;
        }

        #endregion

        #region DataReader
        public PEMRegistroAsistenciaResponse DesdeDataReaderAsistencia(IDataReader reader)
        {
            return new PEMRegistroAsistenciaResponse()
            {
                HoraIngreso = reader.GetValue(0).ToString().Trim(),
                HoraSalida = reader.GetValue(1).ToString().Trim(),
                NombreSede = reader.GetValue(2).ToString().Trim(),
                Horario = reader.GetValue(3).ToString().Trim(),
                HoraIngresoExtra = reader.GetValue(4).ToString().Trim(),
                HoraSalidaExtra = reader.GetValue(5).ToString().Trim(),
                NombreSedeExtra = reader.GetValue(6).ToString().Trim(),
         
                
            };
        }
        public PEMPersonaResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMPersonaResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                ApellidoPaterno = reader.GetValue(1).ToString().Trim(),
                ApellidoMaterno = reader.GetValue(2).ToString().Trim(),
                Nombre = reader.GetValue(3).ToString().Trim(),
                CodigoTipoDocumento = reader.GetValue(4).ToString().Trim(),
                Documento = reader.GetValue(5).ToString().Trim(),
                Direccion = reader.GetValue(6).ToString().Trim(),
                Telefono = reader.GetValue(7).ToString().Trim(),
                Celular = reader.GetValue(8).ToString().Trim(),
                Email = reader.GetValue(9).ToString().Trim(),
                CodigoEstadoCivil = reader.GetValue(10).ToString().Trim(),
                Genero = reader.GetValue(11).ToString().Trim(),
                EstadoCivil = reader.GetValue(12).ToString().Trim(),
                Estado = reader.GetValue(13).ToString().Trim(),
                Cargo = reader.GetValue(14).ToString().Trim()
            };
        }
        public PEMPersonaResponse DesdeDataReaderCodigo(IDataReader reader)
        {
            return new PEMPersonaResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                ApellidoPaterno = reader.GetValue(1).ToString().Trim(),
                ApellidoMaterno = reader.GetValue(2).ToString().Trim(),
                Nombre = reader.GetValue(3).ToString().Trim(),
                CodigoTipoDocumento = reader.GetValue(4).ToString().Trim(),
                Documento = reader.GetValue(5).ToString().Trim(),
                Direccion = reader.GetValue(6).ToString().Trim(),
                Telefono = reader.GetValue(7).ToString().Trim(),
                Celular = reader.GetValue(8).ToString().Trim(),
                Email = reader.GetValue(9).ToString().Trim(),
                Genero = reader.GetValue(10).ToString().Trim(),
                CodigoEstadoCivil = reader.GetValue(11).ToString().Trim(),
                FechaIngreso = reader.GetValue(12).ToString().Trim(),
                Cargo = reader.GetValue(13).ToString().Trim(),
                Ocupacion = reader.GetValue(14).ToString().Trim()
                
            };
        }
        public PEMAsistenciaPersonaResponse DesdeDataReaderListaAsistencia(IDataReader reader)
        {
            return new PEMAsistenciaPersonaResponse()
            {

                Codigo = reader.GetValue(0).ToString().Trim(),
                Informacion = reader.GetValue(1).ToString().Trim(),
                NombreSede = reader.GetValue(2).ToString().Trim(),
                HoraIngreso= reader.GetValue(3).ToString().Trim(),
                FechaIngreso= reader.GetValue(4).ToString().Trim(),
                HoraSalida= reader.GetValue(5).ToString().Trim(),
                FechaSalida= reader.GetValue(6).ToString().Trim(),
               
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
