using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variáveis ponto flutuante");

            double salario = 1200.70;
            Console.WriteLine("Salário: " + salario);

            double idade = 15.0 / 2; //Retorna double
            Console.WriteLine("Idade: " + idade);
            idade = 15 / 2; //Retorna inteiro
            Console.WriteLine("Idade: " + idade);

            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);

            Console.WriteLine("A execução acabou. Tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
