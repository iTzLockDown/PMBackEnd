using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo
{
	/// <summary>
	/// sp: PLA_InsPerson_sp
	/// </summary>
	public class PEMPersonaRequest
    {
        public int Codigo { get; set; }     //@x_nCodigoPer
		public string ApellidoPaterno { get; set; }  //@x_cApePatPer
		public string ApellidoMaterno { get; set; }  //@x_cApeMatPer
		public string Nombre{ get; set; }  //@x_cNombrePer
        public int TipoDocumento{ get; set; }	//@x_cTipDocPer
		public string Documento{ get; set; }  //@x_cDocIdePer
		public string Direccion{ get; set; }  //@x_cDireccPer
		public string Telefono{ get; set; }  //@x_cTelefoPer
        public string Celular { get; set; } //@x_cTelMovPer
		public string Email{ get; set; }  //@x_cCorElePer
		public string Genero { get; set; }	//@x_cGeneroPer
		public int EstadoCivil { get; set; }	//@x_nCodEstCiv
		public int UsuarioRegistra{ get; set; }  //@x_cCodUsuIns

	}
}
