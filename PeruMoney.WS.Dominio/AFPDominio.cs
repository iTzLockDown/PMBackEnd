using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class AFPDominio : IAFPDominio
    {
        public IEnumerable<PEMEmpleoResponse> TraerTodos()
        {
            IEnumerable<PEMEmpleoResponse> oLista = null;
            using (IAFPRepositorio oRepositorio = new AFPRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }

            return oLista;
        }

        public bool Grabar(PEMEmpleoRequest oPEMEmpleoRequest)
        {
            bool respuesta = false;
            using (IAFPRepositorio oRepositorio = new AFPRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMEmpleoRequest);
            }

            return respuesta;
        }
        public bool Editar(PEMEmpleoRequest oPEMEmpleoRequest)
        {
            bool respuesta = false;
            using (IAFPRepositorio oRepositorio = new AFPRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMEmpleoRequest);
            }

            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IAFPRepositorio oRepositorio = new AFPRepositorio())
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
