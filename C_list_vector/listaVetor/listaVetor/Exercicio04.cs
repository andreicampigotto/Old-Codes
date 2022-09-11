using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaVetor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            string disciplina = "";
            double[] notas = new double[4];

            Console.Write("Disciplina :");
            disciplina = Console.ReadLine();

            Console.Write("Nota 1: ");
            notas[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            notas[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            notas[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4: ");
            notas[3] = Convert.ToDouble(Console.ReadLine());

            double somaNotas = notas[0] + notas[1] + notas[2] + notas[3];
            double mediaNotas = notas[0] + notas[1] + notas[2] + notas[3] / 4;

            Console.WriteLine("Média: " + mediaNotas);
        }

    }
}
