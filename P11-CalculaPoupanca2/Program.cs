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
            Console.WriteLine("Executando projeto 11 - Calcula Poupança 2");

            double valorInvestido = 1000;

            for(int contadorMes = 1;  contadorMes <= 12; contadorMes++)
            {
                //valorInvestido += (valorInvestido * 0.0036);
                //valorInvestido = valorInvestido * 1.0036;
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
            }

            //0.36% = 0.0036

            Console.ReadLine();

        }
    }
}
