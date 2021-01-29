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
		public string Documento{ get; set; }  //@x_cDocIdePer
		public string Direccion{ get; set; }  //@x_cDireccPer
		public string Telefono{ get; set; }  //@x_cTelefoPer
		public string Email{ get; set; }  //@x_cCorElePer
		public int UsuarioRegistra{ get; set; }  //@x_cCodUsuIns


	}
}
