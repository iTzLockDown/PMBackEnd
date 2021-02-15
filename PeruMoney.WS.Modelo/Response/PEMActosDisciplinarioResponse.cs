using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMActosDisciplinarioResponse
    {
        public string Codigo { get; set; }  //nCodigoDis
        public string CodigoPersona { get; set; }  //nCodigoPer
        public string TipoSancion { get; set; }  //cTipSanDis
        public string FechaSancion { get; set; }  //dFecSanDis
        public string MotivoSancion { get; set; }  //cMotSanDis
    }


}
