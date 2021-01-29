using PeruMoney.WS.Dominio.Contrato.Seguridad;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato;
using PeruMoney.WS.Repositorio.Seguridad;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Dominio.Seguridad
{
    public class LoginDominio:ILoginDominio
    {
        #region Metodos
        public bool Autentificacion(string usuario, string password)
        {
            bool respuesta = false;
            using (ILoginRepositorio oRepositorio = new LoginRepositorio())
            {
                respuesta = oRepositorio.Autentificacion(usuario, password);
            }

            return respuesta;
        }

        public PEMUsuarioResponse TraerUsuario(string usuario, string password)
        {
            PEMUsuarioResponse oUsuario = null;
            using (ILoginRepositorio oRepositorio = new LoginRepositorio())
            {
                oUsuario = oRepositorio.TraerUsuario(usuario, password);
            }

            return oUsuario;
        }
        public bool CambiarContrasenia(string usuario, string password, string nuevoPassword)
        {
            bool respuesta = false;
            using (ILoginRepositorio oRepositorio = new LoginRepositorio())
            {
                respuesta = oRepositorio.CambiarContrasenia(usuario, password, nuevoPassword);
            }

            return respuesta;
        }
 
        #endregion

        #region Dispose
       public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
