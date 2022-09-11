using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSolicitacaoInformacao
{
    class Exercicio02
    {
        public Exercicio02()
        {
            Console.Write("Informe o consumo de água: ");
            double litros = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe quantos anos de consumo: ");
            int anos = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Informe o valor do litro: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            double litrosConsumidos = anos * litros * 365;
            double valorGasto = litrosConsumidos * valor;

            Console.WriteLine("Você Consumiu: " + litrosConsumidos);

            Console.WriteLine("Você Gastou: " + valorGasto);

       }
    }
}
