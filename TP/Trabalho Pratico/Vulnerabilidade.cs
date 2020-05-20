using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Pratico
{
    class Vulnerabilidade
    {
        #region MemberVariables
        int codigo;
        string descricao;
        bool ativo;
        Impacto nivelImpacto;
        #endregion

        #region Constructors

        public Vulnerabilidade( string desc, Impacto nImp, int numVul)
        {
            codigo = numVul + 1;
            descricao = desc;
            nivelImpacto = nImp;
            ativo = true;
        }
        #endregion

        #region Properties

        public int Codigo
        {
            get { return codigo; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public Impacto NivelImpacto
        {
            get { return nivelImpacto; }
            set { nivelImpacto = value; }
        }
        #endregion

        #region Enums
        public enum Impacto
        {
            baixo = 1, 
            moderado = 2,
            elevado = 3
        }
        #endregion

        #region Overrides

        public override bool Equals(object obj)
        {
            Vulnerabilidade aux = (Vulnerabilidade)obj;
            return (aux.codigo == this.codigo);
        }

        public override string ToString()
        {
            return string.Format("Codigo: {0} \nDescricao: {1} \nEstado: {2} \nNivel de Impacto: {3}\n", codigo, descricao, ativo, nivelImpacto);
        }

        #endregion

        #region Operators

        public static bool operator == (Vulnerabilidade v1, Vulnerabilidade v2)
        {
            return (v1.Equals(v2));
        }

        public static bool operator != (Vulnerabilidade v1, Vulnerabilidade v2)
        {
            return (!v1.Equals(v2));
        }

        #endregion
    }
}
