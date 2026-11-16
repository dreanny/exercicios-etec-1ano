using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int alunos = 1; alunos < 81; alunos++)
            {
                Console.WriteLine("Aluno " + alunos + " - Qual a nota da primeira prova?");
                double prova1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Qual a nota da segunda prova?");
                double prova2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Qual a nota do trabalho?");
                double trabalho = Convert.ToDouble(Console.ReadLine());

                double media = (prova1 + prova2 + trabalho) / 3;
                Console.WriteLine("Média final = " + media);

            }

        }
    }
}
