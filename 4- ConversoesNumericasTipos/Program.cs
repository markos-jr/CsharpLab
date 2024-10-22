using System;

namespace ConversoesNumericasTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Informando o início da execução do programa
            Console.WriteLine("Executando o projeto de conversões numéricas");

            // Definindo uma variável do tipo double (ponto flutuante com 64 bits)
            double salario = 1200.50;

            // Exibindo o valor do salário original em formato double
            Console.WriteLine($"Salário original (double): {salario}");

            // Realizando um "casting" explícito de double para int
            int salarioEmInteiro = (int)salario;

            // Exibindo o valor convertido de double para int (parte inteira)
            Console.WriteLine($"Conversão de salário para inteiro (int): {salarioEmInteiro}");

            // Definindo uma variável long para idade do universo
            long idadeUniverso = 13000000000;

            // Exibindo a idade do universo
            Console.WriteLine($"Idade estimada do universo (long): {idadeUniverso}");

            // Definindo uma variável short para quantidade de produtos
            short quantidadeProdutos = 15000;

            // Exibindo a quantidade de produtos
            Console.WriteLine($"Quantidade de produtos (short): {quantidadeProdutos}");

            // Definindo a altura com o tipo float
            float altura = 1.80f;

            // Exibindo a altura em formato float
            Console.WriteLine($"Altura (float): {altura}");

            // Mensagem final para aguardar o usuário pressionar Enter antes de encerrar o programa
            Console.WriteLine("Aperte Enter para finalizar");
            Console.ReadLine();
        }
    }
}
