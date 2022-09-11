using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio08
    {
        public Exercicio08()
        {
            int caracteres = 0;
            int contagem = 0;
            char letra = ' ';
            string palavra = " ";
            
            Console.Write("Quantos caracteres serão digitados: ");
            caracteres = Convert.ToInt32(Console.ReadLine());

            while (caracteres != contagem ){

            Console.Write("\nCaracter: ");
            letra = Convert.ToChar(Console.ReadLine());
                
                contagem++;
                palavra = palavra + letra; 

            }

            Console.WriteLine(palavra);
            Console.WriteLine(contagem);

        }
    }
}
