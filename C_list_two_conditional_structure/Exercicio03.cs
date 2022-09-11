using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.Write("Insira o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Insira o segundo número:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" -----------------------"  +
                           "\n|     1   |     SOMA    |" +
                           "\n|-----------------------|" +
                           "\n|     2   |   SUBTRAIR  |" +
                           "\n|-----------------------|" + 
                           "\n|     3   | MULTIPLICAR |" +
                           "\n|-----------------------|" +
                           "\n|     4   |   DIVIDIR   |" +
                           "\n -----------------------"  );

           //int soma = (numero1 + numero2);



            Console.Write("Escolha uma opção: " );
            int opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1){
                Console.WriteLine("A Soma é: " + (numero1 + numero2)); 
                }
            else if (opcao == 2)
            {
                Console.WriteLine("A Subtração é: " + (numero1 - numero2)); 
            }
            else if (opcao == 3)
                Console.WriteLine("A Multiplicação é: " + (numero1 * numero2));
            else
                Console.WriteLine("A Divisão é: " + (numero1 / numero2)); 

        }
    }
}
