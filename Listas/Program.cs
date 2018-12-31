using System;
using System.Collections;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // aceita qualquer tipo de dado
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Luis");
            arrayList.Add(39);
            arrayList.Add(new object());

            // aceita apenas um tipo de dado
            List<string> diasSemana = new List<string>();

            diasSemana.Add("Dom");
            diasSemana.Add("Seg");
            diasSemana.Add("Ter");
            diasSemana.Add("Qua");
            diasSemana.Add("Qui");
            diasSemana.Add("Sex");
            diasSemana.Add("Sab");

            foreach (string dia in diasSemana)
            {
                Console.WriteLine(dia);
            }

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
