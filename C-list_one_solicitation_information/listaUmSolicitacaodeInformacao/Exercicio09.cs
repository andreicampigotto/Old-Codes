using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosSolicitacaoInformacao
{
    class Exercicio09
    {
        public Exercicio09()
        {
            Console.Write("Insira o primeiro número: ");
            double numero01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            double numero02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Invertendo \nprimeiro: " + numero02 + 
                "\nsegundo: " + numero01);
        }

    }
}
