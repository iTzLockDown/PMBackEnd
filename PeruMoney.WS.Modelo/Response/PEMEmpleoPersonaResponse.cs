using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMEmpleoPersonaResponse
    {
        public string Codigo { get; set; }  //nCodigoEmp,   
        public string CodigoPersona { get; set; }  //nCodigoPer,   
        public string RegimenLaboral { get; set; }  //cRegLabEmp,   
        public string TipoTrabajador { get; set; }  //cTipTraEmp,   
        public string TipoContrato { get; set; }  //cTipConEmp,   
        public string ModoContrato { get; set; }  //cModConEmp,   
        public string FechaInicio { get; set; }  //dFecIniCon,   
        public string FechaFin { get; set; }  //dFecFinCon,   
        public string FechaContrato { get; set; }  //dFecConEmp,   
        public string FechaInicioProrroga { get; set; }  //dFecIniPro,   
        public string FechaFinProrroga { get; set; }  //dFecFinPro,   
        public string EscalaSalarial { get; set; }  //cEscSalEmp,   
        public string Categoria { get; set; }  //cCategoEmp
    }
}
