using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IEstadoCivilRepositorio: IDisposable
    {
        IEnumerable<PEMEstadoCivilResponse> TraerTodos();
    }
}
