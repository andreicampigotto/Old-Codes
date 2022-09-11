using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio02
    {
        public Exercicio02()
        {
            //solicitar um numero e dizer se ele é negativo ou não(0 é nulo);

            Console.Write("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            if (numero > 0 ){
                Console.WriteLine("Este número é positivo");
            }
            else if (numero == 0){
                Console.WriteLine("Este número é nulo");
                }
                

            else
                Console.WriteLine("Este número é negativo");
            
                


        }
    }
}
