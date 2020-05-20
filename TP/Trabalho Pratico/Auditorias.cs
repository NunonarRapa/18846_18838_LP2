using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Pratico
{
    class Auditorias
    {
        #region Member Variables

        const int MAXAUDITORIAS = 200;
        static List<Auditoria> auditorias;
        static int totAuditorias;
        
        #endregion

        #region Constructors
        static Auditorias()
        {
            auditorias = new List<Auditoria>();
            totAuditorias = auditorias.Count;
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
            try
            {
                Auditoria aux = new Auditoria(a.colaborador, a.data, a.duracao, (a.codigo-1));
                aux.codigo = a.codigo;
                aux.colaborador = a.colaborador;
                aux.data = a.data;
                aux.duracao = a.duracao;
                aux.numeroVulnerabilidades = a.numeroVulnerabilidades;

                if (totAuditorias >= MAXAUDITORIAS) return false;

                if (VerificaExisteAuditoria(aux)) return false;

                auditorias.Add(aux);
                totAuditorias = auditorias.Count;
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;
        }

        #endregion

        #region Enums

        #endregion

        #region Indexadores

        public Auditoria this[int i]
        {
            get { if (i < MAXAUDITORIAS) return auditorias[i]; return null; }
            set { if (i < MAXAUDITORIAS) auditorias[i] = value; totAuditorias = auditorias.Count; }
        }

        #endregion
    }
}
