using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exemplo01
    {
        public Exemplo01()
        {
            string[] caracteres = new string[25];
            string[] caracterEspecial = new string[caracteres.Length];




            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.Write("Caracter " + i + ":");
                caracteres[i] = Console.ReadLine().ToUpper().Trim();

            }

            string[] consoantes = new string[caracteres.Length];
            string[] vogais = new string[caracteres.Length];
            int quantidadeVogais = 0, quantidadeConsoantes = 0, contador = 0;

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (caracteres[i] == "A")
                {
                    vogais[i] = caracteres[i];
                    quantidadeVogais++;

                }
                if (caracteres[i] == "E")
                {
                    vogais[i] = caracteres[i];
                    quantidadeVogais++;

                }
                if (caracteres[i] == "I")
                {
                    vogais[i] = caracteres[i];
                    quantidadeVogais++;

                }
                if (caracteres[i] == "O")
                {
                    vogais[i] = caracteres[i];
                    quantidadeVogais++;

                }
                if (caracteres[i] == "U")
                {
                    vogais[i] = caracteres[i];
                    quantidadeVogais++;

                }
                //Consoantes
                if (caracteres[i] == "B")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "C")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "D")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "F")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "G")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "H")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "J")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "K")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "L")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "M")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "N")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "P")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "Q")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "R")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "S")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "T")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "V")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "W")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "X")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                if (caracteres[i] == "Z")
                {
                    consoantes[i] = caracteres[i];
                    quantidadeConsoantes++;
                }
                Console.WriteLine(string.Format("{0} Vogais, {1} consoantes", vogais[i], consoantes[i]));
            }

            Console.WriteLine();
            Console.WriteLine(string.Format("{0} Vogais", quantidadeVogais));
            Console.WriteLine(string.Format("{0} Consoantes", quantidadeConsoantes));



        }
    }
}
       
