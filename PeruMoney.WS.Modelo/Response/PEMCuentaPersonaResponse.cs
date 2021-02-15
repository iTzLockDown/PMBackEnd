using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMCuentaPersonaResponse
    {

        public string Codigo { get; set; }  //nCodigoCue,   
        public string CodigoPersona { get; set; }  //nCodigoPer,   
        public string Banco { get; set; }  //cBanCobCue,   
        public string NumeroCuenta { get; set; }  //cNumCuenta,   
        public string TipoMoneda{ get; set; }  //cTipMoneda,   
        public string BancoCTS{ get; set; }  //cBanCobCts,   
        public string NumeroCuentaCTS{ get; set; }  //cNumCueCts
    }
}
