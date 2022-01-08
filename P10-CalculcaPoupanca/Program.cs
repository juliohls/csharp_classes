using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculcaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupanca");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                if (contadorMes > 1)
                {
                    // 0.36% = 0.0036
                    valorInvestido = valorInvestido + valorInvestido * 0.0036;
                    Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
                    contadorMes++;
                }
                else
                {
                    valorInvestido = valorInvestido + valorInvestido * 0.0036;
                    Console.WriteLine("Após " + contadorMes + " mês, você terá R$" + valorInvestido);
                    contadorMes++;
                }
                
            }
            



            Console.ReadLine();
        }
    }
}
