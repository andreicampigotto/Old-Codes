using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio11
    {
        public Exercicio11()
        {
            Console.Write("Digite 1ª número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite 2ª número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite 3ª número: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a 4ª número: ");
            double n4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a 5ª nota: ");
            double n5 = Convert.ToDouble(Console.ReadLine());

            double media = ((n1 + n2 + n3 + n4 + n5) / 5);

            if ((media >= 0) && ( media<6)){
                Console.WriteLine("O aluno está reprovado");
            }
            else if ((media >= 6) && (media <=7.99)){
                Console.WriteLine("O aluno está de recuperação");
           }
            else{
                Console.WriteLine("O aluno está aprovado");
            }
                
        }
    }
}
