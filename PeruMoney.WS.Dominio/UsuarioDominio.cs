using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class UsuarioDominio : IUsuarioDominio
    {
        public IEnumerable<PEMUserResponse> TraerTodos()
        {
            IEnumerable<PEMUserResponse> oLista = null;
            using (IUsuarioRepositorio oRepositorio = new UsuarioRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }
            return oLista;
        }
        public bool Grabar(PEMUsuarioRequest oPEMUsuarioRequest)
        {
            bool respuesta = false;
            using (IUsuarioRepositorio oRepositorio = new UsuarioRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMUsuarioRequest);
            }
            return respuesta;
        }

  
        public bool Editar(PEMUsuarioRequest oPEMUsuarioRequest)
        {
            bool respuesta = false;
            using (IUsuarioRepositorio oRepositorio = new UsuarioRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMUsuarioRequest);
            }
            return respuesta;
        }

        public bool Eliminar(int codigoUsuario, int codigoUsuarioElimina)
        {
            bool respuesta = false;
            using (IUsuarioRepositorio oRepositorio = new UsuarioRepositorio())
            {
                respuesta = oRepositorio.Eliminar(codigoUsuario, codigoUsuarioElimina);
            }
            return respuesta;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
