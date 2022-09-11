using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosSolicitacaoInformacao
{
    class Exercicio05
    {
        public Exercicio05()
        {

            Console.Write("Nome do veiculo: ");
            string veiculo = Console.ReadLine();
              

            Console.Write("Valor do veiculo: ");
            double valorCarro = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor da parcela: ");
            double valorParcela = Convert.ToDouble(Console.ReadLine());


            Console.Write("Quantidade de Parcelas: ");
            int qtdaParcelas = Convert.ToInt32 (Console.ReadLine());

            double valorFinanciado = (qtdaParcelas * valorParcela);
            double diferencaValor = (valorFinanciado - valorCarro);

            Console.WriteLine("\nVeiculo: " + veiculo +
                "\nValor do carro: " + valorCarro +
                "\nValor da parcela: " + valorParcela +
                "\nQuantidade de parcelas:" + qtdaParcelas +
                "\nValor total fianciado: " + valorFinanciado +
                "\nDiferença entre o valor total do financiamento e do carro: " + diferencaValor);



        }
    }
}
