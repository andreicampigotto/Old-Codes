using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio06
    {
        public Exercicio06()
        {
            int[] numeros = new int[10];
            Random ramdomicos = new Random(); 

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = ramdomicos.Next(-75,75);
            }

            int pares = 0, impares = 0, positivos = 0, negativos = 0, neutros = 0;
            double somatoria = 0, media = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 0)
                {
                    neutros++;
                }
                else if (numeros[i] > 0)
                {
                    positivos++;
                }
                else if (numeros[i] < 0)
                {
                    negativos++;
                }
                if (numeros[i] %2 == 0 )
                {
                    pares++;
                }
                else 
                {
                    impares++;
                }
                Console.WriteLine("  " +numeros[i]);

                somatoria = somatoria + numeros[i];
                media = somatoria / numeros.Length;

            }
            Console.WriteLine("\n" +
                              "\n " + somatoria +
                              "\n " + media);

            Console.WriteLine(string.Format("\nNúmeros neutros:   {0}\nImpares:    {1}\nPares:    {2}\nPositivos:    {3}\nNegativos:   {4}", neutros, impares, pares, positivos, negativos));
        }
    }
}
