using PeruMoney.WS.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio;

namespace PeruMoney.WS.Dominio
{
    public class DocumentoDominio: IDocumentoDominio
    {
        public IEnumerable<PEMDocumentoResponse> TraerTodos()
        {
            IEnumerable<PEMDocumentoResponse> oLista = null;
            using (IDocumentoRepositorio oRepositorio = new DocumentoRepositorio())
            {
                oLista
                    = oRepositorio.TraerTodos();
            }

            return oLista;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
