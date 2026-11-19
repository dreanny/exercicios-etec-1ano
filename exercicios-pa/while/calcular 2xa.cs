using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_2xa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50;

            while (a <= 100)
            {
               
                int resultado = 2*a;
                Console.WriteLine(2+ "x" +a+ "="+ resultado);
                a = a + 2;
            }
        }
    }
}
