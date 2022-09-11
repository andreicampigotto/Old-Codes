using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaVetor
{
    class Exercicio06
    {
        public Exercicio06()
        {
            string[] pessoas = new string[9];
            int[] idades = new int[9];
            int maiorIdade = 0;
            string pessoaMaisVelha = "";
            
            Console.Write("Digite primeiro nome: ");
            pessoas [0] = Console.ReadLine();
            Console.Write("Digite a primeira idade: ");
            idades[0]= Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite segundo nome: ");
            pessoas [1] = Console.ReadLine();
            Console.Write("Digite a segunda idade: ");
            idades[1]= Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite terceiro nome: ");
            pessoas [2] = Console.ReadLine();
            Console.Write("Digite a primeira idade: ");
            idades[2]= Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite quarto nome: ");
            pessoas [3] = Console.ReadLine();
            Console.Write("Digite a quarta idade: ");
            idades[3]= Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite quinto nome: ");
            pessoas [4] = Console.ReadLine();
            Console.Write("Digite a quinta idade: ");
            idades[4]= Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite sexto nome: ");
            pessoas [5] = Console.ReadLine();
            Console.Write("Digite a sexta idade: ");
            idades[5]= Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite sétimo nome: ");
            pessoas [6] = Console.ReadLine();
            Console.Write("Digite a sétima idade: ");
            idades[6]= Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite oitavo nome: ");
            pessoas[7] = Console.ReadLine();
            Console.Write("Digite a oitava idade: ");
            idades[7]= Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite nono nome: ");
            pessoas[8] = Console.ReadLine();
            Console.Write("Digite a nona idade: ");
            idades[8]= Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (idades[0] > maiorIdade)
            {
                maiorIdade = idades[0];
                pessoaMaisVelha = pessoas[0];
            }
            
            if (idades[1] > maiorIdade)
            {
                maiorIdade = idades[1];
                pessoaMaisVelha = pessoas[1];
            }
            
            if (idades[2] > maiorIdade)
            {
                maiorIdade = idades[2];
                pessoaMaisVelha = pessoas[2];
            }

            if (idades[3] > maiorIdade)
            {
                maiorIdade = idades[3];
                pessoaMaisVelha = pessoas[3];
            }
            
            if (idades[4] > maiorIdade)
            {
                maiorIdade = idades[4];
                pessoaMaisVelha = pessoas[4];
            }
            
            if (idades[5] > maiorIdade)
            {
                maiorIdade = idades[5];
                pessoaMaisVelha = pessoas[5];
            }
            
            if (idades[6] > maiorIdade)
            {
                maiorIdade = idades[6];
                pessoaMaisVelha = pessoas[6];
            }
            
            if (idades[7] > maiorIdade)
            {
                maiorIdade = idades[7];
                pessoaMaisVelha = pessoas[7];
            }

            if (idades[8] > maiorIdade)
            {
                maiorIdade = idades[8];
                pessoaMaisVelha = pessoas[8];
            }

            Console.WriteLine("Pessoa mais velha: " + pessoaMaisVelha +
                            "\n" + maiorIdade + " anos" );
        }
    }
}
