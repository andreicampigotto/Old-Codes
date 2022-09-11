using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaVetor
{
    class Exercicio07
    {
        public Exercicio07()
        {
            double[] altura = new double [4];
            string[] animal = new string[4];
            double menorAnimal = 9999999;
            string nomeMenorAnimal = "";

            Console.Write("Animal: ");
            animal[0] = Console.ReadLine();
            Console.Write("Altura: ");
            altura[0] = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Animal: ");
            animal[1] = Console.ReadLine();
            Console.Write("Altura: ");
            altura[1] = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Animal: ");
            animal[2] = Console.ReadLine();
            Console.Write("Altura: ");
            altura[2] = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Animal: ");
            animal[3] = Console.ReadLine();
            Console.Write("Altura: ");
            altura[3] = Convert.ToDouble(Console.ReadLine());

            if (altura[0] < menorAnimal)
            {
                menorAnimal = altura[0];
                nomeMenorAnimal = animal[0];
            }
            
            if (altura[1] < menorAnimal)
            {
                menorAnimal = altura[1];
                nomeMenorAnimal = animal[1];
            }

            if (altura[2] < menorAnimal)
            {
                menorAnimal = altura[2];
                nomeMenorAnimal = animal[2];
            }

            if (altura[3] < menorAnimal)
            {
                menorAnimal = altura[3];
                nomeMenorAnimal = animal[3];
            }

            Console.WriteLine("Menor animal é: " + nomeMenorAnimal + 
                           "\n" + menorAnimal + " cm");

        }
    }
}
