using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IDisciplinaPersonaRepositorio:IDisposable
    {
        IEnumerable<PEMActosDisciplinarioResponse> TraerTodos();
        bool Grabar(PEMActosDisciplinariosRequest oPEMActosDisciplinariosRequest);
        bool Editar(PEMActosDisciplinariosRequest oPEMActosDisciplinariosRequest);
        bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest);
    }
}
