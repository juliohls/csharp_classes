using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4!");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; //Fazendo o casting(int) forçamos double em int, mas perdemos a casa decimal de precisão
            Console.WriteLine(salarioEmInteiro);

            int idade; // Cabe de -2³¹ até 2³¹ um pouco mais de 2 bilhões  variável de 32 bits
            idade = 1300000000;
            Console.WriteLine(idade);

            long idadeLong; // Cabe até 64bits
            idadeLong = 1300000000000;
            Console.WriteLine(idadeLong);

            short quatidadeProdutos; // cabe até 16 bits  um pouco mais de 16 mil
            quatidadeProdutos = 150;
            Console.WriteLine(quatidadeProdutos);

            float altura = 1.80f; // Não traz precisão grande de casas decimais, double mais usado
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
