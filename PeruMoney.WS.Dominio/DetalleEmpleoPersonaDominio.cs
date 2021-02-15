using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class DetalleEmpleoPersonaDominio : IDetalleEmpleoPersonaDominio
    {
        public IEnumerable<PEMEmpleoPersonaResponse> TraerTodos()
        {
            IEnumerable<PEMEmpleoPersonaResponse> oLista = null;
            using (IDetalleEmpleoPersonaRepositorio oRepositorio = new DetalleEmpleoPersonaRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }

            return oLista;
        }
        public bool Grabar(PEMEmpleoPersonaRequest oPEMEmpleoPersonaRequest)
        {
            bool respuesta = false;
            using (IDetalleEmpleoPersonaRepositorio oRepositorio = new DetalleEmpleoPersonaRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMEmpleoPersonaRequest);
            }

            return respuesta;
        }
        public bool Editar(PEMEmpleoPersonaRequest oPEMEmpleoPersonaRequest)
        {
            bool respuesta = false;
            using (IDetalleEmpleoPersonaRepositorio oRepositorio = new DetalleEmpleoPersonaRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMEmpleoPersonaRequest);
            }

            return respuesta;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

 
    }
}
