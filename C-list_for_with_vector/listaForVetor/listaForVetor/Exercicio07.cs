using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio07
    {
        public Exercicio07()
        {
            
           /* Solicite ao usuário 20 caracteres armazenando em um vetor. Após isto verifique e
                apresente os itens abaixo:
            ➔ Quantas são as consoantes
            ➔ Quantas são as vogais;
            ➔ Quantos são caracteres especiais.
            ➔ Quais são as consoantes;
            ➔ Quais são as vogais;
            ➔ Quais são os caracteres especiais.*/
            
            
            string[] caracteres = new string[20];
            string[] especiaisCaracteres = new string[caracteres.Length];
            string[] consoantes = new string[caracteres.Length];
            string[] vogais = new string[caracteres.Length];
            int qtdaVogais = 0, qtdaConsoantes = 0, contador = 0;
            
            

            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.Write("Digite uma frase: ");
                caracteres[i] = Console.ReadLine().ToUpper().Trim();
            }
            for (int j = 0; j < caracteres.Length; j++)
            {
                if (caracteres[j] == "A" || caracteres[j] == "E" || caracteres[j] == "I" || caracteres[j] == "O" || caracteres[j] == "U")
                {
                    vogais[qtdaVogais] = caracteres[j];
                    qtdaVogais++;
                }
            }
            for (int k = 0; k < caracteres.Length; k++)
            {
                    if (caracteres[k] == "B" || caracteres[k] == "C" || caracteres[k] == "D" || caracteres[k] == "F" || caracteres[k] == "G" || caracteres[k] == "H" || caracteres[k] == "J" || caracteres[k] == "K" || caracteres[k] == "L" || caracteres[k] == "M" || caracteres[k] == "N" || caracteres[k] == "P" || caracteres[k] == "Q" || caracteres[k] == "R" || caracteres[k] == "S" || caracteres[k] == "T" || caracteres[k] == "V" || caracteres[k] == "W" || caracteres[k] == "X" || caracteres[k] == "Y" || caracteres[k] == "Z")
                    {
                        consoantes[qtdaConsoantes] = caracteres[k];
                        qtdaConsoantes++;
                    }


                    /*else
                    {
                        contador++;
                    }*/

                    //Console.WriteLine(string.Format("\nVogais:   {0}\nConsoantes:    {1}", vogais[j], consoantes[k]));
            }
            for (int j = 0; j < vogais.Length; j++)
            {
                Console.WriteLine(vogais[j]);
            }
            for (int k = 0; k < consoantes.Length; k++)
            {
                Console.WriteLine(consoantes[k]);
            }
            


            Console.WriteLine("\nVogais:   {0}\nConsoantes:   {1}\nCaracteres especiais:   {2}", qtdaVogais, qtdaConsoantes,contador);

        }
    }
}
