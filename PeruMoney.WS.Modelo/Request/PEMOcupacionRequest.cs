using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMOcupacionRequest
    {
        public int Codigo { get; set; }         //@x_nCodigoOcu
        public string Descripcion { get; set; }    //@x_cDescriOcu
        public int UsuarioRegistra { get; set; }    //@x_nCodUsuIns

    }
}
