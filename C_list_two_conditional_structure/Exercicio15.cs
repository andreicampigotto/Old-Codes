using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio15
    {
        public Exercicio15()
        {
            Console.Write("Digite o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int n3 = Convert.ToInt32(Console.ReadLine());


            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine(n1);
            }


            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine(n2);
            }

            else if (n3 < n1 && n3 < n2)
            {
                Console.WriteLine(n3);
            }

            if ((n1 > n2) && (n1 < n3))
            {
                Console.WriteLine(n1);
            }

            else if (n1 < n2 && n1 > n3)
            {
                Console.WriteLine(n1);
            }

            else if (n2 > n1 && n2 < n3)
            {
                Console.WriteLine(n2);
            }

            else if (n2 < n1 && n2 > n3)
            {
                Console.WriteLine(n2);
            }

            else if (n3 > n1 && n3 < n2)
            {
                Console.WriteLine(n3);
            }

            else if (n3 < n1 && n3 > n2)
            {
                Console.WriteLine(n3);
            }
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1);
            }


            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine(n2);
            }

            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine(n3);
            }
        }
    }
}
