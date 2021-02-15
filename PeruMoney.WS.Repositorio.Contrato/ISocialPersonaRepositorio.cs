using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface ISocialPersonaRepositorio:IDisposable
    {
        IEnumerable<PEMSocialPersonaResponse> TraerTodos();
        bool Grabar(PEMSocialPersonaRequest oPEMSocialPersonaRequest);
        bool Editar(PEMSocialPersonaRequest oPEMSocialPersonaRequest);
    }
}
