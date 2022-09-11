using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.Write("Quantos Jogos deseja cadastrar: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            string[] jogos = new string[quantidade];
            int[] jogosQuantidade = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Nome do Jogo: ");
                jogos[i] = Console.ReadLine();

                Console.Write("Quantidade: ");
                jogosQuantidade [i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < quantidade; i++)
            {
                
            Console.WriteLine(string.Format("{0} - - - - - {1}", jogos[i] , jogosQuantidade[i]));
            }
        }
    }
}
