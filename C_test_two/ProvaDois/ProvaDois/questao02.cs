using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaDois
{
    class questao02
    {
        public questao02()
        {
            int quantidadePecas = 0;
            double valorCompra = 0, valorTotalCompras = 0;
            string nomeCliente = "", clienteTolower = "";
            int vendas = 0;
            Console.Write("Cadastro de clientes." +
                          "\nAo terminar digite sair");



            while (nomeCliente != "sair")
            {
                Console.Write("\nNome do cliente: ");
                nomeCliente = Console.ReadLine();
                clienteTolower = nomeCliente.ToLower();

                if (nomeCliente.ToLower == "sair")
                {
                    break;
                }

                Console.Write("Digite a quantidade de peças compradas: ");
                quantidadePecas = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o valor da compra: ");
                valorCompra = Convert.ToDouble(Console.ReadLine());

                vendas++;
                valorTotalCompras = valorCompra + valorTotalCompras;
            }
            Console.WriteLine("Total de vendas: " + vendas);


        }
    }
}
