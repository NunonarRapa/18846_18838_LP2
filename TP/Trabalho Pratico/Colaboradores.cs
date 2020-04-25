using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Pratico
{
    class Colaboradores
    {
        #region Member Variables

        const int MAXCOLABORADORES = 200;
        static Colaborador[] colaboradores;
        static int totColaboradores;


        #endregion

        #region Constructors

        static Colaboradores()
        {
            colaboradores = new Colaborador[MAXCOLABORADORES];
            totColaboradores = 0;
        }

        #endregion

        #region Functions

        public static bool VerificaExisteColaborador(Colaborador c)
        {
            for (int i = 0; i < totColaboradores; i++)
            {
                if (c.Equals(colaboradores[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool AdicionaColaborador(Colaborador c)
        {
            if (totColaboradores >= MAXCOLABORADORES) return false;

            if (VerificaExisteColaborador(c)) return false;
            
            colaboradores[totColaboradores] = c;
            totColaboradores++;
            return true;
        }


        #endregion

        #region Indexadores

        public Colaborador this[int i]
        {
            get { return colaboradores[i]; }
            set { colaboradores[i] = value; }
        }

        #endregion
    }
}
