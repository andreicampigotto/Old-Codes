using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemploFor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.Write("Exercicio tabuada" +
                "\nDigite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <=10 ; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + numero * i); 
            }
        }
    }
}
