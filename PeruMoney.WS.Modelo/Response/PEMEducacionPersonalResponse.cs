using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Response
{
    public class PEMEducacionPersonalResponse
    {
        public string Codigo { get; set; }      //nCodPerEdu,   
        public string CodigoPersona { get; set; }      //nCodigoPer,   
        public string NivelAcademico { get; set; }      //cNivAcaPer,   
        public string EntidadEducativa{ get; set; }      //cEntEduPer,   
        public string Carrera{ get; set; }      //cCarrerPer,   
        public string FechaCulminacion{ get; set; }      //dFecCulEst,   
        public string PostGrado{ get; set; }      //cPostgrado,   
        public string EspecializacionPostgrado{ get; set; }      //cEspeciPos,   
        public string FechaFinEspecializacion{ get; set; }      //dFecFinEsp,   
        public string Idioma{ get; set; }      //cIdiomaEst,   
        public string NivelIdioma{ get; set; }      //cNivIdiEst
    }
}
