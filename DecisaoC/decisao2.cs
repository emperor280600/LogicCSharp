using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DecisaoC
{
    internal class decisao2
    {
        static void Main(string[] args)
        {
               Console.WriteLine("Digite a nota do aluno");
               double nota = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine("Digite a procentagem de presença do aluno");
               int frequencia = Convert.ToInt32(Console.ReadLine());

               if (nota >= 6 && frequencia >= 85)
            {
               Console.WriteLine("aluno aprovado");
            }
               else if (nota >= 4.5 && frequencia >= 65)
            {
               Console.WriteLine("aluno em recuperação");
            }
               else
            {
               Console.WriteLine("aluno reprovado");
            }
        }
    }
}
