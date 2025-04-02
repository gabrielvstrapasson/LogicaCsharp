namespace Pesquisa_Linear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 10, 15, 33, 14, 9 };

            string continuarTentando;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite um valor: ");
                int valorUsuario = int.Parse(Console.ReadLine());
                bool valorEncontrado = false;

                for (int i = 0; i < vetor.Length; i++)
                {
                    if (valorUsuario == vetor[i])
                    {
                        Pesquisar(valorUsuario, i);
                        valorEncontrado = true;
                        break;
                    }
                }

                if (!valorEncontrado)
                {
                    Console.WriteLine($"O valor do {valorUsuario} não foi encontrado no vetor.");
                    Console.WriteLine("Deseja tentar novamente? (SIM / NÃO ) ");
                    continuarTentando = Console.ReadLine().ToLower();
                }
                else
                {
                    continuarTentando = "nao";
                }


            } while  (continuarTentando == "sim") ;

            static void Pesquisar(int valorUsuario, int posicao)
            {

                Console.WriteLine($"Foi encontrado o {valorUsuario} no vetor na posição {posicao}.");
            }
        }
    }
}