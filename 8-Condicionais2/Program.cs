using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas > 1; // true ou false

            if (idadeJoao >= 18 || acompanhado==true)
            {
                Console.WriteLine("João pode entrar.");
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }

            // || ou
            // && e
            Console.ReadLine();
        }
    }
}
