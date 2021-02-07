using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Modelo.Request
{
    public class PEMEliminaObjetoRequest
    {
        public int Codigo{ get; set; }      //Codigo de Elemento a eliminar
        public int CodigoUsuario{ get; set; }   //Codigo de usuario que elimina
    }
}
