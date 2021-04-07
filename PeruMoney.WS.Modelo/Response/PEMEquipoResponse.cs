using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMEquipoResponse
    {
        public string Codigo { get; set; }  //nCodigoTer
        public string Nombre { get; set; }  //cNombreTer
        public string MAC { get; set; }  //cDirMacTer
        public string IPPub { get; set; }  //cIppublTer
        public string IPPri { get; set; }  //cIpprivTer
        public string Estado { get; set; }  //nEstEquTer
    }
}
 				