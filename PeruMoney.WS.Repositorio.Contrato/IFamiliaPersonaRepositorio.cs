using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IFamiliaPersonaRepositorio:IDisposable
    {
        IEnumerable<PEMFamiliaPersonaResponse> TraerTodos();
        bool Grabar(PEMFamiliaPersonalRequest oPEMFamiliaPersonalRequest);
        bool Editar(PEMFamiliaPersonalRequest oPEMFamiliaPersonalRequest);
        bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest);
    }
}
