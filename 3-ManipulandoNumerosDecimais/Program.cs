﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ManipulandoNumerosDecimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2.0
                ;Console.WriteLine($"15/ 2.0 = {idade}");

            idade = 5 / 3
                ;Console.WriteLine($"5/ 3 = {idade}");

            idade = 5.0 / 3
                ;Console.WriteLine($"5.0/ 3 = {idade}");




            Console.WriteLine("Aperte Enter Para Finalizando execução");

            Console.ReadLine();
        }
    }
}
