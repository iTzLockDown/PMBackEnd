using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMActosDisciplinariosRequest
    {
        public int Codigo { get; set; }     //@x_nCodigoDis
        public int  CodigoPersona { get; set; }    //@x_nCodigoPer
        public string TipoSancion { get; set; }     //@x_cTipSanDis
        public DateTime FechaSancion { get; set; }     //@x_dFecSanDis
        public string MotivoSancion { get; set; }     //@x_cMotSanDis
        public int UsuarioRegistra { get; set; }     //@x_nCodUsuIns

    }
}
