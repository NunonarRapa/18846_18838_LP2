using System;

namespace Trabalho_Pratico
{
    class Program
    {
        static void Main(string[] args)
        {
            Auditorias audisss = new Auditorias();

            Colaboradores colabs = new Colaboradores();

            Colaborador col = new Colaborador("Rapa", 0);

            Auditoria audi = new Auditoria(col, DateTime.Now, 10, 0);

            Auditorias.AdicionaAuditoria(audi);

            Console.WriteLine("{0}", audisss[0]);

            Console.WriteLine("{0}", audisss[0].colaborador);


            /*
            EquipamentosInf equipamentosInf = new EquipamentosInf();

            Vulnerabilidade vul;
            
            EquipamentoInf eq, eq1;

            eq = new EquipamentoInf("dafadsf", "fadfs", "2-dse", DateTime.Now, 0);

            eq1 = new EquipamentoInf("router", "adhf", "2-dsdsadfe", DateTime.Now, 1);

            EquipamentosInf.AdicionaEquipamento(eq);

            Console.WriteLine("{0}", eq.ToString());

            Console.WriteLine("{0}", equipamentosInf[0].ToString());

            equipamentosInf[1] = eq1;

            Console.WriteLine("{0}", equipamentosInf[1].ToString());

            vul = new Vulnerabilidade("vshha", Vulnerabilidade.Impacto.baixo, 0);

            equipamentosInf[1].Vulnerabilidades[0] = vul;

            Console.WriteLine("{0}", vul.ToString());

            Console.WriteLine("{0}", equipamentosInf[1].Vulnerabilidades[0].ToString());*/

            Console.ReadKey();
        }
    }
}
