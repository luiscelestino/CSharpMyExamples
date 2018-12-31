using System;

namespace Struct
{
    /* FONTES:
     *  - https://pt.stackoverflow.com/questions/16181/qual-a-diferença-entre-struct-e-class     *  - https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/     */    public struct Cliente
    {
        public int matricula;
        public string nome;
        public string email;

        public void digaOi()
        {
            Console.WriteLine($"Oi {this.nome}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.matricula = 123;
            cliente.nome = "Luis";
            cliente.email = "souza.luis@gmail.com";

            cliente.digaOi();

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
