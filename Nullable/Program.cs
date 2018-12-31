using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // erro: variáveis primitivas precisam ter valor
            // double x = null; 

            // declara um double que pode receber um valor nulo
            Nullable<double> x = null;

            // forma simplificada
            double? y = null;
            y = 10.0;

            // métodos
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value); // lança exceção se x não possuir valor
            else
                Console.WriteLine("X é null");

            if (y.HasValue)
                Console.WriteLine(y.Value); // lança exceção se x não possuir valor
            else
                Console.WriteLine("Y é null");

            // operador de coalescência nula
            double? a = null;
            double? b = 10.0;

            double c = a ?? 0.0; // adiciona o valor 0.0, se 'a' for null
            double d = b ?? 0.0; // adiciona o valor 0.0, se 'b' for null

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
