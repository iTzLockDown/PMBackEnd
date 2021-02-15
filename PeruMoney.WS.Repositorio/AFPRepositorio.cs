using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class AFPRepositorio : IAFPRepositorio
    {
        public IEnumerable<PEMEmpleoResponse> TraerTodos()
        {
            return null;
        }

        public bool Grabar(PEMEmpleoRequest oPEMEmpleoRequest)
        {
            return false;
        }
        public bool Editar(PEMEmpleoRequest oPEMEmpleoRequest)
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
