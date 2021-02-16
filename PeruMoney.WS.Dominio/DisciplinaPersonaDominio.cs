using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class DisciplinaPersonaDominio : IDisciplinaPersonaDominio
    {
        public IEnumerable<PEMActosDisciplinarioResponse> TraerTodos(int codigoPersona)
        {
            IEnumerable<PEMActosDisciplinarioResponse> oLista = null;
            using (IDisciplinaPersonaRepositorio oRepositorio = new DisciplinaPersonaRepositorio())
            {
                oLista = oRepositorio.TraerTodos(codigoPersona);
            }

            return oLista;
        }

        public bool Grabar(PEMActosDisciplinariosRequest oPEMActosDisciplinariosRequest)
        {
            bool respuesta = false;
            using (IDisciplinaPersonaRepositorio oRepositorio = new DisciplinaPersonaRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMActosDisciplinariosRequest);
            }

            return respuesta;
        }
        public bool Editar(PEMActosDisciplinariosRequest oPEMActosDisciplinariosRequest)
        {
            bool respuesta = false;
            using (IDisciplinaPersonaRepositorio oRepositorio = new DisciplinaPersonaRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMActosDisciplinariosRequest);
            }

            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IDisciplinaPersonaRepositorio oRepositorio = new DisciplinaPersonaRepositorio())
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
