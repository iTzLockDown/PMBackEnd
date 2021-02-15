using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMAFPResponse
    {

        public string Codigo { get; set; }   //nCodigoAfp   
        public string ComisionFija { get; set; }   //nComFijAfp   
        public string ComisionMixtra { get; set; }   //nComMixSob   
        public string ComisionMixtaAnual { get; set; }   //nComMixAnu   
        public string PrimaSeguro { get; set; }   //nPriSegAfp   
        public string AFP { get; set; }   //cAdmFonPen   
        public string ComisionFijaFlujo { get; set; }   //nComSobFlu   
        public string PorcentajeObligatoriaAFP { get; set; }   //nPorOblAfp   
        public string RemuneracionMaxima { get; set; }   //nRemMaxAse
    }
}
