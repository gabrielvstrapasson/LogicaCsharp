namespace Intercalando_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            List<int> intercalandoLista = new List<int>();

            int numerosInteiros = 80;

            Console.Clear();

            PrimeiraLista(list1, numerosInteiros);
            SegundaLista(list2, numerosInteiros);

            IntercalandoListas(intercalandoLista, list1, list2, numerosInteiros);
        }
        static void PrimeiraLista(List<int> list1, int numerosInteiros)
        {
            Console.WriteLine($"Digite {numerosInteiros} números inteiros para a 1° lista. ");
            while (list1.Count < numerosInteiros)
            {
                Console.WriteLine($"Informe o {list1.Count + 1}° numero: ");
                int numero = int.Parse(Console.ReadLine());

                if (!list1.Contains(numero))
                {
                    list1.Add(numero);
                }
                else
                {
                    Console.WriteLine("Esse número já foi informado, por tanto é repetido! Tente novamente.");
                }
            }
        }

        static void SegundaLista(List<int> list2, int numerosInteiros)
        {
            Console.WriteLine($"Digite {numerosInteiros} números inteiros para a 2° lista. ");
            while (list2.Count < numerosInteiros)
            {
                Console.WriteLine($"Informe o {list2.Count + 1}° numero: ");
                int numero = int.Parse(Console.ReadLine());

                if (!list2.Contains(numero))
                {
                    list2.Add(numero);
                }
                else
                {
                    Console.WriteLine("Esse número já foi informado, por tanto é repetido! Tente novamente.");
                }
            }
        }

        static void IntercalandoListas(List<int> intercalandoLista, List<int> list1, List<int> list2, int numerosInteiros)
        {
            for (int i = 0; i < numerosInteiros; i++)
            {
                intercalandoLista.Add(list1[i]);
                intercalandoLista.Add(list2[i]);
            }

            Console.WriteLine("\nSegue lista intercalada");
            foreach (int numero in intercalandoLista)
            {
                Console.Write(numero + " ");
            }


        }
    }
}