using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    /// <summary>
    /// sp: PLA_LisPerson_sp
    /// </summary>
    public class PEMPersonaResponse
    {
        public string Codigo { get; set; }     //nCodigoPer
        public string ApellidoPaterno { get; set; }     //cApePatPer
        public string ApellidoMaterno { get; set; }     //cApeMatPer
        public string Nombre { get; set; }     //cNombrePer
        public string Documento { get; set; }     //cDocIdePer
        public string Direccion { get; set; }     //cDireccPer
        public string Telefono { get; set; }     //cTelefoPer
        public string Celular { get; set; }           //cTelMovPer
        public string Email { get; set; }     //cCorElePer
        public string Genero { get; set; }  //cGeneroPer
        public string EstadoCivil { get; set; }        //cDEsEstCiv
        public string Estado { get; set; }     //lEstadoPer

    }
}
