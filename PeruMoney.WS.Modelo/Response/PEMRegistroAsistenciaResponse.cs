using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMRegistroAsistenciaResponse
    {
        public string HoraIngreso { get; set; }      //nHorIngUsu
        public string HoraSalida { get; set; }      //nHorSalUsu
        public string NombreSede { get; set; }      //cNombreSed
        public string Horario { get; set; }      //cHorariAsi
        public string HoraIngresoExtra { get; set; }      //nHorIngExt
        public string HoraSalidaExtra { get; set; }      //nHorSalExt
        public string NombreSedeExtra { get; set; }      //cNombreSed
                 

    }
}
