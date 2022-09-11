using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio03
    {
        public Exercicio03()
        {
            double peso = 0;
            int somaPessoas = 0;
            
            while ((peso >= 0) && (peso <= 300))
            {
            
               Console.Write("Peso: ");
               peso = Convert.ToDouble(Console.ReadLine());
                
                somaPessoas = somaPessoas + 1;
            }
            
            Console.WriteLine(somaPessoas + " Pessoas disseram seu peso");        
        }
    }
}
