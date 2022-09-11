using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemploFor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            Console.Write("Digite um tamanho: ");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                    {

                     if ((i >=  1  && i < max -1) && (j >= 1 && j < max -1))
                     {
                     Console.Write("   ");

                     }
                     else
                     {
                         Console.Write(" * ");

                     }
                     }
                     Console.WriteLine();
           }
         
                       
        }
    }
}
