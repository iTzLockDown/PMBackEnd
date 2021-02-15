using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IDetalleEmpleoPersonaDominio:IDisposable
    {
        IEnumerable<PEMEmpleoPersonaResponse> TraerTodos();
        bool Grabar(PEMEmpleoPersonaRequest oPEMEmpleoPersonaRequest);
        bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest);
    }
}
