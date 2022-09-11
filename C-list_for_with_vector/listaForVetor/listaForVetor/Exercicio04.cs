using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            
            
            int[] camisas = new int[40];
            string[] tamanhos = new string[camisas.Length];
            int PP = 0, P = 0, M = 0, G = 0, GG = 0, XG = 0, XGG = 0;
            
            for (int i = 0; i < camisas.Length; i++)
            {
                Console.Write("Insira o tamanho da camisa: ");
                tamanhos[i] = Console.ReadLine();
               
            }
            for (int i = 0; i < camisas.Length; i++)
            {

                if (tamanhos[i].ToUpper() == "PP")
                {
                    PP++;
                }
                else if (tamanhos[i].ToUpper() == "P")
                {
                    P++;
                }
                else if (tamanhos[i].ToUpper() == "M")
                {
                    M++;
                }
                else if (tamanhos[i].ToUpper() == "G")
                {
                    G++;
                }
                else if (tamanhos[i].ToUpper() == "GG")
                {
                    GG++;
                }
                else if (tamanhos[i].ToUpper() == "XG")
                {
                    XG++;
                }
                else if (tamanhos[i].ToUpper() == "XGG")
                {
                    XGG++;
                }
                    
                    
                
            }
            Console.WriteLine(string.Format(" Camisas \nPP:   {0}\nP:    {1}\nM:    {2}\nG:    {3}\nGG:   {4}\nXG    {5}\nXGG   {6}", PP, P, M, G, GG, XG, XGG));
        }
    }
}
