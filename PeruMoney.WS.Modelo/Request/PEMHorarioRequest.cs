using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMHorarioRequest
    {
        public int Codigo { get; set; }     //@x_nCodigoHor
        public string DEscripcion { get; set; }      //@x_cDescriHor
        public string HoraIni { get; set; }      //@x_nHorIniHor
        public string HoraFin { get; set; }      //@x_nHorFinHor
        public int UsuarioRegistra { get; set; }      //@x_nCodUsuIns

    }
}
