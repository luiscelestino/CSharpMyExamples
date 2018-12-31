using System;
using System.Text;

namespace StringBuilderNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Cada concatenação de string cria um novo buffer, deixando o programa mais lento.
             * O StringBuilder reutiliza o mesmo buffer, sendo muito mais rápido.
             */
            StringBuilder builder = new StringBuilder();

            builder.Append("AAAAAAAAAAAAAAAAAAAAAAA");
            builder.AppendLine("BBBBBBBBBBBBBBBBBBB");
            builder.Append("CCCCCCCCCCCCCCCCCCCCCCC");
            builder.Append("DDDDDDDDDDDDDDDDDDDDDDD");

            string nome = "Luis";
            int idade = 39;
            double rendimento = 80000;
            DateTime dataCadastro = new DateTime(2018, 12, 01);

            // formata rendimento como moeda e data
            string str = "\n\nO cliente {0} tem {1} anos de idade e tem rendimento de {2:c}" +
                " e é cliente desde {3:dd/MM/yyyy}.";
            builder.AppendFormat(str, nome, idade, rendimento, dataCadastro);

            Console.WriteLine(builder);

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
