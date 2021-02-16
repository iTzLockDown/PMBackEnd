using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class PlanillaDominio: IPlanillaDominio
    {
        public IEnumerable<PEMPlanillaResponse> TraerTodos(int codigoEmpleado)
        {
            IEnumerable<PEMPlanillaResponse> oLista = null;
            using (IPlanillaRepositorio oRepositorio = new PlanillaRepositorio())
            {
                oLista = oRepositorio.TraerTodos(codigoEmpleado);
            }

            return oLista;
        }
        public bool Grabar(PEMPlanillaRequest oPEMPlanillaRequest)
        {
            bool respuesta = false;
            using (IPlanillaRepositorio oRepositorio = new PlanillaRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMPlanillaRequest);
            }

            return respuesta;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
