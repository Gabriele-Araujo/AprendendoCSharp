﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto   10 - Calcula Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while(contadorMes <= 12)
            {
                valorInvestido += (valorInvestido * 0.0036);
                Console.WriteLine("Após " + contadorMes +  " meses, você terá R$ " + valorInvestido);
                contadorMes++;
            }

            //0.36% = 0.0036
            
            Console.ReadLine();

        }
    }
}
