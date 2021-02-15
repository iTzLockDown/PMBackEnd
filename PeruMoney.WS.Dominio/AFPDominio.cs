using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class AFPDominio : IAFPDominio
    {
        public IEnumerable<PEMAFPResponse> TraerTodos()
        {
            IEnumerable<PEMAFPResponse> oLista = null;
            using (IAFPRepositorio oRepositorio = new AFPRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }

            return oLista;
        }

        public bool Grabar(PEMAFPRequest oPEMAFPRequest)
        {
            bool respuesta = false;
            using (IAFPRepositorio oRepositorio = new AFPRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMAFPRequest);
            }

            return respuesta;
        }
        public bool Editar(PEMAFPRequest oPEMAFPRequest)
        {
            bool respuesta = false;
            using (IAFPRepositorio oRepositorio = new AFPRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMAFPRequest);
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
