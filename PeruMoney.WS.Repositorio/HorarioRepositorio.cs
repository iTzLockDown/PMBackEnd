using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class HorarioRepositorio : IHorarioRepositorio
    {
        public IEnumerable<PEMHorarioReponse> TraerTodos()
        {
            return null;
        }
        public bool Grabar(PEMHorarioRequest oPEMHorarioRequest)
        {
            return false;
        }
        public bool Editar(PEMHorarioRequest oPEMHorarioRequest)
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
