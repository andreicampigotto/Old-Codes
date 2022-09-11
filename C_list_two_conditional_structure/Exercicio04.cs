using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio04
    {
        public Exercicio04()
        {
            // dizer se numero é par ou impar (se resto = 1 impar se resto 0 par)

            Console.Write("Digite um número, exceto negativos: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("Seu número é nulo");
            }
            else if (numero % 2 == 0)
            {
                Console.WriteLine("Seu numero é par");
            }
            else
            {
                Console.WriteLine("Seu número é impar");
            }
        }
    }
}