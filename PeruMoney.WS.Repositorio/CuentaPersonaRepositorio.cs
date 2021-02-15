using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class CuentaPersonaRepositorio : ICuentaPersonaRepositorio
    {
        public IEnumerable<PEMCuentaPersonaResponse> TraerTodos()
        {
            return null;
        }
        public bool Grabar(PEMCuentaPersonaRequest oPEMCuentaPersonaRequest)
        {
            return false;
        }
        public bool Editar(PEMCuentaPersonaRequest oPEMCuentaPersonaRequest)
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
