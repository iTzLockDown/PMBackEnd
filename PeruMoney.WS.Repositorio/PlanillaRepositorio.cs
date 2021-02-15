using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class PlanillaRepositorio: IPlanillaRepositorio
    {
        public IEnumerable<PEMPlanillaResponse> TraerTodos()
        {
            return null;
        }
        public bool Grabar(PEMPlanillaRequest oPEMPlanillaRequest)
        {
            return false;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
