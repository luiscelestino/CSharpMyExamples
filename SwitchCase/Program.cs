using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o saldo da conta: ");
            double saldo = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Digite o valor da compra: ");
            double valorCompra = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Entre com o tipo de pagamento (C,D,M): ");
            char tipoPagamento = Convert.ToChar( Console.ReadLine() );

            (double saldo, double valor, char tipo) pagamento = (saldo, valorCompra, tipoPagamento);

            // switch-case
            switch (pagamento.tipo)
            {
                case 'D':
                    Console.WriteLine("Compra com cartão de débito!");
                    break;
                case 'C':
                    Console.WriteLine("Compra com cartão de crédito!");
                    break;
                default:
                    Console.WriteLine("Compra com dinheiro!");
                    break;
            }

            // switch-case with pattern matching
            switch (pagamento.tipo)
            {
                case 'D' when pagamento.saldo < pagamento.valor:
                    Console.WriteLine("Compra com cartão de débito não aprovada!");
                    break;
                case 'C' when pagamento.saldo < pagamento.valor:
                    Console.WriteLine("Compra com cartão de crédito não aprovada!");
                    break;
                default:
                    Console.WriteLine("Compra aprovada!");
                    break;
            }

            // aguarda pressionar tecla para sair
            Console.ReadKey();

        }
    }
}
