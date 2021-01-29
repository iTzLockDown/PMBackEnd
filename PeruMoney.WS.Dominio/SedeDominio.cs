using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class SedeDominio : ISedeDominio
    {

        public IEnumerable<PEMSedeResponse> TraerTodos()
        {
            IEnumerable<PEMSedeResponse> oLista = null;
            using (ISedeRepositorio oRepositorio = new SedeRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }
            return oLista;
        }
        public bool Grabar(PEMSedeRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            using (ISedeRepositorio oRepositorio = new SedeRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMSedeRequest);
            }
            return respuesta;
        }
        public bool Editar(PEMSedeRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            using (ISedeRepositorio oRepositorio = new SedeRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMSedeRequest);
            }
            return respuesta;
        }

        public bool Eliminar(int codigoPersona, int codigoUsuario)
        {
            bool respuesta = false;
            using (ISedeRepositorio oRepositorio = new SedeRepositorio())
            {
                respuesta = oRepositorio.Eliminar(codigoPersona, codigoUsuario);
            }
            return respuesta;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
