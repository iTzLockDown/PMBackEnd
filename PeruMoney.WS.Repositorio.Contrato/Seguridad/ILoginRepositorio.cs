using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Response;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface ILoginRepositorio:IDisposable
    {
        bool Autentificacion(string usuario, string password);
        PEMUsuarioResponse TraerUsuario(string usuario, string password);
        bool CambiarContrasenia(string usuario, string password, string nuevoPassword);
    }
}
