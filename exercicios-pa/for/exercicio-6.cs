using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double dominio = 0; dominio < 21; dominio++)
            { double imagem = 3 * dominio * dominio + (dominio / 2.0) - 1.0 / 5.0;
                Console.WriteLine("Na função Y = 3.X.X + 1.X/2 – 1/5, o domínio é " + dominio + " e a imagem é " + imagem);
            }
            
        }
    }
}
