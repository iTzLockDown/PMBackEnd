using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IPlanillaRepositorio:IDisposable
    {
        IEnumerable<PEMPlanillaResponse> TraerTodos(int codigoEmpleado);
        bool Grabar(PEMPlanillaRequest oPEMPlanillaRequest);
    }
}
