﻿using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IUsuarioRepositorio:IDisposable
    {
        IEnumerable<PEMUserResponse> TraerTodos();
        bool Grabar(PEMUsuarioRequest oPEMSedeRequest);
        bool Editar(PEMUsuarioRequest oPEMSedeRequest);
        bool Eliminar(int codigoUsuario, int codigoUsuarioElimina);
    }
}
