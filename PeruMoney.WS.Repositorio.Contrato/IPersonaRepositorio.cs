using PeruMoney.WS.Modelo;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Modelo.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeruMoney.WS.Repositorio.Contrato
{
    public interface IPersonaRepositorio:IDisposable
    {
        IEnumerable<PEMPersonaResponse> TraerTodos();
        PEMPersonaResponse TraerUno(string documento);
        bool Grabar(PEMPersonaRequest oPEMSedeRequest);
        bool Editar(PEMPersonaRequest oPEMSedeRequest);
        bool Eliminar(PEMEliminaObjetoRequest oPEMEliminaObjetoRequest);
        bool Entrada(PEMAsistenciaRequest oPEMAsistenciaRequest);
        bool Salida(PEMAsistenciaRequest oPEMAsistenciaRequest);
    }
}
