﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                if (contadorMes > 1)
                {
                    valorInvestido *= 1.0036;
                    Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
                }
                else
                {
                    valorInvestido *= 1.0036;
                    Console.WriteLine("Após " + contadorMes + " mês, você terá R$" + valorInvestido);
                }
            }


            Console.ReadLine();
        }
    }
}
