using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nums_consecutivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = Convert.ToInt32(Console.ReadLine());
            while (numero < (36))
            {
                Console.WriteLine("Número digitado: " + numero); 
                Console.WriteLine("Digite o próximo número");
            numero = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
