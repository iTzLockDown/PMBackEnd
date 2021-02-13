using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMAsistenciaPersonaResponse
    {
        public string Codigo { get; set; }    //nCodigoPer
        public string Informacion { get; set; }    //cInfPerPer
        public string NombreSede { get; set; }    //nNombreSed
        public string HoraIngreso { get; set; }    //nHorIngUsu
        public string FechaIngreso { get; set; }    //dFecIngUsu
        public string HoraSalida { get; set; }    //nHorSalUsu
        public string FechaSalida { get; set; }    //dFecSalUsu

    }
}
