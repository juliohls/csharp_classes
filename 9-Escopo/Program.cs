using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                //string mensagemAdicional = "João esta acompanhado!";    Só existe nesse Escopo dentro do IF
                mensagemAdicional = "João esta acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                //string mensagemAdicional = "João não esta acompanhado!";
                mensagemAdicional = "João não esta acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
