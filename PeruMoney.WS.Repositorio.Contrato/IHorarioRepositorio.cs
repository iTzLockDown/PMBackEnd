using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IHorarioRepositorio:IDisposable
    {
        IEnumerable<PEMHorarioReponse> TraerTodos();
        bool Grabar(PEMHorarioRequest oPEMHorarioRequest);
        bool Editar(PEMHorarioRequest oPEMHorarioRequest);
        bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest);
    }
}
