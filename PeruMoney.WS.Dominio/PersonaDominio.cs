using PeruMoney.WS.Modelo;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public class PersonaDominio : IPersonaDominio
    {
     
        public IEnumerable<PEMPersonaResponse> TraerTodos()
        {
            IEnumerable<PEMPersonaResponse> oLista = null;
            using (IPersonaRepositorio oRepositorio = new PersonaRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }
            return oLista;
        }
        public PEMPersonaResponse TraerUno(string documento)
        {
            PEMPersonaResponse oObjeto = null;
            using (IPersonaRepositorio oRepositorio = new PersonaRepositorio())
            {
                oObjeto = oRepositorio.TraerUno(documento);
            }
            return oObjeto;
        }
        public bool Grabar(PEMPersonaRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            using (IPersonaRepositorio oRepositorio = new PersonaRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMSedeRequest);
            }
            return respuesta;
        }
        public bool Editar(PEMPersonaRequest oPEMSedeRequest)
        {
            bool respuesta = false;
            using (IPersonaRepositorio oRepositorio = new PersonaRepositorio())
            {
                respuesta = oRepositorio.Editar(oPEMSedeRequest);
            }
            return respuesta;
        }
        public bool Eliminar(int codigoPersona, int codigoUsuario)
        {
            bool respuesta = false;
            using (IPersonaRepositorio oRepositorio = new PersonaRepositorio())
            {
                respuesta = oRepositorio.Eliminar(codigoPersona, codigoUsuario);
            }
            return respuesta;
        }
        public bool Entrada(PEMAsistenciaRequest oPEMAsistenciaRequest)
        {
            bool respuesta = false;
            using (IPersonaRepositorio oRepositorio = new PersonaRepositorio())
            {
                respuesta = oRepositorio.Entrada(oPEMAsistenciaRequest);
            }
            return respuesta;
        }
        public bool Salida(PEMAsistenciaRequest oPEMAsistenciaRequest)
        {
            bool respuesta = false;
            using (IPersonaRepositorio oRepositorio = new PersonaRepositorio())
            {
                respuesta = oRepositorio.Salida(oPEMAsistenciaRequest);
            }
            return respuesta;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
