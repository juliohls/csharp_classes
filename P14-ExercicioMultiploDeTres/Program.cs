using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_ExercicioMultiploDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 14 - Exercício multiplos de 3");

            //Fazendo com módulo (%)
            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine("O número " + numero + " é multiplo de 3!");
                }
            }

            //Fazendo com multiplicação
            for (int numero2 = 1; numero2 <= 100; numero2++)
            {
                int multiplo = numero2 * 3;
                if (multiplo < 100)
                {
                    Console.WriteLine("O número " + multiplo + " é multiplo de 3!");
                }
            }

            //Jeito mais simples de fazer
            for (int i = 3; i < 100; i+=3)
            {
                Console.WriteLine("O número " + i + " é multiplo de 3!");
            }
            Console.ReadLine();
        }
    }
}
