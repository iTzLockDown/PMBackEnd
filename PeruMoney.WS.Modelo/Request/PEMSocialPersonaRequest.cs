using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMSocialPersonaRequest
    {
        public int CodigoPersona { get; set; }    //@x_nCodigoPer
        public string SeguroSocial { get; set; }    //@x_cSegSocPer
        public string NombreEPS { get; set; }    //@x_cNomEpsPer
        public string EstadoSPP { get; set; }    //@x_cEstSppPer
        public string SistemaPensiones { get; set; }    //@x_cSisPenPer
        public string TipoCompensacion { get; set; }    //@x_cTipComPer
        public string CUSPP { get; set; }    //@x_cCusppPers
        public string AporteActivo { get; set; }    //@x_cApoActPer
        public string SeguroVida { get; set; }    //@x_cSegVidLey
        public string NumeroPolizaVida { get; set; }    //@x_cNumPolVid
        public string SCT { get; set; }    //@x_cSegComTra
        public string NumeroPolizaESS { get; set; }    //@x_cNumPolEss
        public string NumeroPolizaPen { get; set; }    //@x_cNumPolPen
        public int UsuarioRegistra { get; set; }    //@x_nCodUsuIns
    }
}
