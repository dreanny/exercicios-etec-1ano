using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int prontuario = 1; prontuario < 11; prontuario++)
            {
                Console.WriteLine("Funcionário " + prontuario + " - Quantos anos de trabalho?");
                int anos = (Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Quantas faltas?");
                int faltas = (Convert.ToInt32(Console.ReadLine()));
                int pontuacao;

                {
                    if (anos >= 10 && faltas <= 5)
                    {
                        pontuacao = 10 - faltas;
                        Console.WriteLine("Pontuação = " + pontuacao);
                    }
                    else
                    {
                        pontuacao = 0;

                        Console.WriteLine("Pontuação = " + pontuacao);

                    }
                }

            }
        }
    }
}
