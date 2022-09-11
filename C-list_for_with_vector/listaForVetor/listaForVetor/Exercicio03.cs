using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            //programa que armazena preço

            Console.Write("Digite quantos registros irá fazer: ");
            int registros = Convert.ToInt32(Console.ReadLine());

            int[] contador = new int[registros];
            double[] precos = new double [registros];

            for (int i = 0; i < contador.Length; i++)
            {
                Console.Write("Digite o preço: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
                //Console.Clear();
            }
            for (int i = 0; i < contador.Length; i++)
            {
                
            Console.WriteLine(precos[i]);
            }
            


        }
    }
}
