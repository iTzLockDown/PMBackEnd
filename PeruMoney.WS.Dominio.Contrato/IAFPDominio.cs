using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IAFPDominio : IDisposable
    {
        IEnumerable<PEMAFPResponse> TraerTodos();
        bool Grabar(PEMAFPRequest oPEMAFPRequest);
        bool Editar(PEMAFPRequest oPEMAFPRequest);
        bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest);
    }
}
