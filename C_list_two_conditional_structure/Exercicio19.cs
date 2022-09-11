using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio19
    {
        public Exercicio19()
        {
            Console.Write("Digite o valor do depósito: ");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da parcela do emprestimo: ");
            double parcelaEmprestimo = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o valor do saque: ");
            double saques = Convert.ToDouble(Console.ReadLine());

            if (valorDeposito - parcelaEmprestimo - saques == 0)
            {
                Console.WriteLine("Saldo neutro");
            }
            else if (valorDeposito - parcelaEmprestimo - saques > 0)
            {
                Console.WriteLine("Saldo positivo");
            }
            else
            {
                Console.WriteLine("Saldo negativo");
            }



        }
    }
}
