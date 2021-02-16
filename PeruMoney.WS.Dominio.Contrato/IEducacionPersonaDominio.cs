using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IEducacionPersonaDominio:IDisposable
    {
        IEnumerable<PEMEducacionPersonalResponse> TraerTodos(int codigoPersona);
        bool Grabar(PEMEducacionPersonalRequest oPEMEducacionPersonalRequest);
        bool Editar(PEMEducacionPersonalRequest oPEMEducacionPersonalRequest);
    }
}
