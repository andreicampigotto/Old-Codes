using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            string[] nomes = new string [25];
            Console.Write("Cadastro de pessoas: ");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("\nNome: ");
                nomes[i] = Console.ReadLine();
                //Console.Clear();
                
            }
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
                
            }
        }
        
    }
}
