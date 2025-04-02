namespace Bubble_Sort
{
    internal class Program
    {
        static int[] valores;
        static void Main(string[] args)
        {
            string repetir;

            Console.Clear();
            do
            {
                Console.Clear();
                Console.Write("Digite o seu nome: ");
                string nome = Console.ReadLine();
                int tamanhoDoVetor = nome.Length;

                valores = new int[tamanhoDoVetor];

                Console.WriteLine($"Informe {tamanhoDoVetor} números inteiros, por favor.");

                int posicao = 0;

                foreach (char letrasNome in nome)
                {
                    Console.WriteLine("Informe um número: ");
                    valores[posicao] = int.Parse(Console.ReadLine());
                    posicao++;
                }

                Console.WriteLine("\nLISTA SEM ORDENAÇÃO");
                Imprimir();

                Console.WriteLine("\nLISTA ORDENADA (CRESCENTE)");
                OrdenarListaCrescente(valores);
                Imprimir();
                VerificarExistenciaDeNumeroRepetido(valores);

                Console.WriteLine("\nLISTA ORDENADA (DECRESCENTE)");
                OrdenarListaDecrescente(valores);
                Imprimir();
                VerificarExistenciaDeNumeroRepetido(valores);

                Console.WriteLine("Deseja tentar novamente? (SIM / NAO) ");
                repetir = Console.ReadLine().ToLower();

            } while (repetir == "sim");
        }

        private static void OrdenarListaCrescente(int[] numeros)
        {
            bool VerificadorFlag = false;

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i+1; j < numeros.Length; j++)
                {

                    if (numeros[i] > numeros[j])
                    {

                        int aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                        VerificadorFlag |= true;
                    }
                }
                if (!VerificadorFlag)
                {
                    Console.WriteLine("A lista estava ordenada.");
                    break;
                }
            }
        }
        
        private static void OrdenarListaDecrescente(int[] numeros)
        {
            bool VerificadorFlag = false;
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] < numeros[j])
                    {

                        int aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                        VerificadorFlag |= true;
                    }
                }
                if (!VerificadorFlag)
                {
                    Console.WriteLine("A lista estava ordenada.");
                    break;
                }
            }
        }

        private static void VerificarExistenciaDeNumeroRepetido(int[] numeros)
        {
            bool ExisteRepetido = false;

            for(int i = 0; i < numeros.Length; i++)
            {
                int contarNumeroRepetido = 1;
                bool NumeroJaFoiVerificado = false;

                for (int verificar = 0; verificar < i; verificar++)
                {
                    if (numeros[i] == numeros[verificar])
                    {
                        NumeroJaFoiVerificado = true;
                        break;
                    }
                }

                if (!NumeroJaFoiVerificado)
                {
                    for (int j = i + 1; j < numeros.Length; j++)
                    {
                        if (numeros[i] == numeros[j])
                        {
                            contarNumeroRepetido++;
                        }
                    }
                    if (contarNumeroRepetido > 1)
                    {
                        Console.WriteLine($"O {numeros[i]} está repetido {contarNumeroRepetido} vezes.");
                        ExisteRepetido = true;
                    }
                }
            }
            if (!ExisteRepetido)
            {
                Console.WriteLine("Não há números informados repetidos.");
            }
        }

        private static void Imprimir()
        {
            for( int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine($"Posição: {i}\tValor: {valores[i]}");
            }

        }
    }
}


