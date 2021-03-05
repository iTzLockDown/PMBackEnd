using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IEmpleoDominio : IDisposable
    {
        PEMEmpleoResponse TraerTodos(int codigoPersona);
        bool Grabar(PEMEmpleoRequest oPEMEmpleoRequest);
        bool Editar(PEMEmpleoRequest oPEMEmpleoRequest);
    }
}
