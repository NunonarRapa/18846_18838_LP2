using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Pratico
{
    class EquipamentosInf
    {
        #region MemberVariables

        const int MAXEQUIPAMENTOSINF = 200;
        static List<EquipamentoInf> equipamentoInfs;
        static int totEquipamentos;
        #endregion

        #region Constructors
        static EquipamentosInf()
        {
            equipamentoInfs = new List<EquipamentoInf>();
        }
        #endregion
        
        #region Properties

        #endregion

        #region Functions

        public static bool VerificaExisteEquipamento(EquipamentoInf e)
        {
            for (int i = 0; i < totEquipamentos; i++)
            {
                if (e.Equals(equipamentoInfs[i]))
                {
                    return true;
                }
            }
            return false;
        }
        
        public static  bool AdicionaEquipamento(EquipamentoInf e)
        {
            if (totEquipamentos >= MAXEQUIPAMENTOSINF) return false;

            if (VerificaExisteEquipamento(e)) return false;

            equipamentoInfs[totEquipamentos] = e;
            totEquipamentos++;
            return true;
        }


        #endregion

        #region Indexadores

        public EquipamentoInf this[int i]
        {
            get { if (i < MAXEQUIPAMENTOSINF) return equipamentoInfs[i]; return null; }
            set { if (i < MAXEQUIPAMENTOSINF) equipamentoInfs[i] = value; totEquipamentos = equipamentoInfs.Count; }
        }

        #endregion 

        #region Enums

        #endregion
    }
}