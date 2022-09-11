using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaVetor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            string[] nomes = new string[7];
            double[] precos = new double[7];

            Console.Write("Digite o nome do produto: ");
            nomes[0] = Console.ReadLine();

            Console.Write("Digite o preço: ");
            precos[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            nomes[1] = Console.ReadLine();

            Console.Write("Digite o preço: ");
            precos[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            nomes[2] = Console.ReadLine();

            Console.Write("Digite o preço: ");
            precos[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            nomes[2] = Console.ReadLine();

            Console.Write("Digite o preço: ");
            precos[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            nomes[3] = Console.ReadLine();

            Console.Write("Digite o preço: ");
            precos[4] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            nomes[4] = Console.ReadLine();

            Console.Write("Digite o preço: ");
            precos[5] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            nomes[5] = Console.ReadLine();

            Console.Write("Digite o preço: ");
            precos[5] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            nomes[6] = Console.ReadLine();

            Console.Write("Digite o preço: ");
            precos[6] = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Lista de produtos : " +
                "\n" + nomes[0] + " " + precos [0] +
                "\n" + nomes[1] + " " + precos [1] +
                "\n" + nomes[2] + " " + precos [2] +
                "\n" + nomes[3] + " " + precos [3] +
                "\n" + nomes[4] + " " + precos [4] +
                "\n" + nomes[5] + " " + precos [5] +
                "\n" + nomes[6] + " " + precos [6]);



            



            



        }
    }
}
