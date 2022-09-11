using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio10
    {
        public Exercicio10()
        {
            int maxNomes = 3,comA = 0, comS=0, silva = 0;
            string[] nomes = new string[maxNomes];
            string namesString = "", maiorNome="", menorNome = "dusahdiuhasuidhasiuhdisahdhsaiuhdsa";
            
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o nome: ");
                nomes[i] = Console.ReadLine().ToUpper();
                
                if (nomes[i] == "S")
                {
                    comS++;
                }
                if (nomes[i] == "A")
                {
                    comA++;
                }
                if (nomes[i] == "SILVA")
                {
                    silva++;
                }
                if (nomes[i].Length > maiorNome.Length)
                {
                    maiorNome = nomes[i];
                }
                if (nomes[i].Length > menorNome.Length)
                {
                    menorNome = nomes[i];
                }

               
            }
            namesString = string.Join(" , ", nomes);
            Console.WriteLine(namesString + 
                              "\nSilvas: " + silva +
                              "\nPessoas com A: " + comA +
                              "\nPessoas com S: " + comS + 
                              "\nMaior nome: " + maiorNome +
                              "\nMenor nome: " + menorNome);

        }
    }
}
