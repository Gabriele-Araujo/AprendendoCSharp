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
            Console.WriteLine("Executando projeto 4 - Conversoes e outros tipos numericos");

            double salario = 1200.50;
            int salarioEmInteiro = (int)salario; //Casting 

            long idade = 13000000000; //Números maiores 64bits
            Console.WriteLine(idade);
            short quantidadeProdutos = 150; //Números menores 16bits
            Console.WriteLine(quantidadeProdutos);
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
