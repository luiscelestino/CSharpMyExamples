using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarando e inicializando uma tupla
            (string pais, int populacao, string capital, double rpc) tupla = ("Brasil", 200, "Brasília", 1268.3);

            Console.WriteLine($"O {tupla.pais}, cuja capital é {tupla.capital}, " +
                $"possui renda per capita de R$ {tupla.rpc} e a população de {tupla.populacao} milhões.");

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
