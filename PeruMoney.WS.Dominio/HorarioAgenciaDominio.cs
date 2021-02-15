﻿using System;
using System.Collections.Generic;
using System.Text;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato;

namespace PeruMoney.WS.Repositorio.SqlServer
{
    public class HorarioAgenciaDominio : IHorarioAgenciaDominio

    {
        public IEnumerable<PEMHorarioAgenciaResponse> TraerTodos()
        {
            IEnumerable<PEMHorarioAgenciaResponse> oLista = null;
            using (IHorarioAgenciaRepositorio oRepositorio = new HorarioAgenciaRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }

            return oLista;
        }

        public bool Grabar(PEMHorarioAgenciaRequest oPEMHorarioAgenciaRequest)
        {
            bool respuesta = false;
            using (IHorarioAgenciaRepositorio oRepositorio = new HorarioAgenciaRepositorio())
            {
                respuesta = oRepositorio.Grabar(oPEMHorarioAgenciaRequest);
            }

            return respuesta;
        }
        public bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest)
        {
            bool respuesta = false;
            using (IHorarioAgenciaRepositorio oRepositorio = new HorarioAgenciaRepositorio())
            {
                respuesta = oRepositorio.Eliminar(oPEMEliminaObjetoRequest);
            }

            return respuesta;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}