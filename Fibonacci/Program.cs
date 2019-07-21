using System;

namespace _Fibonacci
{
    class Program
    {
        /// <summary>
        /// Fibonacci Iterativo
        /// </summary>
        /// <param name="n">Numero de fibonacci</param>
        /// <returns></returns>
        static int FibonacciIterativo (int n)
        {
            int a = 1;
            int b = 0;

            for (int i = 0; i < n; i++)
            {
                int t = a + b;
                a = b;
                b = t;

                Console.Write(t + " ");
            }

            return b;
        }

        /// <summary>
        /// Metodo Fibonacci Recursivo
        /// </summary>
        /// <param name="n">Valor do numero de vezes que sera mutiplicado vezes ele mesmo menos um</param>
        /// <returns></returns>
        static int FibonacciRecursivo(int n)
        {
            if (n == 1 || n == 2)
            {
                return  1;
            }
            else
            {
                return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 1)
            {
                Console.WriteLine("\n-Fibonacci Iterativo-");
                int valor = FibonacciIterativo(numero);

                Console.WriteLine("\n\n-Fibonacci Recursivo-");
                valor = FibonacciRecursivo(numero);
                Console.WriteLine(valor);
            }
            else
            {
                Console.WriteLine("Precisa que o numero seja maior que 1!");
            }

            Console.ReadKey();
        }
    }
}
