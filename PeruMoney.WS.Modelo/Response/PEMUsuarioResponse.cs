using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    /// <summary>
    /// SP: FIN_AutUseApp_SP
    /// </summary>
    public class PEMUsuarioResponse
    {
        public string Codigo { get; set; }           //Codigo
        public string Usuario { get; set; }         //Usuario   
        public string CodigEstadoo { get; set; }    //Estado
        public string Perfil { get; set; }
        public string TokenJwt { get; set; }
    }
}
