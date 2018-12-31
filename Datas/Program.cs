using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * FONTES:
             *  - https://docs.microsoft.com/pt-br/dotnet/standard/base-types/custom-date-and-time-format-strings
             */

            // data e hora atual
            Console.WriteLine("{0}", DateTime.Now);

            // adicionando dias
            Console.WriteLine( "{0}", DateTime.Now.AddDays(2) );

            // subtraindo dias
            Console.WriteLine( "{0}", DateTime.Now.AddDays(-2) );

            // instanciando data
            DateTime data = new DateTime(2018, 12, 04);
            Console.WriteLine(data);

            // instanciando data com hora
            DateTime dataHora = new DateTime(2018, 12, 04, 08, 30, 00);
            Console.WriteLine(dataHora);

            // fazendo parser via string (por exemplo, consumindo de um banco de dados)
            string strDataBD = "2018-12-04 08:30:00";
            DateTime dataBD = DateTime.Parse(strDataBD);
            Console.WriteLine(dataBD);

            // imprimindo data formatada
            string horaFormatada = String.Format("{0:HH}h{0:mm}", dataBD);
            Console.WriteLine(horaFormatada);

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
