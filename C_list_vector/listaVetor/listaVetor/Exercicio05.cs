using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaVetor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            double [] peso = new double [5];
            
            Console.Write("Digite o primeiro peso: ");
            peso[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo peso: ");
            peso[1] = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o terceiro peso: ");
            peso[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o quarto peso: ");
            peso[3] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o quinto peso: ");
            peso[4] = Convert.ToDouble(Console.ReadLine());

            double somaPesos = peso[0] + peso[1] + peso[2] + peso[3] + peso[4];
            double mediaPesos = somaPesos / 5;

            Console.WriteLine("Soma dos pesos: " + somaPesos +
                              "\nMédia dos pesos: " + mediaPesos);


        }
    }
}
