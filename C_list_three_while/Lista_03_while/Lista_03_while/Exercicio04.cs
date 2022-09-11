using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio04
    {
        public Exercicio04()
        {
            int qtdacarros = 0;
            int numcarros = 0;
            int somaAnoCarro = 0;
            double somaValorCarro = 0;
            string modelo = "";
            char primeiraLetra = ' ';
            int carrosG = 0;
            int carrosA = 0;

            Console.Write("Digite quantos carros deseja cadastrar: ");
            qtdacarros = Convert.ToInt32(Console.ReadLine());

            while (qtdacarros != numcarros)
            {
                Console.Write("\nDigite o modelo do carro: ");
                modelo = Console.ReadLine();
                primeiraLetra = modelo[0];


                Console.Write("Digite o valor do carro: ");
                double valorCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o ano do carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());

                numcarros = numcarros + 1;

                if (primeiraLetra == 'g')
                {
                   carrosG = carrosG + 1;
                }
                else if (primeiraLetra == 'a')
                {
                    carrosA = carrosA + 1;
                }

                somaAnoCarro = anoCarro + somaAnoCarro;
                somaValorCarro = valorCarro + somaValorCarro;
            }


            int mediaAnoCarros = somaAnoCarro / qtdacarros;
            double mediaValorCarro = somaValorCarro / qtdacarros;
            
            double mediaValorCarros = somaValorCarro / qtdacarros;
            Console.WriteLine("\nMédia de anos dos carros: " + mediaAnoCarros +
                "\nMédia dos valores dos carros: " + mediaValorCarros +
                "\nQuantidade de carros que começam com G: " + carrosG +
                "\nQuantidade de carros que começam com A: " + carrosA);
        }
    }
}


