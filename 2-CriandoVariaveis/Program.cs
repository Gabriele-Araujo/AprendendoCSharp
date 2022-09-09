using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variáveis");

            int idade = 32;
            Console.Write(idade); //Não contém quebra de linha
            Console.WriteLine(idade); //Contém quebra de linha
            Console.WriteLine("Sua idade é: " + idade + "anos!"); //Contém quebra de linha

            Console.WriteLine("A execução acabou. Tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
