using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    /// <summary>
    /// sp: PLA_RegEntPer_sp, PLA_RegSalPer_sp
    /// </summary>
    public class PEMAsistenciaRequest
    {
        public string DocumentoPersona{ get; set; }     //x_cDocIdePer
        public string CodigoSede{ get; set; }     //x_nCodigoSed
        public int CodigoHorario { get; set; }  //x_nHorSedAsis
        public string IpPublica { get; set; } //@x_cIppublTer
    }
}
