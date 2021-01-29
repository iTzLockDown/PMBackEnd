using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    /// <summary>
    /// sp: PLA_UpdUsuari_sp
    /// </summary>
    public class PEMUsuarioRequest
    {
        public int Codigo { get; set; }
        public int CodigoPersona { get; set; } //@x_nCodigoPer
        public string Usuario { get; set; } //@x_nCodUsuSis
        public string Contrasenia { get; set; } //@x_cConUsuSis
        public int UsuarioRegistra { get; set; }     //@x_cCodUsuIns

    }
}
