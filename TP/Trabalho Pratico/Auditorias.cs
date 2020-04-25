using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Pratico
{
    class Auditorias
    {
        #region Member Variables

        const int MAXAUDITORIAS = 200;
        static Auditoria[] auditorias;
        static int totAuditorias;
        
        #endregion

        #region Constructors

        public Auditorias()
        {
            auditorias = new Auditoria[MAXAUDITORIAS];
            totAuditorias = 0;
        }



        #endregion

        #region Properties

        #endregion

        #region Functions

        public static bool VerificaExisteAuditoria(Auditoria a)
        {
            for (int i = 0; i < totAuditorias; i++)
            {
                if (a.Equals(auditorias[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool AdicionaAuditoria(Auditoria a)
        {
            if (totAuditorias >= MAXAUDITORIAS) return false;

            if (VerificaExisteAuditoria(a)) return false;

            auditorias[totAuditorias] = a;
            totAuditorias++;
            return true;
        }

        #endregion

        #region Enums

        #endregion

        #region Indexadores

        public Auditoria this[int i]
        {
            get { return auditorias[i]; }
            set { auditorias[i] = value; }
        }

        #endregion

    }
}
