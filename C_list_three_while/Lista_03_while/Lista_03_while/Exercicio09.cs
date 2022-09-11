using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio09
    {
        public Exercicio09()
        {
            Console.Write("Digite aqui: ");
            string palavra = Console.ReadLine();
            //string palavraToLower = palavra.ToLower();
            int contadorPalavra = palavra.Length;
            int contadorLetras = 0;

            while (contadorLetras < contadorPalavra)
            {
                Console.WriteLine(palavra[contadorLetras]);
                contadorLetras++;
            }

            
        }
    }
}
