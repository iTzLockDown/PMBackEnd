﻿using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IPlanillaDominio:IDisposable
    {
        IEnumerable<PEMPlanillaResponse> TraerTodos();
        bool Grabar(PEMPlanillaRequest oPEMPlanillaRequest);
    }
}