using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13");

            // Piramide de '*'
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }


            // Uma forma diferente de fazer
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Tabuada até o 10
            for (int contador = 1; contador <= 10; contador++)
            {
                for (int contador2 = 0; contador2 <= 10; contador2++)
                {
                    Console.WriteLine(contador + " x " + contador2 + " = " + contador * contador2);
                }
            }

            Console.ReadLine();
        }
    }
}
