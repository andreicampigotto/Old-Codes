using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSolicitacaoInformacao
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.Write("Digite um número:");
            
            int numero = Convert.ToInt32(Console.ReadLine());
            int antecessor = (numero - 1);
            int sucessor = (numero + 1);

            Console.WriteLine("O antecessor é: " + antecessor + " O sucessor é: " + sucessor);

        }
    }
}
