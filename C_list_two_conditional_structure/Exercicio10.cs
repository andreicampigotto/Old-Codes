using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio10
    {
        public Exercicio10()
        {
            Console.Write("Digite o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o quarto número: ");
            int n4 = Convert.ToInt32(Console.ReadLine());

            if ((n1!=n2) && (n3!=n4)){
                Console.WriteLine("É um retangulo");
            }

            else if (n1==n2 && n3==n4){
                   Console.WriteLine("É um quadrado");
                }
            else 
                Console.WriteLine("Não é retangulo");
        }
    }
}
