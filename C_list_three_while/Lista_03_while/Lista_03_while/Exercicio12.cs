using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio12
    {
        public Exercicio12()
        {

            Console.Write(" ===================================================================== ");
            
            string nome = " ";
            double valor = 0;
            int qtda = 0;
            int contagem = 0;
            double valorTotal = 0;
            double desconto = 150;
            double totalApagar = 0; 
            while (contagem < 5)
            {
                Console.Write("\nProduto: ");
                nome = Console.ReadLine();

                Console.Write("Valor: ");
                valor = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade: ");
                qtda = Convert.ToInt32(Console.ReadLine());

                contagem++;
                valorTotal += valor * qtda;
            }


            totalApagar = valorTotal - desconto;

            Console.WriteLine("\nValor da compra: " + valorTotal +
                              "\nDesconto: " + desconto +
                              "\nTotal a Pagar: " + totalApagar);
        }

    }
}
