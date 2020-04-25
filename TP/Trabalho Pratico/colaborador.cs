using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Pratico
{
    class Colaborador
    {
        #region MemberVariables
        string nome;
        int codigo;
        bool ativo;

        #endregion

        #region Constructors

        public Colaborador(string n, int numCol)
        {
            nome = n;
            codigo = numCol + 1;
            ativo = true;
        }


        #endregion

        #region Properties

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public bool Ativo
        { 
            get { return ativo; }
            set { ativo = value; }
        }

        #endregion

        #region Overrides

        public override bool Equals(object obj)
        {
            Colaborador aux = (Colaborador)obj;
            return (aux.codigo == this.codigo);
        }

        public override string ToString()
        {
            return string.Format("Nome: {0} \n Codigo: {1} \n Ativo: {2}\n", Nome, Codigo, Ativo);
        }

        #endregion

        #region Operators

        public static bool operator == (Colaborador c1, Colaborador c2)
        {
            return (c1.Equals(c2));
        }

        public static bool operator != (Colaborador c1, Colaborador c2)
        {
            return (!c1.Equals(c2));
        }
        #endregion

       
    }
}
