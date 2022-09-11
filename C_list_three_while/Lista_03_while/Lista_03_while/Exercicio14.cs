using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio14
    {
        public Exercicio14()
        {
            int num = 0;
            int numAux = 1;
            int resultado = 1;

            Console.Write("Número fatorial." +
                        "\nDigite um número: " );
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                numAux = num;
                resultado *= num;
                num--;
               

            }

            Console.WriteLine(resultado);
        }
    }
}
