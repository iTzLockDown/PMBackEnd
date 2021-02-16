﻿using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface ICuentaPersonaDominio:IDisposable
    {
        IEnumerable<PEMCuentaPersonaResponse> TraerTodos(int codigoPersona);
        bool Grabar(PEMCuentaPersonaRequest oPEMCuentaPersonaRequest);
        bool Editar(PEMCuentaPersonaRequest oPEMCuentaPersonaRequest);
        bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest);
    }
}
