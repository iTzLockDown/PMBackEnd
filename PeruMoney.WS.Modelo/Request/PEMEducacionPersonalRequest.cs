using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMEducacionPersonalRequest
    {
        public int CodigoPersona { get; set; }       //@x_nCodigoPer
        public string NivelAcademico{ get; set; }       //@x_cNivAcaPer
        public string EntidadEducativa{ get; set; }       //@x_cEntEduPer
        public string Carrera{ get; set; }       //@x_cCarrerPer
        public DateTime FechaFinEstudio{ get; set; }       //@x_dFecCulEst
        public string Postgrado{ get; set; }       //@x_cPostgrado
        public string EspecializacionPostgrado{ get; set; }       //@x_cEspeciPos
        public DateTime FechaFinEspecializacion{ get; set; }       //@x_dFecFinEsp
        public string Idioma{ get; set; }       //@x_cIdiomaEst
        public string NivelIdioma{ get; set; }       //@x_cNivIdiEst
        public int UsuarioRegistra{ get; set; }       //@x_nCodUsuIns

    }
}
