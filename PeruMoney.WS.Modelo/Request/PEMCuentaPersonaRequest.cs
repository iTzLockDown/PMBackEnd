using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMCuentaPersonaRequest
    {
        public int Codigo{ get; set; } //@x_nCodigoCue
        public int CodigoPersona { get; set; }  //@x_nCodigoPer
        public string Banco { get; set; }  //@x_cBanCobCue
        public string Numero { get; set; }  //@x_cNumCuenta
        public string TipoMoneda { get; set; }  //@x_cTipMoneda
        public string BancoCTS { get; set; }  //@x_cBanCobCts
        public string NumeroCTS { get; set; }  //@x_cNumCueCts
        public int UsuarioRegistra { get; set; }  //@x_nCodUsuIns

    }
}
