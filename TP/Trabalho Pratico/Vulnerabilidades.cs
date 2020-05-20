using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Pratico
{
    class Vulnerabilidades
    {
        #region MemberVariables

        const int MAXVULNERABILIDADES = 400;
        static List<Vulnerabilidade> vulnerabilidades;
        static int totVulnerabilidades;
        #endregion
        
        #region Constructors
        static Vulnerabilidades()
        {
            vulnerabilidades = new List<Vulnerabilidade>();
        }
        #endregion

        #region Functions

        public static bool VerificaExisteVulnerabilidade(Vulnerabilidade v)
        {
            for (int i = 0; i < totVulnerabilidades; i++)
            {
                if (v.Equals(vulnerabilidades[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool AdicionaEquipamento(Vulnerabilidade v)
        {
            if (totVulnerabilidades >= MAXVULNERABILIDADES) return false;

            if (VerificaExisteVulnerabilidade(v)) return false;

            vulnerabilidades[totVulnerabilidades] = v;
            totVulnerabilidades++;
            return true;
        }


        #endregion

        #region Indexadores

        public Vulnerabilidade this[int i]
        {
            get { if (i < MAXVULNERABILIDADES) return vulnerabilidades[i]; return null; }
            set { if (i < MAXVULNERABILIDADES) vulnerabilidades[i] = value; totVulnerabilidades = vulnerabilidades.Count; }
        }


        #endregion
    }
}
