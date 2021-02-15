using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class EducacionPersonaDominio : IEducacionPersonaDominio
    {
        public IEnumerable<PEMEducacionPersonalResponse> TraerTodos()
        {
            IEnumerable<PEMEducacionPersonalResponse> oLista = null;
            using (IEducacionPersonaRepositorio oRepositorio = new EducacionPersonaRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }

            return oLista;
        }
        public bool Grabar(PEMEducacionPersonalRequest oPEMEducacionPersonalRequest)
        {
            bool respuesta = false;
            using (IEducacionPersonaRepositorio oRepositorio = new EducacionPersonaRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMEducacionPersonalRequest);
            }

            return respuesta;
        }
        public bool Editar(PEMEducacionPersonalRequest oPEMEducacionPersonalRequest)
        {
            bool respuesta = false;
            using (IEducacionPersonaRepositorio oRepositorio = new EducacionPersonaRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMEducacionPersonalRequest);
            }

            return respuesta;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
