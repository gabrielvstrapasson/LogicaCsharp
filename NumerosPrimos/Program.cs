
namespace NumerosPrimo
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
            Console.WriteLine("Informe um número para saber se ele é primo ou não: ");
            int number = int.Parse(Console.ReadLine());
            Verificar(number);

        }

        static void Verificar(int number)
        {
            int contadorDivisao = 0;
            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {
                    contadorDivisao++;
                }
            }

            if (contadorDivisao == 2)
            {
                Console.WriteLine($"{number} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{number} não é um número primo.");
            }
        }
    }
}