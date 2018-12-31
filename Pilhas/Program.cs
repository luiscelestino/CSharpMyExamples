using System;
using System.Collections.Generic;

namespace Pilhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();

            // adiciona itens à pilha
            pilha.Push(10);
            pilha.Push(20);
            pilha.Push(30);
            pilha.Push(40);
            pilha.Push(50);

            // conta número de elementos da pilha
            Console.WriteLine($"Minha pilha possui {pilha.Count} elmentos.");

            // exibe último elemento da pilha sem remover
            Console.WriteLine( pilha.Peek() );
            Console.WriteLine($"Minha pilha possui {pilha.Count} elmentos.");

            // exibe último elemento da pilha removendo
            Console.WriteLine( pilha.Pop() );
            Console.WriteLine($"Minha pilha possui {pilha.Count} elmentos.");

            // remove todos elementos da pilha
            pilha.Clear();
            Console.WriteLine($"Minha pilha possui {pilha.Count} elmentos.");

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
