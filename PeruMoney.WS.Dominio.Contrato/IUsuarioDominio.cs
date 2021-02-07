using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IUsuarioDominio : IDisposable
    {
        IEnumerable<PEMUserResponse> TraerTodos();
        bool Grabar(PEMUsuarioRequest oPEMUsuarioRequest);
        bool Editar(PEMUsuarioRequest oPEMUsuarioRequest);
        bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest);
    }
}
