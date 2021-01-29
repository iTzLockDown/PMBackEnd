using PeruMoney.WS.Modelo.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Dominio.Contrato.Seguridad
{
    public interface ILoginDominio:IDisposable
    {
        bool Autentificacion(string usuario, string password);
        bool CambiarContrasenia(string usuario, string password, string nuevoPassword);
        PEMUsuarioResponse TraerUsuario(string usuario, string password);
    }
}
