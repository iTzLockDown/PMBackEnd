﻿using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.SqlServer
{
    public interface IHorarioAgenciaDominio:IDisposable

    {
        IEnumerable<PEMHorarioAgenciaResponse> TraerTodos(int codigoSede);
        bool Grabar(PEMHorarioAgenciaRequest oPEMHorarioAgenciaRequest);
        bool Eliminar(PEMHorarioAgenciaRequest oPEMHorarioAgenciaRequest);
    }
}
