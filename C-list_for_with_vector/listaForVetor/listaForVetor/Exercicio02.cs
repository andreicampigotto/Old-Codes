using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio02
    {
        public Exercicio02()
        {
            int[] idades = new int[7];

            Console.Write("Guardar idades: ");
            for (int i = 0; i < idades.Length; i++)
            {
                Console.Write("\nIdade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
                //Console.Clear();
            }

            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }
    }
}
