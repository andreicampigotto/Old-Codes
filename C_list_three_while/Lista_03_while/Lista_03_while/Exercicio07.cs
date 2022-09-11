using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio07
    {
        public Exercicio07()
        {
            int quatidadeAtletas = 0;
            string nomes = "";
            string maiorNome = "";
            string menorNome = "usahduisahuidhsauidhuisahduisahdiasuahsuahushaushuahs";
            int idade = 0;
            double peso = 0, maiorPeso = int.MinValue, menorPeso = int.MaxValue;
            char sexo = ' ';
            double altura = 0, maiorAltura = int.MinValue, menorAltura = int.MaxValue;
            int golsMarcados = 0;
            int cartaoAmaelo = 0, maiorCartaoAmarelos = int.MinValue,menorCartaoAmarelos = int.MinValue;
            int cartaoVermelho = 0, maiorCartaoVermelhos = int.MinValue, menorCartaoVermelhos = int.MinValue;
            int sexoM = 0;
            int sexoF = 0;
            string nomesMenorPeso = "";
            string nomesMaiorAltura = "";
            string nomesmenorCartaoAmarelos = "";
            string nomesMaiorPeso = "";
            string nomesMaiorCartaoVermelhos = "";
            string nomesMaiorCartaoAmarelos = "";
            string nomesMenorCartaoVermelhos = "";
            Console.Write(" ======================================================= "+
                          " ======================================================= ");
            
            while (quatidadeAtletas < 3)
            {
                Console.Write("\nDigite o nome do atleta: ");
                nomes = Console.ReadLine();

                Console.Write("Digite a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o sexo\nM para masculino\nF para feminino: ");
                sexo = Convert.ToChar(Console.ReadLine().ToLower());

                Console.Write("Digite a altura: ");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade de gols marcados: ");
                golsMarcados = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de cartões amarelos recebidos: ");
                cartaoAmaelo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de cartões vermelhos recebidos: ");
                cartaoVermelho = Convert.ToInt32(Console.ReadLine());
                quatidadeAtletas = quatidadeAtletas + 1;

                if (nomes.Length > maiorNome.Length)
                {
                    maiorNome = nomes;
                }
                
                if (nomes.Length < menorNome.Length)
                {
                    menorNome = nomes;
                }
                
                if (peso < menorPeso)
                {
                    menorPeso = peso;
                    nomesMenorPeso = nomes;
                }
                
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    nomesMaiorAltura = nomes;
                }
                
                if (cartaoAmaelo < menorCartaoAmarelos)
                {
                    menorCartaoAmarelos = cartaoAmaelo;
                    nomesmenorCartaoAmarelos = nomes;
                }
                
                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                    nomesMaiorPeso = nomes;
                }
                
                if (cartaoVermelho > maiorCartaoVermelhos)
                {
                    maiorCartaoVermelhos = cartaoVermelho;
                    nomesMaiorCartaoVermelhos = nomes;
                }
                
                if (cartaoAmaelo > maiorCartaoAmarelos)
                {
                    maiorCartaoAmarelos = cartaoAmaelo;
                    nomesMaiorCartaoAmarelos = nomes;
                }
                
                if (cartaoVermelho < menorCartaoVermelhos)
                {
                    menorCartaoVermelhos = cartaoVermelho;
                    nomesMenorCartaoVermelhos = nomes;
                }

                if (sexo == 'm')
                {
                    sexoM++;
                }
                
                if (sexo == 'f')
                {
                    sexoF++;
                }
            }
            Console.WriteLine("\nJogador com menor peso: " + nomesMenorPeso +" " + menorPeso + " Kg" +
                              "\nJogador com a maior altura: " +nomesMaiorAltura + " " + maiorAltura + " cm" +
                              "\nJogador com maior nome: " + maiorNome + 
                              "\nTem " + sexoF + " jogadores do sexo Feminino" +
                              "\nTem " + sexoM + " jogadores do sexo Masculino" +
                              "\nJogador com menor quantidade de cartão amarelo recebido: " + nomesmenorCartaoAmarelos + " com " + menorCartaoAmarelos + " cartões" + 
                              "\nJogador com menor nome: " + menorNome + 
                              "\nJogador com maior peso: " + nomesMaiorPeso + " " + maiorPeso + " Kg"+
                              "\nJogador com maior quantidade de cartão vermelho: " + nomesMaiorCartaoVermelhos + " " + maiorCartaoVermelhos + " cartões" + 
                              "\nJogador com a maior quantidade de cartão amarelo recebido: " + nomesMaiorCartaoAmarelos + " " + maiorCartaoAmarelos + " cartões" + 
                              "\nJogador com a menor quantidade de cartão vermelho recebido: " + nomesMenorCartaoVermelhos + " " + menorCartaoVermelhos + " cartões");
        }
    }
}
