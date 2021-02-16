using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class FamiliaPersonaIDominio : IFamiliaPersonaIDominio
    {
        public IEnumerable<PEMFamiliaPersonaResponse> TraerTodos(int codigoPersona)
        {
            IEnumerable<PEMFamiliaPersonaResponse> oLista = null;
            using (IFamiliaPersonaRepositorio oRepositorio = new FamiliaPersonaRepositorio())
            {
                oLista = oRepositorio.TraerTodos(codigoPersona);
            }

            return oLista;
        }
        public bool Grabar(PEMFamiliaPersonalRequest oPEMFamiliaPersonalRequest)
        {
            bool respuesta = false;
            using (IFamiliaPersonaRepositorio oRepositorio = new FamiliaPersonaRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMFamiliaPersonalRequest);
            }

            return respuesta;
        }
        public bool Editar(PEMFamiliaPersonalRequest oPEMFamiliaPersonalRequest)
        {
            bool respuesta = false;
            using (IFamiliaPersonaRepositorio oRepositorio = new FamiliaPersonaRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMFamiliaPersonalRequest);
            }

            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IFamiliaPersonaRepositorio oRepositorio = new FamiliaPersonaRepositorio())
            {
                respuesta = oRepositorio.Eliminar(oPEMEliminaObjetoRequest);
            }

            return respuesta;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
