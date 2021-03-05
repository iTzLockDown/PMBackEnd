using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Dominio
{
    public interface IDocumentoRepositorio:IDisposable
    {
        IEnumerable<PEMDocumentoResponse> TraerTodos();
    }
}
