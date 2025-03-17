
namespace Fatorial
{
    class Program
    {
        static void Main (string[] args)
        { 
            Principal();
        }

        static void Principal()
        {
            Console.Clear();
            Console.Write("Informe o valor que deseja calcular o fatorial: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write($"O fatorial do {number} é  ");
            Calculo(number);
        }

        static void Calculo(int number)
        {
            int fatorial = 1;
            if (number > 0)
            {
                for (; number > 1; number--)
                {
                    fatorial *= number;
                }
                Console.Write(fatorial);
            }
            else if (number == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("Inválido.");
            }

            

        }

    }
}