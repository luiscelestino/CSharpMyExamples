using System;
using System.Collections.Generic;

namespace Filas
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            // adiciona itens à fila
            fila.Enqueue("Andre");
            fila.Enqueue("Bento");
            fila.Enqueue("Chico");
            fila.Enqueue("Daniel");
            fila.Enqueue("Luis");

            // imprime número de elementos na fila
            Console.WriteLine($"A fila possui {fila.Count} elementos.");

            // exibe o primeiro elemento da lista sem remover
            Console.WriteLine($"O elemento {fila.Peek()} é o primeiro elemento da lista.");
            Console.WriteLine($"A fila possui {fila.Count} elementos.");

            // remove primeiro elemento da lista
            Console.WriteLine($"O elemento {fila.Dequeue()} foi retirado.");
            Console.WriteLine($"A fila possui {fila.Count} elementos.");

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
