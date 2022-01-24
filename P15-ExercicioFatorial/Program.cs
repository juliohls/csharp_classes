using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_ExercicioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 15 - Execício de Fatorial");

            int fatorial = 1;
            for (int numero = 1; numero <= 10; numero++)
            {
                for (int numero2 = 1; numero2 <= numero; numero2++)
                {
                    if (numero2 != numero)
                        Console.Write(numero2 + " x ");
                    else
                        Console.Write(numero2);
                }
                fatorial *= numero;
                Console.Write("! = " + fatorial);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
