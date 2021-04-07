using PeruMoney.WS.Modelo.Request;
using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IEquipoDominio: IDisposable
    {
        IEnumerable<PEMEquipoResponse> TraerTodos();
        bool GrabarEditar(PEMEquipo oPEMEquipo);
        bool Habilitar(PEMEquipo oPEMEquipo);
        bool Eliminar(int codigoTerminal, int codigoUsuario);
    }

}
