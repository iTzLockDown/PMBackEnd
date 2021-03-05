using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using PeruMoney.WS.Bloque.SqlServer.Clases;
using PeruMoney.WS.Bloque.SqlServer.Funciones;
using PeruMoney.WS.Dominio;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato;
using PeruMoney.WS.Repositorio.Contrato.SqlServer;

namespace PeruMoney.WS.Repositorio
{
    public class DocumentoRepositorio: IDocumentoRepositorio
    {
        public IEnumerable<PEMDocumentoResponse> TraerTodos()
        {
            IEnumerable<PEMDocumentoResponse> oLista = null;
            string sp = StoredProcedure.USP_DOCUMENTO_TRAERTODOS;
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }

            return oLista;
        }

        public PEMDocumentoResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMDocumentoResponse()
            {
                CodigoDocumento  = reader.GetValue(0).ToString().Trim(),
                DescripcionCorta = reader.GetValue(1).ToString().Trim(),
                DescripcionLarga = reader.GetValue(2).ToString().Trim(),
            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
