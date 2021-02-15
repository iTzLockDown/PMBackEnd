using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IDetalleEmpleoPersonaRepositorio:IDisposable
    {
        IEnumerable<PEMEmpleoPersonaResponse> TraerTodos();
        bool Grabar(PEMEmpleoPersonaRequest oPEMEmpleoPersonaRequest);
        bool Editar(PEMEmpleoPersonaRequest oPEMEmpleoPersonaRequest);
    }
}
