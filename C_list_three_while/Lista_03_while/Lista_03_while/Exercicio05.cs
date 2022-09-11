using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio05
    {
        public Exercicio05()
        {
            double numero1 = 0;
            double numero2 = 0;
            int opcao = 0;
            
            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n ------------------------ " + 
                              "\n|     1    |     SOMA    |" +
                              "\n|------------------------|" +
                              "\n|     2    |   SUBTRAIR  |" +
                              "\n|------------------------|" + 
                              "\n|     3    | MULTIPLICAR |" +
                              "\n|------------------------|" + 
                              "\n|     4    |   DIVIDIR   |" +
                              "\n|------------------------|" + 
                              "\n|     5    |     SAIR    |" +
                              "\n ------------------------ ");


            Console.Write("Escolha uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            while(opcao != 5)
            {
                if (opcao == 1)
                {
                    double somaNumeros = numero1 + numero2;
                    Console.WriteLine(somaNumeros);
                }
                else if (opcao == 2)
                {
                    double subtracaoNumeros = numero1 - numero2;
                    Console.WriteLine(subtracaoNumeros);
                }
                else if (opcao == 3)
                {
                    double multiplicacaoNumeros = numero1 * numero2;
                    Console.WriteLine(multiplicacaoNumeros);
                }
                else 
                {
                    double divisaoNumeros = numero1 / numero2;
                    Console.WriteLine( divisaoNumeros);
             
                }
                break;
            }
        }
    }
}
