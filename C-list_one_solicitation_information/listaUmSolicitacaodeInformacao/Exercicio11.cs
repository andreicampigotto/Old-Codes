using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosSolicitacaoInformacao
{
    class Exercicio11
    {
        public Exercicio11()
        {
                       
            Console.Write("Digite o dia que você nasceu: ");
            int diaNascimeto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o mês que você nasceu: ");
            int mesNascimeto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o ano que você nasceu: ");
            int anoNascimeto = Convert.ToInt32(Console.ReadLine());

           
            int diasVivo = (2018 + 113);
            Console.WriteLine("Você está vivo");

        }
    }
}
