using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMEmpleo
    {

        public string Codigo { get; set; }      //nCodEmpPer  
        public string CodigoPersona { get; set; }      //nCodigoPer   
        public string CodifoAFP { get; set; }      //nCodigoAfp   
        public string CodigoOcupacion { get; set; }      //nCodigoOcu   
        public string DescripcionCargo { get; set; }      //cDesCarEmp   
        public string SueldoBase { get; set; }      //nSueBasEmp   
        public string CodigoSede { get; set; }      //nCodigoSed
    }
}
