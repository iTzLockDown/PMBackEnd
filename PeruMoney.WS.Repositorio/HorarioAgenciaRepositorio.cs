using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.SqlServer
{
    public class HorarioAgenciaRepositorio : IHorarioAgenciaRepositorio

    {
        public IEnumerable<PEMHorarioAgenciaResponse> TraerTodos()
        {
            return null;
        }
        public bool Grabar(PEMHorarioAgenciaRequest oPEMHorarioAgenciaRequest)
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
