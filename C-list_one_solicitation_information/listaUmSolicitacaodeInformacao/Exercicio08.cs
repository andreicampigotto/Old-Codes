using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosSolicitacaoInformacao
{
    class Exercicio08
    {
        public Exercicio08()
        {
            Console.Write("Digite o valor da conta de luz: ");
            double contaLuz = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da conta de água: ");
            double contaAgua = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da conta da Net: ");
            double contaNet = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da conta da Vivo: ");
            double contaVivo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da conta da Oi: ");
            double contaOi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da conta de IPTU: ");
            double contaIptu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da conta de IPVA: ");
            double contaIpva = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do seguro do carro: ");
            double contaSeguroCarro = Convert.ToDouble(Console.ReadLine());

            double contasTelefonia = (contaNet + contaOi + contaVivo);
            double impostos = (contaIptu + contaIpva);
            double outrasContas = (contaLuz + contaAgua + contaSeguroCarro);
            double totalContas = (contasTelefonia + impostos + outrasContas);

            Console.WriteLine("Suas contas de tefefone são: " + contasTelefonia +
                    "\nSeus impostos são: " + impostos + 
                    "\nSuas outras contas são:" + outrasContas +
                    "\nSeu total de contas são: " + totalContas);



        }
    }
}
