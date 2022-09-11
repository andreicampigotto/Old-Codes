using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio13
    {
        public Exercicio13()
        {
            int num = 0;
            int numAux = 0;
            string tabuada = "";

            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            while (numAux < 1000)
            {

                tabuada += num * numAux + "\n";

                numAux++;
            }

            Console.WriteLine(tabuada);
        
        }

    }
}
