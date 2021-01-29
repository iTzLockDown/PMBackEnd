using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    /// <summary>
    /// sp:PLA_LisUsuari_sp
    /// </summary>
    public class PEMUserResponse
    {
        public string Codigo { get; set; }   //nCodigoUsu
        public string CodigoPersona { get; set; }   //nCodigoPer
        public string Informacion { get; set; }   //cInfPerson
        public string CodigoSistema{ get; set; }   //nCodUsuSis
        public string Estado { get; set; }   //lEstadoUsu

       
    }
}
