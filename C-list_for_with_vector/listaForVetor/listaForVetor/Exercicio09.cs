using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio09
    {
        public Exercicio09()
        {
            Console.Write("Disciplina: ");
            String disciplina = Console.ReadLine();
            int maxVetor = 4;
            double[] notas = new double[maxVetor];
            string notaString = "";
            double soma = 0, media = 0;

            for (int i = 0; i < maxVetor; i++)
            {
                Console.Write("Digite a nota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                
                soma = soma + notas[i];
                media = soma / maxVetor;

                
            }

            notaString = string.Join(" | ", notas);
            Console.WriteLine(notaString);
            Console.Write(string.Format("{0} Media: ", media));


        }
    }
}
