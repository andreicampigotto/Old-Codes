using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio02
    {
        public Exercicio02()
        {
            int idade = 0;
            //Console.Write("Idade: ");

            while (idade < 129)
            {
                Console.Write("Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

            }

        }

    }
}
