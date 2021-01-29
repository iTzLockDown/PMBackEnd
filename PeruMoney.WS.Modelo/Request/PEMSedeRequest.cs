using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMSedeRequest
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; } //@x_nNombreSed
        public string Direccion { get; set; } //@x_nDireciSed
        public int UsuarioRegistra { get; set; } //@x_cCodUsuIns

    }
}
