using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Pratico
{
    class Auditoria
    {
        #region MemberVariables 
    
        public int codigo;
        public DateTime data;
        public Colaborador colaborador;
        public float duracao;
        public int numeroVulnerabilidades;

        #endregion

        #region Constructors

        public Auditoria(Colaborador colab ,DateTime dat, float dur, int numAuditorias)
        {
            colaborador = colab;
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
            return string.Format("Codigo: {0} \nData: {1} \n{2}Duracao: {3}\n", codigo, data, colaborador, duracao);
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
