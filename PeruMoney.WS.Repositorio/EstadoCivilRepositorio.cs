using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using PeruMoney.WS.Bloque.SqlServer.Clases;
using PeruMoney.WS.Bloque.SqlServer.Funciones;
using PeruMoney.WS.Modelo.Response;
using PeruMoney.WS.Repositorio.Contrato;
using PeruMoney.WS.Repositorio.Contrato.SqlServer;

namespace PeruMoney.WS.Repositorio
{
    public class EstadoCivilRepositorio: IEstadoCivilRepositorio
    {
        public IEnumerable<PEMEstadoCivilResponse> TraerTodos()
        {
            IEnumerable<PEMEstadoCivilResponse> oLista = null;
            string sp = StoredProcedure.USP_ESTADOCIVIL_TRAERTODOS;
            using (SqlHelperWS db = new SqlHelperWS(dbContext.PLAPERUMONEY()))
            {
                using (SqlDataReader reader  = db.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }

            return oLista;
        }

        public PEMEstadoCivilResponse DesdeDataReader(IDataReader reader)
        {
            return new PEMEstadoCivilResponse()
            {
                Codigo = reader.GetValue(0).ToString().Trim(),
                Descripcion = reader.GetValue(1).ToString().Trim(),
            };
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
