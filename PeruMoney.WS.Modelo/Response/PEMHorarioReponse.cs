using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMHorarioReponse
    {
        public string Codigo{ get; set; }   //nCodigoHor
        public string Descripcion { get; set; }    //cDescriHor
        public string Inicio { get; set; }    //nHorIniHor
        public string Fin { get; set; }    //nHorFinHor
        public string Estado { get; set; }    //lEstadoHor
        
    }
}
