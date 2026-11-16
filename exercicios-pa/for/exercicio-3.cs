using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício___3
{
    internal class Program
    {
        static void Main(string[] args)
        {
       for(int funcionarios  = 1; funcionarios < 101; funcionarios++)
            {
                Console.WriteLine("Funcionário " + funcionarios + " - Qual o seu salário?");
                double salario = Convert.ToDouble(Console.ReadLine());

                double reajuste;
                if (salario > 25000)
                {
                    reajuste = salario * 1.20;
                    Console.WriteLine("O salário com reajuste é de " + reajuste);
                }
                else if (salario >= 10000 && salario <= 25000)
                {
                    reajuste = salario * 1.30;
                    Console.WriteLine("O salário com reajuste é de " + reajuste);

                }
                else
                {
                    reajuste = salario * 1.55;
                    Console.WriteLine("O salário com reajuste é de " + reajuste);

                }
            }

        }
    }
}
