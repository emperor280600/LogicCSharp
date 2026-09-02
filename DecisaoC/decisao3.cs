using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisaoC
{
    internal class decisao3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do aluo");
            double nota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a frequencia do aluno");
                int frequencia = Convert.ToInt32(Console.ReadLine());

            if (nota >= 7 || frequencia >= 85)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (nota >= 4.5 || frequencia >= 65)
            {
                Console.WriteLine("Aluno em recuperação");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }
    }
}
