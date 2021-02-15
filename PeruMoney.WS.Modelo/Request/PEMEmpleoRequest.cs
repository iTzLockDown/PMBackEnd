using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMEmpleoRequest
    {
        public int Codigo { get; set; }      //@x_nCodEmpPer
        public int CodigoPersona { get; set; }   //@x_nCodigoPer
        public int CodigoAFP { get; set; }   //@x_nCodigoAfp
        public int COdigoOcupacion { get; set; }   //@x_nCodigoOcu
        public string DescripcionCargo { get; set; }   //@x_cDesCarEmp
        public double SueldoBase { get; set; }   //@x_nSueBasEmp
        public int CodigoSede { get; set; }   //@x_nCodigoSed
        public int UsuarioRegistra { get; set; }   //@x_nCodUsuIns

    }
}
