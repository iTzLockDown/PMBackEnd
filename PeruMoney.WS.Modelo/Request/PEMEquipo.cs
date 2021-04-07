using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMEquipo
    {
        /// <summary>
        /// SP: PLA_RegTerReg_sp, PLA_HabEquTer_sp
        /// </summary>
        public int Codigo{ get; set; }      //@x_nCodigoTer 
        public string Nombre { get; set; }      //@x_cNombreTer
        public string MediaAccessControl { get; set; }      //@x_cDirMacTer
        public string ProtocoloInternetPublico { get; set; }      //@x_cIppublTer
        public string ProtocoloInternetPrivado { get; set; }      //@x_cIpprivTer
        public int Usuario { get; set; }      //@x_nCodUsuIns

        public bool Estado{ get; set; } //@x_nEstEquTer
    }
}
