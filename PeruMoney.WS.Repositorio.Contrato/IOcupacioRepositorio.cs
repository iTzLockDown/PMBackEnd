using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IOcupacioRepositorio:IDisposable

    {
        IEnumerable<PEMOcupacionResponse> TraerTodos();
        bool Grabar(PEMOcupacionRequest oPEMOcupacionRequest);
        bool Editar(PEMOcupacionRequest oPEMOcupacionRequest);
        bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest);
    }
}
