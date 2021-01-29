using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    /// <summary>
    /// sp: PLA_LisSedes_sp
    /// </summary>
    public class PEMSedeResponse
    {
        public string Codigo { get; set; }  //nCodigoSed
        public string Nombre{ get; set; }  //nNombreSed
        public string Direccion{ get; set; }  //nDireciSed
        public string Estado { get; set; }  //lEstadoSed
    }
}
