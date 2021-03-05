using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Dominio.Contrato
{
    public interface IDocumentoDominio : IDisposable
    {
        IEnumerable<PEMDocumentoResponse> TraerTodos();
    }
}
