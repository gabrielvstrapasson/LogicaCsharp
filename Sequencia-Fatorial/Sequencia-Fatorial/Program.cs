namespace Sequencia_Fatorial
{
    class Program
    {

        static void Main (string[] args)
        {
            Console.Clear();
            int sequencia = 224;

            decimal somaFAT = 0;

            for (int i = 2; i <= 10; i++)
            {
                decimal fatorial = CalcularFatorial(i);
                decimal termo = sequencia / fatorial;
                somaFAT += termo;

                Console.WriteLine($"FAT = {sequencia} / {i}! = {termo:F4}");

                sequencia += 4;
            }

            Console.WriteLine($"O somatório do FAT é: {somaFAT:F4}");
        }
        static decimal CalcularFatorial(int numero)
        {
            decimal resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;

        }

    }
}