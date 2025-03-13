using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.Write("Seja Bem-Vindo a minha calculadora simples, o que deseja fazer?\n");
            Console.WriteLine("1 - Soma ");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("Selecione uma das opções: ");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Soma();
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Divisao();
                    break;

                case 4:
                    Multiplicacao();
                    break;

                case 5:
                    Console.Clear();
                    break;

                default:
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Informe o primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            float resultado = firstValue + secondValue;

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Informe o primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            float resultado = firstValue - secondValue;

            Console.WriteLine($"O resultado da subtração é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.Write("Informe o primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            float resultado = firstValue / secondValue;

            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Informe o primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            float resultado = firstValue * secondValue;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

            Console.ReadKey();
            Menu();
        }
    }
}


