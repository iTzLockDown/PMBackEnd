using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class AFPRepositorio : IAFPRepositorio
    {
        public IEnumerable<PEMAFPResponse> TraerTodos()
        {
            return null;
        }

        public bool Grabar(PEMAFPRequest oPEMAFPRequest)
        {
            return false;
        }
        public bool Editar(PEMAFPRequest oPEMAFPRequest)
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
