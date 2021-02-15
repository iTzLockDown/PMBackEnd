using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class HorarioDominio : IHorarioDominio
    {
        public IEnumerable<PEMHorarioReponse> TraerTodos()
        {
            IEnumerable<PEMHorarioReponse> oLista = null;
            using (IHorarioRepositorio oRepositorio = new HorarioRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }

            return oLista;
        }
        public bool Grabar(PEMHorarioRequest oPEMHorarioRequest)
        {
            bool respuesta = false;
            using (IHorarioRepositorio oRepositorio = new HorarioRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMHorarioRequest);
            }

            return respuesta;
        }

        public bool Editar(PEMHorarioRequest oPEMHorarioRequest)
        {
            bool respuesta = false;
            using (IHorarioRepositorio oRepositorio = new HorarioRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMHorarioRequest);
            }

            return respuesta;
        }

        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IHorarioRepositorio oRepositorio = new HorarioRepositorio())
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
