using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class SocialPersonaDominio: ISocialPersonaDominio
    {
        public PEMSocialPersonaResponse TraerTodos(int codigoPersona)
        {
            PEMSocialPersonaResponse oLista = null;
            using (ISocialPersonaRepositorio oRepositorio = new SocialPersonaRepositorio())
            {
                oLista = oRepositorio.TraerTodos(codigoPersona);
            }

            return oLista;
        }

        public bool Grabar(PEMSocialPersonaRequest oPEMSocialPersonaRequest)
        {
            bool respuesta = false;
            using (ISocialPersonaRepositorio oRepositorio = new SocialPersonaRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMSocialPersonaRequest);
            }

            return respuesta;
        }

        public bool Editar(PEMSocialPersonaRequest oPEMSocialPersonaRequest)
        {
            bool respuesta = false;
            using (ISocialPersonaRepositorio oRepositorio = new SocialPersonaRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMSocialPersonaRequest);
            }

            return respuesta;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
