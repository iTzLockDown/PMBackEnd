using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class EducacionPersonaRepositorio : IEducacionPersonaRepositorio
    {
        public IEnumerable<PEMEducacionPersonalResponse> TraerTodos()
        {
            return null;
        }
        public bool Grabar(PEMEducacionPersonalRequest oPEMEducacionPersonalRequest)
        {
            return false;
        }
        public bool Editar(PEMEducacionPersonalRequest oPEMEducacionPersonalRequest)
        { 
            return false;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
