using System;

namespace GetSet
{
    class Carro
    {
        // Declaração de atributo desnecessária, por causa da propriedade declarada em seguida.
        // Atributo declarado dentro da propriedade.
        // Melhor forma quando há necessidade de mudar a forma padrão do get ou do set.
        private string _marca;
        public string Marca
        {
            get => _marca;
            set => _marca = value;
        }

        // Declaração de atributo desnecessária, por causa da propriedade declarada em seguida.
        // Atributo declarado dentro da propriedade.
        // Pior forma, forma antiga e mais verbosa.
        private int _anoModelo;
        public int AnoModelo
        {
            get { return _anoModelo; }
            set { _anoModelo = value; }
        }

        // Propriedade com get e set padrões.
        // Desconhecimento do nome do atributo.
        // Melhor forma quando se utiliza forma padrão do get e do set.
        public int AnoFabricacao { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            carro.Marca = "Fox";
            carro.AnoModelo = 2013;
            carro.AnoFabricacao = 2012;

            Console.WriteLine($"Eu tenho um carro {carro.Marca}, cujo ano de fabricação" +
                $" é {carro.AnoFabricacao} e o ano do modelo é {carro.AnoModelo}.");

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
