
using System.Security.Principal;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal();
        }

        static void Principal()
        {
            Console.Clear();
            Console.Write("Digite o número que deseja saber a tabuada: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"A tabuada do {number}: ");
            CalculoTabuada(number);
        }
        
        static void CalculoTabuada(int number)
        {
            for (short i = 0; i < 10; i++)
            {
                int resultado = number * i;
                Console.WriteLine($"{number} x {i} = {resultado}");
            }
        }
    }
}