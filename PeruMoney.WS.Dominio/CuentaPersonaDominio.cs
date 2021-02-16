using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class CuentaPersonaDominio : ICuentaPersonaDominio
    {
        public IEnumerable<PEMCuentaPersonaResponse> TraerTodos(int codigoPersona)
        {
            IEnumerable<PEMCuentaPersonaResponse> oLista = null;
            using (ICuentaPersonaRepositorio oRepositorio = new CuentaPersonaRepositorio())
            {
                oLista = oRepositorio.TraerTodos(codigoPersona);
            }

            return oLista;
        }
        public bool Grabar(PEMCuentaPersonaRequest oPEMCuentaPersonaRequest)
        {
            bool respuesta = false;
            using (ICuentaPersonaRepositorio oRepositorio = new CuentaPersonaRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMCuentaPersonaRequest);
            }

            return respuesta;
        }
        public bool Editar(PEMCuentaPersonaRequest oPEMCuentaPersonaRequest)
        {
            bool respuesta = false;
            using (ICuentaPersonaRepositorio oRepositorio = new CuentaPersonaRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMCuentaPersonaRequest);
            }

            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (ICuentaPersonaRepositorio oRepositorio = new CuentaPersonaRepositorio())
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
