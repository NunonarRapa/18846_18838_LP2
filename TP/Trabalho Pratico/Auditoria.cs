using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Pratico
{
    class Auditoria
    {
        #region MemberVariables 
     
        int codigo;
        DateTime data;
        Colaborador colaborador;
        float duracao;
        int numeroVulnerabilidades;

        #endregion

        #region Constructors

        public Auditoria(DateTime dat, float dur, int numAuditorias)
        {
            data = dat;
            duracao = dur;
            codigo = numAuditorias + 1;
            numeroVulnerabilidades = 0;

        }


        #endregion

        #region Properties 

        public int Codigo
        {
            get { return codigo; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public float Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }

        public int NumeroVulnerabilidades
        {
            get { return numeroVulnerabilidades; }
        }

        public Colaborador Colaborador
        {
            get { return colaborador; }
            set { colaborador = value; }
        }
        #endregion

        #region Overrides

        public override bool Equals(object obj)
        {
            Auditoria aux = (Auditoria)obj;
            return (aux.codigo == this.codigo);
        }

        public override string ToString()
        {
            return string.Format("Codigo: {0} \n Data: {1} \n Colaborador: {2} \n Duracao: {3} \n", Codigo, Data, Colaborador, Duracao);
        }


        #endregion

        #region Operators

        public static bool operator == (Auditoria a1, Auditoria a2)
        {
            return (a1.Equals(a2));
        }

        public static bool operator != (Auditoria a1, Auditoria a2)
        {
            return (!a1.Equals(a2));
        }
        #endregion
    }
}
