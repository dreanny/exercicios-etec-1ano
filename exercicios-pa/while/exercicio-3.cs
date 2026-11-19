using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imprimir_x
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número A");
            double a = Convert.ToDouble(Console.ReadLine());
        while (a>0)
            {
            Console.WriteLine("Digite um número B");
            double b = Convert.ToDouble(Console.ReadLine());

            double x = a + b;
            Console.WriteLine(a + "+" + b + "=" + x);

            Console.WriteLine("Digite outro número A");
            a = Convert.ToDouble(Console.ReadLine());
            }
            
        }
    }
}
