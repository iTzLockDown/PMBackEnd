using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface ISedeRepositorio:IDisposable
    {
        IEnumerable<PEMSedeResponse> TraerTodos();
        bool Grabar(PEMSedeRequest oPEMSedeRequest);
        bool Editar(PEMSedeRequest oPEMSedeRequest);
        bool Eliminar(int codigoPersona, int codigoUsuario);
    }
}
