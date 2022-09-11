using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio06
    {
        public Exercicio06()
        {
            Console.Write("Insira um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Seu numero é 1");
            }
            else
                Console.WriteLine("Seu número não é 1");
        }
    }
}
