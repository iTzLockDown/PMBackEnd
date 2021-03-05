using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class EmpleoDominio : IEmpleoDominio
    {
        public PEMEmpleoResponse TraerTodos(int codigoPersona)
        {
            PEMEmpleoResponse oLista = null;
            using (IEmpleoRepositorio oRepositorio = new EmpleoRepositorio())
            {
                oLista = oRepositorio.TraerTodos(codigoPersona);
            }

            return oLista;
        }
        public bool Grabar(PEMEmpleoRequest oPEMEmpleoRequest)
        {
            bool respuesta = false;
            using (IEmpleoRepositorio oRepositorio = new EmpleoRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMEmpleoRequest);
            }

            return respuesta;
        }
        public bool Editar(PEMEmpleoRequest oPEMEmpleoRequest)
        {
            bool respuesta = false;
            using (IEmpleoRepositorio oRepositorio = new EmpleoRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMEmpleoRequest);
            }

            return respuesta;
        }
     
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
