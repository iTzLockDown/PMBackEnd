using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMEmpleoRequest
    {
        public int CodigoPersona { get; set; }  //@x_nCodigoPer
        public string RegimenLaboral { get; set; }  //@x_cRegLabEmp
        public string TipoTrabajo { get; set; }  //@x_cTipTraEmp
        public string TipoContrato { get; set; }  //@x_cTipConEmp
        public string ModoContrato { get; set; }  //@x_cModConEmp
        public DateTime FechaIniciaContrato { get; set; }  //@x_dFecIniCon
        public DateTime FechaFinContrato { get; set; }  //@x_dFecFinCon
        public DateTime FechaContrato { get; set; }  //@x_dFecConEmp
        public DateTime FechaIniciaProrroga { get; set; }  //@x_dFecIniPro
        public DateTime FechaFinProrroga { get; set; }  //@x_dFecFinPro
        public string Escala { get; set; }  //@x_cEscSalEmp
        public string Categoria { get; set; }  //@x_cCategoEmp
        public int UsuaioRegistra { get; set; }  //@x_nCodUsuIns


    }
}
