using System;

namespace Enum
{
    // O enum é uma forma de agrupar constantes dentro de um programa
    public enum TipoCliente
    {
        PessoaFisica, PessoaJuridica, OrgaoPublico, ONG
    }

    public enum StatusPedido
    {
        AguardandoPagamento = 1,
        Aprovado = 2,
        Enviado = 3,
        Recebido = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TipoCliente.PessoaFisica);
            Console.WriteLine(TipoCliente.PessoaJuridica);
            Console.WriteLine(TipoCliente.OrgaoPublico);
            Console.WriteLine(TipoCliente.ONG);

            Console.WriteLine();
            Console.WriteLine(StatusPedido.AguardandoPagamento);

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
