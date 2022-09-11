using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.Write("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

           if  ( numero > 0){
                Console.WriteLine("Número é positivo");
           }
           else {
                Console.WriteLine("Número é negativo");
           }
  
        }
    }
}
