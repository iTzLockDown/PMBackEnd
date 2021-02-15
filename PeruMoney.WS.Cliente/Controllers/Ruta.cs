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
            public const string ListaAsistencia = "asistencia";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
            public const string Eliminar = "eliminar";
           
        }
        public class UriAsistencia
        {
            public const string Prefijo = "api/asistencia";
            public const string Entrada = "entrada";
            public const string Salida = "salida";
            public const string EntradaExtra = "entradaextra";
            public const string SalidaExtra = "salidaextra";
            public const string TraerPersonal = "traerpersonal";
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
        public class UriHorario
        {
            public const string Prefijo = "api/horario";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
            public const string Eliminar = "eliminar";
        }
        public class UriHorarioAgencia
        {
            public const string Prefijo = "api/horarioagencia";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Eliminar = "eliminar";
        }
        public class UriOcupacion
        {
            public const string Prefijo = "api/ocupacion";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
            public const string Eliminar = "eliminar";
        }
        public class UriDisciplinaPersona
        {
            public const string Prefijo = "api/disciplinapersona";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
            public const string Eliminar = "eliminar";
        }
        public class UriDetalleEmpleo
        {
            public const string Prefijo = "api/detalleempleo";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
        }
        public class UriEducacionPersona
        {
            public const string Prefijo = "api/educacionpersona";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
        }
        public class UriFamiliaPersona
        {
            public const string Prefijo = "api/familiapersona";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
            public const string Eliminar = "eliminar";
        }
        public class UriCuentaPersona
        {
            public const string Prefijo = "api/cuentapersona";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
            public const string Eliminar = "eliminar";
        }
        public class UriPlanilla
        {
            public const string Prefijo = "api/planila";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
        }
        public class UriEmpleo
        {
            public const string Prefijo = "api/empleo";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
            public const string Eliminar = "eliminar";
        }
        public class UriAFP
        {
            public const string Prefijo = "api/afp";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
            public const string Eliminar = "eliminar";
        }

        public class UriSocial
        {
            public const string Prefijo = "api/social";
            public const string ListaTodos = "lista";
            public const string Grabar = "grabar";
            public const string Editar = "editar";
        }


    }
}
