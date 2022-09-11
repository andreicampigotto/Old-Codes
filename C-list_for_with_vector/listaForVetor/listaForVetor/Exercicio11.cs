using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio11
    {
        public Exercicio11()
        {
            int nomes = 5;
            string[] nomeString = new string [nomes];
            string apresentacao = "";
            for (int i = 0; i < nomes; i++)
            {
                Console.Write("Insira o nome: ");
                nomeString[i] = Console.ReadLine(); 


            }
            apresentacao = string.Join(" , ", nomeString);
           
            
            /*if (nomeString.Length == nomes)
           {
               apresentacao = string.Join(" . ", nomes);
           }*/

            Console.WriteLine(apresentacao);
        }
    }
}
