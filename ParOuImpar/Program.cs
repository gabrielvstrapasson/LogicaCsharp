
namespace ParOuImpar 
{
    class Program
    {
        static void Main(string[] args)
        {
            verifyNumber();
        }

        static void verifyNumber()
        {
            Console.Clear();
            Console.Write("Informe o número que deseja saber se é par ou impar: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
                Console.WriteLine("Impar");
        }


    }
}