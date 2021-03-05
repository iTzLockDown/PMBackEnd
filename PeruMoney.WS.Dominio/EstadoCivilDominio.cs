using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Dominio.Contrato;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio;
using PeruMoney.WS.Repositorio.Contrato;

namespace PeruMoney.WS.Dominio
{
    public class EstadoCivilDominio: IEstadoCivilDominio
    {
        public IEnumerable<PEMEstadoCivilResponse> TraerTodos()
        {
            IEnumerable<PEMEstadoCivilResponse> oLista = null;
            using (IEstadoCivilRepositorio oRepositorio = new EstadoCivilRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }

            return oLista;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
