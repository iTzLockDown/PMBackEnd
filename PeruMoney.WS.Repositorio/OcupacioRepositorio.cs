using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class OcupacioRepositorio : IOcupacioRepositorio

    {
        public IEnumerable<PEMOcupacionResponse> TraerTodos()
        {
            return null;
        }
        public bool Grabar(PEMOcupacionRequest oPEMOcupacionRequest)
        {
            return false;
        }
        public bool Editar(PEMOcupacionRequest oPEMOcupacionRequest)
        {
            return false;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            return false;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
