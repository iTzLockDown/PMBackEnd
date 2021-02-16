using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMFamiliaPersonalRequest
    {
        public int Codigo { get; set; } //@x_nCodigoFam
        public int CodigoPersona { get; set; }      //@x_nCodigoPer
        public string ApellidoPaterno { get; set; }      //@x_cApePatFam
        public string ApellidoMaterno{ get; set; }      //@x_cApeMatFam
        public string Nombre { get; set; }      //@x_cNombreFam
        public string TipoDocumento{ get; set; }      //@x_cTipDocFam
        public string Documento{ get; set; }      //@x_cDocIdeFam
        public string Direccion{ get; set; }      //@x_cDireccFam
        public string Telefono{ get; set; }      //@x_cTelefoFam
        public string Celular{ get; set; }      //@x_cTelMovFam
        public string Correo{ get; set; }      //@x_cCorEleFam
        public string Genero{ get; set; }      //@x_cGeneroFam
        public string Relacion{ get; set; }      //@x_cRelaciFam
        public int UsuarioRegistra { get; set; }      //@x_nCodUsuIns
 
    }
}
