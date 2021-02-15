using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class SocialPersonaRepositorio: ISocialPersonaRepositorio
    {
        public IEnumerable<PEMSocialPersonaResponse> TraerTodos()
        {
            return null;
        }

        public bool Grabar(PEMSocialPersonaRequest oPEMSocialPersonaRequest)
        {
            return false;
        }

        public bool Editar(PEMSocialPersonaRequest oPEMSocialPersonaRequest)
        {
            return false;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
