using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMFamiliaPersonaResponse
    {
        public string Codigo { get; set; }    //nCodigoFam,   
        public string CodigoPersona { get; set; }    //nCodigoPer,   
        public string ApellidoPaterno{ get; set; }    //cApePatFam,   
        public string ApellidoMaterno{ get; set; }    //cApeMatFam,   
        public string Nombre{ get; set; }    //cNombreFam,   
        public string TipoDocumento{ get; set; }    //cTipDocFam,   
        public string Documento{ get; set; }    //cDocIdeFam,   
        public string Direccion{ get; set; }    //cDireccFam,   
        public string Telefono{ get; set; }    //cTelefoFam,   
        public string Celular{ get; set; }    //cTelMovFam,   
        public string Correo{ get; set; }    //cCorEleFam,   
        public string Genero{ get; set; }    //cGeneroFam
        public string Relacion { get; set; } //cRelaciFam
    }
}
