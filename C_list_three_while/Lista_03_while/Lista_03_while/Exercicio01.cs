using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            while (nome.ToLower() != "fim")
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();                
            }
        }
    }
}
