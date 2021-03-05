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
        public const string USP_PERSONAL_TRAERDOCUMENTO = "PLA_LisAsiPer_sp";
        public const string USP_PERSONAL_GRABAR = "PLA_InsPerson_sp";
        public const string USP_PERSONAL_EDITAR = "PLA_UpdPerson_sp";
        public const string USP_PERSONAL_ELIMINAR = "PLA_DelPerson_sp";
        public const string USP_PERSONAL_TRAERUNO = "PLA_LisUnoPer_sp";
        public const string USP_PERSONAL_TRAERCODIGO = "PLA_LisUsuCod_SP";

        public const string USP_PERSONAL_REGISTRAENTRADA = "PLA_RegEntPer_sp";
        public const string USP_PERSONAL_REGISTRASALIDA = "PLA_RegSalPer_sp";
        public const string USP_PERSONAL_REGISTRAENTRADA_EXTRA = "PLA_RegEntExt_sp";
        public const string USP_PERSONAL_REGISTRASALIDA_EXTRA = "PLA_RegSalExt_sp";
        public const string USP_PERSONAL_ASISTENCIA = "PLA_AsiDiaPer_sp";
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



        #region Horario

        public const string USP_HORARIO_TRAERTODOS = "PLA_LisHorari_sp";
        public const string USP_HORARIO_GRABAR = "PLA_InsertHor_sp";
        public const string USP_HORARIO_EDITAR = "PLA_UpdateHor_sp";
        public const string USP_HORARIO_ELIMINAR = "PLA_DeleteHor_sp";

        #endregion

        #region Horario por Agencia

        public const string USP_HORARIO_AGENCIA_TRAERTODOS = "PLA_LisHorAge_sp";
        public const string USP_HORARIO_AGENCIA_GRABAR = "PLA_InsHorAge_sp";
        public const string USP_HORARIO_AGENCIA_ELIMINAR = "PLA_DelHorAge_sp";


        #endregion

        #region Ocupacion

        public const string USP_OCUPACION_TRAERTODOS = "PLA_LisOcupac_sp";
        public const string USP_OCUPACION_GRABAR = "PLA_InsertOcu_sp";
        public const string USP_OCUPACION_EDITAR = "PLA_UpdateOcu_sp";
        public const string USP_OCUPACION_ELIMINAR = "PLA_DeleteOcu_sp";

        #endregion

        #region Disciplina

        public const string USP_DISCIPLINA_TRAERTODOS = "PLA_LisDicPer_sp";
        public const string USP_DISCIPLINA_GRABAR = "PLA_InsDicPer_sp";
        public const string USP_DISCIPLINA_EDITAR = "PLA_UpdDicPer_sp";
        public const string USP_DISCIPLINA_ELIMINAR = "PLA_DelDicPer_sp";

        #endregion

        #region Detalle de Empleo
        public const string USP_DETALLEEMPLEO_TRAERTODOS = "PLA_LisDetEmp_sp";
        public const string USP_DETALLEEMPLEO_GRABAR = "PLA_InsDetEmp_sp";
        public const string USP_DETALLEEMPLEO_EDITAR = "PLA_UpdDetEmp_sp";

        #endregion

        #region Educacion del Persona
        public const string USP_EDUCACION_TRAERTODOS = "PLA_LisEduPer_sp";
        public const string USP_EDUCACION_GRABAR = "PLA_InsEduPer_sp";
        public const string USP_EDUCACION_EDITAR = "PLA_UpdEduPer_sp";
        #endregion

        #region Familiares de Persona
        public const string USP_FAMILIA_TRAERTODOS = "PLA_LisFamPer_sp";
        public const string USP_FAMILIA_GRABAR = "PLA_InsFamPer_sp";
        public const string USP_FAMILIA_EDITAR = "PLA_UpdFamPer_sp";
        public const string USP_FAMILIA_ELIMINAR = "PLA_DelFamPer_sp";

        #endregion

        #region Cuenta de Persona
        public const string USP_CUENTA_TRAERTODOS = "PLA_LisCuePer_sp";
        public const string USP_CUENTA_GRABAR = "PLA_InsCuePer_sp";
        public const string USP_CUENTA_EDITAR = "PLA_UpdCuePer_sp";
        public const string USP_CUENTA_ELIMINA = "PLA_DelCuePer_sp";

        #endregion

        #region Planilla
        public const string USP_PLANILLA_TRAERTODOS = "PLA_LisPlaPer_sp";
        public const string USP_PLANILLA_GRABAR = "PLA_InsPlaPer_sp";



        #endregion

        #region Empleo Persona

        public const string USP_EMPLEOPERSONA_TRAERTODOS = "PLA_LisEmpPer_sp";
        public const string USP_EMPLEOPERSONA_GRABAR = "PLA_InsEmpPer_sp";
        public const string USP_EMPLEOPERSONA_EDITAR = "PLA_UpdEmpPer_sp";
        public const string USP_EMPLEOPERSONA_ELIMINAR = "PLA_DelEmpPer_sp";


        #endregion

        #region AFP

        public const string USP_AFP_TRAERTODOS = "PLA_LisAfpEmp_sp";
        public const string USP_AFP_GRABAR = "PLA_InsAfpEmp_sp";
        public const string USP_AFP_EDITAR = "PLA_UpdAfpEmp_sp";
        public const string USP_AFP_ELIMINAR = "PLA_DelAfpEmp_sp";

        #endregion

        #region Social 

        public const string USP_SOCIAL_TRAERTODOS = "PLA_LisSocPer_sp";
        public const string USP_SOCIAL_GRABAR = "PLA_InsSocPer_sp";
        public const string USP_SOCIAL_EDITAR = "PLA_UpdSocPer_sp";

        #endregion

        #region Documento

        public const string USP_DOCUMENTO_TRAERTODOS = "PLA_LisDocume_SP";

        #endregion

        #region Estado Civil

        public const string USP_ESTADOCIVIL_TRAERTODOS = "PLA_LisEstCiv_SP";

        #endregion
    }
}
