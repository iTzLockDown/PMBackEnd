using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PeruMoney.WS.Repositorio.Contrato.SqlServer
{
    public class StoredProcedure
    {
        #region Usuario
        public const string USP_USUARIO_AUTH = "FIN_AutUseApp_SP";

        #endregion

        #region Personal
        public const string USP_PERSONAL_TRAERTODOS = "PLA_LisPerson_sp";
        public const string USP_PERSONAL_GRABAR = "PLA_InsPerson_sp";
        public const string USP_PERSONAL_EDITAR = "PLA_UpdPerson_sp";
        public const string USP_PERSONAL_ELIMINAR = "PLA_DelPerson_sp";
        public const string USP_PERSONAL_TRAERUNO = "PLA_LisUnoPer_sp";

        public const string USP_PERSONAL_REGISTRAENTRADA = "PLA_RegEntPer_sp";
        public const string USP_PERSONAL_REGISTRASALIDA = "PLA_RegSalPer_sp";
        #endregion

        #region Personal
        public const string USP_USUARIO_TRAERTODOS = "PLA_LisUsuari_sp";
        public const string USP_USUARIO_GRABAR = "PLA_InsUsuari_sp";
        public const string USP_USUARIO_EDITAR = "PLA_UpdUsuari_sp";
        public const string USP_USUARIO_ELIMINAR = "PLA_DelUsuari_sp";
        #endregion

        #region Sede
        public const string USP_SEDE_TRAERTODOS = "PLA_LisSedes_sp";
        public const string USP_SEDE_GRABAR = "PLA_InserSed_sp";
        public const string USP_SEDE_EDITAR = "PLA_UpdateSed_sp";
        public const string USP_SEDE_ELIMINAR = "PLA_DelSedes_sp";
        #endregion

        #region Registro de Actividad
        public const string USP_ACTIVIDAD_INGRESAR = "PLA_RegEntPer_sp";
        public const string USP_ACTIVIDAD_SALIR = "PLA_RegSalPer_sp";
        #endregion
    }
}
