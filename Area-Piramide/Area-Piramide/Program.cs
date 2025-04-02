
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

namespace Area_Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o valor da aresta base em cm: ");
            decimal arestaBase = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura em cm: ");
            decimal alturaPiramide = decimal.Parse(Console.ReadLine());


            decimal areaBase = (arestaBase * arestaBase * (decimal)Math.Sqrt(3)) / 4;

            decimal alturaLateral = (decimal)Math.Sqrt((double)(alturaPiramide * alturaPiramide) + (double)((arestaBase / 2) * (arestaBase / 2)));

            decimal areaLateral = (arestaBase * alturaLateral) / 2 * 4;

            decimal areaTotal = areaBase + areaLateral;

            Console.WriteLine($"O valor da área da base: {areaBase:F4} cm²");
            Console.WriteLine($"O valor da área lateral total (4 faces) : {areaLateral:F4} cm²");
            Console.WriteLine($"O valor da área total da pirâmide: {areaTotal:F4} cm²");
        
        }
    }
}