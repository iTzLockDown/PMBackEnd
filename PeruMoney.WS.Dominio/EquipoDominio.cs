using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio;
using PeruMoney.WS.Repositorio.Contrato;

namespace PeruMoney.WS.Dominio
{
    public class EquipoDominio: IEquipoDominio
    {
        public IEnumerable<PEMEquipoResponse> TraerTodos()
        {
            IEnumerable<PEMEquipoResponse> oLista = null;
            using (IEquipoRepositorio oRepositorio = new EquipoRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }
            return oLista;
        }

        public bool GrabarEditar(PEMEquipo oPemEquipo)
        {
            bool respuesta = false;
            using (IEquipoRepositorio oRepositorio = new EquipoRepositorio())
            {
                respuesta = oRepositorio.GrabarEditar(oPemEquipo);
            }
            return respuesta;
        }

        public bool Habilitar(PEMEquipo oPemEquipo)
        {
            bool respuesta = false;
            using (IEquipoRepositorio oRepositorio = new EquipoRepositorio())
            {
                respuesta = oRepositorio.Habilitar(oPemEquipo);
            }
            return respuesta;
        }
        public bool Eliminar(int codigoTerminal, int codigoUsuario)
        {
            bool respuesta = false;
            using (IEquipoRepositorio oRepositorio = new EquipoRepositorio())
            {
                respuesta = oRepositorio.Eliminar(codigoTerminal, codigoUsuario);
            }
            return respuesta;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
