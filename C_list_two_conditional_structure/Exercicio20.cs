using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio20
    {
        public Exercicio20()
        {

            Console.Write("Descubra seu IMC");

            Console.Write("\nDigite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double r = peso / (altura * altura);
            Console.WriteLine(r);
            if (peso / (altura * altura) < 10)
            {
                Console.WriteLine("Desnutrição Grau V");
            }
            else if (peso / (altura * altura) >= 10 && peso / (altura * altura) < 13)
            {
                Console.WriteLine("Desnutrição Grau IV");
            }
            else if (peso / (altura * altura) >= 13 && peso / (altura * altura) < 16)
            {
                Console.WriteLine("Desnutrição Grau III");
            }
            else if (peso / (altura * altura) >= 16 && peso / (altura * altura) < 17)
            {
                Console.WriteLine("Desnutrição Grau II");
            }
            else if (peso / (altura * altura) >= 17 && peso / (altura * altura) < 18.5)
            {
                Console.WriteLine("Desnutrição Grau I");
            }
            else if (peso / (altura * altura) >= 18.5 && peso / (altura * altura) < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (peso / (altura * altura) >= 25 && peso / (altura * altura) < 30)
            {
                Console.WriteLine("Pré-obesidade");
            }
            else if (peso / (altura * altura) >= 30 && peso / (altura * altura) < 35)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (peso / (altura * altura) >= 35 && peso / (altura * altura) < 40)
            {
                Console.WriteLine("Obesidade Grau II");
            }
            else //if (peso / (altura * altura) >= 40 )
            {
                Console.WriteLine("Obesidade Grau III");
            }

            }
    }
}
