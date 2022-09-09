using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres e Textos");

            char primeiraLetraNome = 'a'; //1 caracter
            Console.WriteLine(primeiraLetraNome);

            primeiraLetraNome = (char)65;
            Console.WriteLine(primeiraLetraNome);
            primeiraLetraNome = (char)(primeiraLetraNome + 1);
            Console.WriteLine(primeiraLetraNome);


            string titulo = "Alura Cursos de Tecnologia " + 2020;
            Console.WriteLine(titulo);
            string cursosProgramacao = @" - .NET
                - Java
                - JavaScript";
            Console.WriteLine(cursosProgramacao);

            string saudacao = "Olá, meu nome é ";
            string nome = "Rômulo ";
            string continuacao = "e minha idade é ";
            int idade = 100;
            Console.WriteLine(saudacao + nome + continuacao + idade);

            Console.ReadLine();
        }
    }
}
