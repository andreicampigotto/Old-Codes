using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSolicitacaoInformacao
{
    class Exercicio04
    {
        public Exercicio04()
        {
            Console.Write("Tabuada:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int VezesZero = (numero * 0);
            
            int VezesUm = (numero * 1);

            int VezesDois = (numero * 2);

            int VezesTres = (numero * 3);

            int VezesQuatro = (numero * 4);

            int VezesCinco = (numero * 5);

            int VezesSeis = (numero * 6);

            int VezesSete = (numero * 7);

            int VezesOito = (numero * 8);

            int VezesNove = (numero * 9);

            int VezesDez = (numero * 10);

            Console.WriteLine("\n\n Vezes 0:  " + VezesZero +
                "\n Vezes 1:  " + VezesUm +
                "\n Vezes 2:  " + VezesDois +
                "\n Vezes 3:  " + VezesTres +
                "\n Vezes 4:  " + VezesQuatro +
                "\n Vezes 5:  " + VezesCinco +
                "\n Vezes 6:  " + VezesSeis +
                "\n Vezes 7:  " + VezesSete +
                "\n Vezes 8:  " + VezesOito +
                "\n Vezes 9:  " + VezesNove +
                "\n Vezes 10: " + VezesDez);
                

        }
    }
}
