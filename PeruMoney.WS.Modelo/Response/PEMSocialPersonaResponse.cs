using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMSocialPersonaResponse
    {
        public string codigo { get; set; }       //nCodigoSoc   
        public string CodigoPersona { get; set; }       //nCodigoPer   
        public string SeguroSocial { get; set; }       //cSegSocPer   
        public string NombreEPS { get; set; }       //cNomEpsPer   
        public string EstadoSPP { get; set; }       //cEstSppPer   
        public string SistemaPensiones { get; set; }       //cSisPenPer   
        public string TipoCompensacion { get; set; }       //cTipComPer   
        public string CUSPP { get; set; }       //cCusppPers   
        public string Aporte { get; set; }       //cApoActPer   
        public string SeguroVida { get; set; }       //cSegVidLey   
        public string NumeroPolisaVida { get; set; }       //cNumPolVid   
        public string SCT { get; set; }       //cSegComTra   
        public string NumeroPolisaESS { get; set; }       //cNumPolEss   
        public string NumeroPolisaPen { get; set; }       //cNumPolPen

    }
}
