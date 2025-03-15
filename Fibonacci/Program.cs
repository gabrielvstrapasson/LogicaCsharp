
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicaFibonacci();
        }

        static void LogicaFibonacci()
        {
            Console.Clear();
            Console.Write("Informe a quantidade de números que deseja exibir da sequência Fibonacci: ");
            short numberValue = short.Parse(Console.ReadLine());
            int ultimoNumero = 0;
            int penultimoNumero = 1;
            int fibonacci = 0;
            for (int i = 0; i < numberValue; i++)
            {


                Console.Write($"{fibonacci}, ");
                ultimoNumero = fibonacci;
                fibonacci = penultimoNumero + ultimoNumero;
                penultimoNumero = ultimoNumero;

            }
        }


    }
}