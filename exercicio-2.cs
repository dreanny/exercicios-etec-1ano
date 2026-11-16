using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 3250; i < 4001; i++)
            {
                if (i % 2 == 0)
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}
