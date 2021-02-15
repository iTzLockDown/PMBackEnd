using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class FamiliaPersonaRepositorio : IFamiliaPersonaRepositorio
    {
        public IEnumerable<PEMFamiliaPersonaResponse> TraerTodos()
        {
            return null;
        }
        public bool Grabar(PEMFamiliaPersonalRequest oPEMFamiliaPersonalRequest)
        {
            return false;
        }
        public bool Editar(PEMFamiliaPersonalRequest oPEMFamiliaPersonalRequest)
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
