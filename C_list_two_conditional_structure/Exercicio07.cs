using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio07
    {
        public Exercicio07()
        {
            Console.Write("Insira um numero: ");
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
            
            if (numero > 0)
            {
                Console.WriteLine("Seu número é positivo");
            }

            else
            {
                Console.WriteLine("Seu número é negativo");
            }
            if (numero > 10)
            {
                Console.WriteLine("Seu número é positivo e maior que 10");
            }
           if (numero <= 50){
                Console.WriteLine("Seu número é menor ou 50");
            }
           if (numero < -10)
           {
               Console.WriteLine("Seu número é menor que -10");
           }

           if (numero >= 30)
           {
               Console.WriteLine("Seu número é maior ou 30");
           }

            if (numero != 1)
                Console.WriteLine("Seu número é diferente de 1");

        }
    }
}