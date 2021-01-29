using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruMoney.WS.Cliente.Controllers
{
    public class Ruta
    {
     
        public class UriLogin
        {
            public const string Prefijo = "api/login";
            public const string Autentificacion = "autentificacion";
        }

        public class UriPersona
        {
            public const string Prefijo = "api/personal";
            public const string ListaTodos = "lista";
            public const string ListaUno = "listauno";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
            public const string Eliminar = "eliminar";
            public const string Entrada = "entrada";
            public const string Salida = "salida";
        }

        public class UriSede
        {
            public const string Prefijo = "api/sedes";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
            public const string Eliminar = "eliminar";
        }

        public class UriUsuario
        {
            public const string Prefijo = "api/usuario";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
            public const string Eliminar = "eliminar";
        }
    }
}
