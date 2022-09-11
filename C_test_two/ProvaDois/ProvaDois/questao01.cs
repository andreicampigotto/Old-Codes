using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaDois
{
    class questao01
    {
        public questao01()
        {

            int contador = 0;
            string nomeProducao = "";
            int anoLancamento = 0, idadeProducao = 0, anoAtual = 0, producoes = 0;
            string diretor = "", maiorDiretor = "", menorDiretor = "                              ";
            double orcamento = 0;
            double receita = 0;
            string descricao = "";
            double lucroPorProducao = 0;
            double maiorReceita = 0;
            string filmeMaiorReceita = "", filmeMenorOrcamento = "", filmeMaisVelho = "";
            double menorOrcamento = 99999999999;
            

            Console.Write("Insira quantas produções serão cadastradas: ");
            producoes = Convert.ToInt32(Console.ReadLine());
                
            Console.Write("Digite o ano atual: ");
            anoAtual = Convert.ToInt32(Console.ReadLine());

            while (producoes > contador)
            {


                Console.Write("\nDigite o nome da produção: ");
                nomeProducao = Console.ReadLine();

                Console.Write("Digite o ano de lançamento: ");
                anoLancamento = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o nome do diretor: ");
                diretor = Console.ReadLine();

                Console.Write("Digite o orçamento: ");
                orcamento = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a receita: ");
                receita = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a descrição: ");
                descricao = Console.ReadLine();

                lucroPorProducao = receita - orcamento;
                
                Console.WriteLine("Lucro obtido: " + lucroPorProducao);
                
                contador++;

                Console.Clear();
                
                idadeProducao = anoAtual - anoLancamento;
                
                if (receita > maiorReceita)
                {
                    maiorReceita = receita;
                    filmeMaiorReceita = nomeProducao; 
                }
                
                if (orcamento < menorOrcamento)
                {
                    menorOrcamento = orcamento;
                    filmeMenorOrcamento = nomeProducao;
                }

                /*if (idadeProducao < anoLancamento)
                {

                }*/

                
                if (diretor.Length > maiorDiretor.Length)
                {
                    maiorDiretor = diretor;
                }
                
                if (diretor.Length < menorDiretor.Length)
                {
                    menorDiretor = diretor;
                }

            }

            Console.WriteLine("Filme com maior receita: " + filmeMaiorReceita +
                              "\nReceita: " + maiorReceita +
                              "\nFilme com menor orçamento: " + filmeMenorOrcamento +
                              "\nOrçamento: " + menorOrcamento + 
                              "\nAno da produção mais velha: " + filmeMaisVelho + 
                              "\nDiretor com maior nome: " + maiorDiretor + 
                              "\nDiretor com menor nome: " + menorDiretor);
            


        }
    }
}
