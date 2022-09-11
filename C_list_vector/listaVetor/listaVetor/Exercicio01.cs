using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaVetor
{
    class Exercicio01
    {
        public Exercicio01()
        {

            int[] numeros = new int [16];
            Console.Write("insira um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            numeros[0] = num;

            Console.Write("insira um numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            numeros[1] = num1;

            Console.Write("insira um numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            numeros[2] = num3;

            Console.Write("insira um numero: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            numeros[3] = num4;

            Console.Write("insira um numero: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            numeros[4] = num5;

            Console.Write("insira um numero: ");
            int num6 = Convert.ToInt32(Console.ReadLine());
            numeros[5] = num6;

            Console.Write("insira um numero: ");
            int num7 = Convert.ToInt32(Console.ReadLine());
            numeros[6] = num7;

            Console.Write("insira um numero: ");
            int num8 = Convert.ToInt32(Console.ReadLine());
            numeros[7] = num8;

            Console.Write("insira um numero: ");
            int num9 = Convert.ToInt32(Console.ReadLine());
            numeros[8] = num9;

            Console.Write("insira um numero: ");
            int num0 = Convert.ToInt32(Console.ReadLine());
            numeros[9] = num0;

            Console.Write("insira um numero: ");
            int num11 = Convert.ToInt32(Console.ReadLine());
            numeros[10] = num11;

            Console.Write("insira um numero: ");
            int num12 = Convert.ToInt32(Console.ReadLine());
            numeros[11] = num12;

            Console.Write("insira um numero: ");
            int num13 = Convert.ToInt32(Console.ReadLine());
            numeros[12] = num13;

            Console.Write("insira um numero: ");
            int num14 = Convert.ToInt32(Console.ReadLine());
            numeros[13] = num14;

            Console.Write("insira um numero: ");
            int num15 = Convert.ToInt32(Console.ReadLine());
            numeros[14] = num15;

            Console.Write("insira um numero: ");
            int num16 = Convert.ToInt32(Console.ReadLine());
            numeros[15] = num16;

            int somaVetores = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6] + numeros[7] + numeros[8] + numeros[9] + numeros[10] + numeros[11] + numeros[12] + numeros[13] + numeros[14] +
                numeros[15];

            Console.WriteLine(somaVetores);
        }
    }
}
