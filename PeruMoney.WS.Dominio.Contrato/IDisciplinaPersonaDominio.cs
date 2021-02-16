using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IDisciplinaPersonaDominio:IDisposable
    {
        IEnumerable<PEMActosDisciplinarioResponse> TraerTodos(int codigoPersona);
        bool Grabar(PEMActosDisciplinariosRequest oPEMActosDisciplinariosRequest);
        bool Editar(PEMActosDisciplinariosRequest oPEMActosDisciplinariosRequest);
        bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest);
    }
}
