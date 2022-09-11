using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSolicitacaoInformacao
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int soma = (numero1 + numero2);
            int subtracao = (numero1 - numero2);
            int multiplicação = (numero1 * numero2);
            double divisão = (numero1 / numero2);
            int produto = ((numero1 * numero1) + (numero2 * numero2));

            Console.WriteLine("A Soma é: " + soma +
             "\nA Subtração é: " + subtracao +
             "\nA Multiplicação é: " + multiplicação +
             "\nA Divisão é: " + divisão +
             "\nO Produto é: " + produto);
            


        }
    }
}
