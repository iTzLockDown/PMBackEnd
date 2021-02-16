using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMAFPRequest
    {
        public int Codigo { get; set; }        //@x_nCodigoAfp
        public double ComisionFija { get; set; }        //@x_nComFijAfp
        public double ComisionMixta { get; set; }        //@x_nComMixSob
        public double ComisionMixtaAnual { get; set; }        //@x_nComMixAnu
        public double PrimaSeguro { get; set; }        //@x_nPriSegAfp
        public double AFP { get; set; }        //@x_cAdmFonPen
        public double ComisionSobreFlujo { get; set; }        //@x_nComSobFlu
        public double PorcentajeObligatorio { get; set; }        //@x_nPorOblAfp
        public double RemuneracionMaxima { get; set; }        //@x_nRemMaxAse
        public int UsuarioRegistra { get; set; }        //@x_nCodUsuIns

    }
}
