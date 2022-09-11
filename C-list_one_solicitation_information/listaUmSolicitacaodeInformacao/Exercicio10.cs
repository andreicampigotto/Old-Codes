using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosSolicitacaoInformacao
{
    class Exercicio10
    {
        public Exercicio10()
        {
            Console.Write("Digite seu ano de nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            int idade = (2018 - ano);

            Console.WriteLine("\n Sua idade é:" + idade);
        }
    }
}
