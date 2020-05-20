using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Pratico
{
    class EquipamentoInf
    {
        #region MemberVariables 
        const int MAXVULEQUIPAMENTO = 20;
        static List<Vulnerabilidade> vulnerabilidades;
        int codigo;
        string tipo;
        string marca;
        string modelo;
        DateTime dataAquisicao;
        int numeroVulnerabilidades;
        #endregion

        #region Constructors

        public EquipamentoInf(string tp, string marc, string mod, DateTime dat, int numEquip)
        {
            codigo = numEquip + 1;
            tipo = tp;
            marca = marc;
            modelo = mod;
            dataAquisicao = dat;
            numeroVulnerabilidades = 0;
            vulnerabilidades = new List<Vulnerabilidade>();
        }


        #endregion

        #region Properties 

        public int Codigo
        {
            get { return codigo; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public DateTime DataAquisicao
        {
            get { return dataAquisicao; }
            set { dataAquisicao = value; }
        }

        public int NumeroVulnerabilidades
        {
            get { return numeroVulnerabilidades; }
        }

        #endregion
       
        #region Overrides

        public override bool Equals(object obj)
        {
            EquipamentoInf aux = (EquipamentoInf)obj;
            return (aux.codigo == this.codigo);
        }

        public override string ToString()
        {
            return string.Format("Codigo: {0} \nTipo: {1} \nMarca: {2} \nModelo: {3} \nData: {4}\n", codigo, tipo, marca, modelo, dataAquisicao);
        }

        #endregion

        #region Operators

        public static bool operator == (EquipamentoInf eq1, EquipamentoInf eq2)
        {
            return (eq1.Equals(eq2));
        }

        public static bool operator != (EquipamentoInf eq1, EquipamentoInf eq2)
        {
            return (!eq1.Equals(eq2));
        }
        #endregion
    }
}
