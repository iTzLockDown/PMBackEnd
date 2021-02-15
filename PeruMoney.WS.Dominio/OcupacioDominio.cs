using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class OcupacioDominio : IOcupacioDominio

    {
        public IEnumerable<PEMOcupacionResponse> TraerTodos()
        {
            IEnumerable<PEMOcupacionResponse> oLista = null;
            using (IOcupacioRepositorio oRepositorio = new OcupacioRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }

            return oLista;
        }
        public bool Grabar(PEMOcupacionRequest oPEMOcupacionRequest)
        {
            bool respuesta = false;
            using (IOcupacioRepositorio oRepositorio = new OcupacioRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMOcupacionRequest);
            }

            return respuesta;
        }
        public bool Editar(PEMOcupacionRequest oPEMOcupacionRequest)
        {
            bool respuesta = false;
            using (IOcupacioRepositorio oRepositorio = new OcupacioRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMOcupacionRequest);
            }

            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IOcupacioRepositorio oRepositorio = new OcupacioRepositorio())
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
