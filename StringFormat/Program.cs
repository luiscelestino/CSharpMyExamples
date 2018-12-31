using System;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Luis";
            int idade = 39;
            double rendimento = 80000;
            DateTime dataCadastro = new DateTime(2018, 12, 01);

            // formata rendimento como moeda e data
            string str = "O cliente {0} tem {1} anos de idade e tem rendimento de {2:c}" +
                " e é cliente desde {3:dd/MM/yyyy}.";
            string frase = String.Format(str, nome, idade, rendimento, dataCadastro);

            Console.WriteLine(frase);

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
