using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    public class Quadros
    {
        string[] nomeDoQuadro = new string[150];
        string[] pintor = new string[150];
        string[] descricao = new string[150];
        int[] ano = new int[150];
        double[] valorDoQuadro = new double[150];
        int[] cod = new int[150];
        int qtda = 0, somaAnos=0;
        double mediaAnos = 0;

        public Quadros()
        {
            nomeDoQuadro[qtda] = "Batalha de Avaí";
            pintor[qtda] = "Pedro Américo de Figueiredo e Melo";
            ano[qtda] = 1877;
            valorDoQuadro[qtda] = 0000;
            descricao[qtda] = "Quadro em homenagem a vitória do Brasil na batalha da triplice fronteira.";
            cod[qtda]++;
            qtda++;

            nomeDoQuadro[qtda] = "A Face da Guerra";
            pintor[qtda] = "Salvador Dalí";
            ano[qtda] = 1940;
            valorDoQuadro[qtda] = 0000;
            descricao[qtda] = "Quadro demonstrando que a guerra só tráz sofrimento.";
            cod[qtda]++;
            qtda++;

            nomeDoQuadro[qtda] = "Independência ou Morte";
            pintor[qtda] = "Pedro Américo de Figueiredo e Melo";
            ano[qtda] = 1888;
            descricao[qtda] = "";
            valorDoQuadro[qtda] = 0000;
            cod[qtda]++;
            qtda++;
        } // vetor pré alimentado

        public void iniciar()
        {
            int op = 0;
            Console.Clear();
            do
            {
                try
                {
                    Console.Clear();
                    op = menu();
                    switch (op)
                    {
                        case 0:
                            Console.WriteLine("\nSAIR");
                            break;
                        case 1:
                            cadastrar();
                            break;
                        case 2:
                            listar();
                            break;
                        case 3:
                            alterar();
                            break;
                        case 4:
                            remover();
                            break;
                        case 5:
                            estatisticas();
                            break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro.: " + e.ToString());
                }
                Console.ReadKey();
            } while (op != 0);
        }

        public int menu()
        {
            Console.WriteLine(
                            @"QUADROS:
                             ------------------------------
                            |  1  |      NOVO QUADRO       |
                            |------------------------------|
                            |  2  |     LISTAR QUADROS     |
                            |------------------------------|
                            |  3  |    ALTERAR QUADROS     |
                            |------------------------------|
                            |  4  |    REMOVER QUADROS     |
                            |------------------------------|
                            |  5  |     ESTATISTICAS       |
                            |------------------------------|
                            |  0  |         SAIR           |
                             ------------------------------ 
                            \nEscolha uma opção: " );

            return Convert.ToInt32(Console.ReadLine());//retorna opção

        }

        public void cadastrar()
        {
            Console.Write("\n ~ ~ ~ Cadastro de Quadros ~ ~ ~ ");
            //verificação códico
            cod[qtda] = cod[qtda - 1] + 1;

            inserirDados(qtda);//insere dados conforme indice qtda

            qtda++;//validado aqui
        }//cadastro de novos quadros
        public void inserirDados(int qtda)
        {
            Console.Clear();
            if (qtda >= 0)
            {

                Console.WriteLine("\n Código: " + cod[qtda]);

                solicitarNome(qtda);
                solicitarPintor(qtda);
                solicitarAno(qtda);
                solicitarValor(qtda);
                solicitarDescricao(qtda);

                Console.WriteLine("\nSALVO");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel salvar");
            }
        }
        private void solicitarNome(int qtda)
        {
            try
            {
                Console.WriteLine("Nome: ");
                nomeDoQuadro[qtda] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Infome um Nome Válido");
                solicitarNome(qtda);
            }

        }
        private void solicitarPintor(int qtda)
        {
            try
            {
                Console.WriteLine("Pintor: ");
                pintor[qtda] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Infome um nome válido");
                solicitarPintor(qtda);
            }
        }
        private void solicitarAno(int qtda)
        {
            try
            {
                Console.WriteLine("Ano: ");
                ano[qtda] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Infome um ano válido");
                solicitarAno(qtda);
            }
        }
        private void solicitarValor(int qtda)
        {
            try
            {
                Console.WriteLine("Valor: ");
                valorDoQuadro[qtda] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Infome um valor válido");
                solicitarValor(qtda);
            }
        }
        private void solicitarDescricao(int qtda)
        {
            try
            {
                Console.WriteLine("Descrição: ");
                descricao[qtda] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Infome uma descrição válida");
                solicitarDescricao(qtda);
            }
        }

        public void imprimirQuadros(int i)
        {
            Console.WriteLine("\nCódigo: " + cod[i] +
                              "\nNome do Quadro: " + nomeDoQuadro[i] +
                              "\nNome do Pintor: " + pintor[i] +
                              "\nAno: " + ano[i] +
                              "\nValor: " + valorDoQuadro[i] +
                              "\nDescrição: " + descricao[i] +
                              "\n");
        }

        public void listar()
        {
            Console.WriteLine("\n ~ ~ ~ Lista de Quadros ~ ~ ~ ");

            for (int j = 0; j < qtda; j++)
            {
                imprimirQuadros(j);
            }
        } //testar listar

        public void alterar()
        {
            Console.Write("\n ~ ~ ~ Alterar dados dos Quadros ~ ~ ~ ");

            Console.Write("Insira o Códico do produto a ser alterado: ");
            int newCod = Convert.ToInt32(Console.ReadLine());
            int indice = 0;
            for (int i = 0; i < qtda; i++)
            {
                if (newCod == cod[i])
                {
                    imprimirQuadros(i);
                    indice = i;
                }
            }
            Console.WriteLine("Você realmente deseja alterar? " +
                              "Sim / Não");
            string op = Console.ReadLine().ToLower();

            if (op == "sim")
            {
                inserirDados(indice);
            }


        } // testar Alteração de produtos

        public void remover()
        {
            if (qtda > 0)
            {
                int newCod = 0;
                try
                {
                    Console.Write("Digite o códico do quadro a ser removido: ");
                    newCod = Convert.ToInt32(Console.ReadLine());
                    if (newCod < 1)
                    {
                        Console.WriteLine("Infome um códico válido");
                        remover();
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Infome um códico válido");
                    remover();
                }

                for (int i = newCod; i < qtda; i++)
                {
                    cod[i] = cod[i++];
                    nomeDoQuadro[i] = nomeDoQuadro[i++];
                    pintor[i] = pintor[i++];
                    ano[i] = ano[i++];
                    valorDoQuadro[i] = valorDoQuadro[i++];
                    descricao[i] = descricao[i++];
                }

                Console.WriteLine("Quadro removido com sucesso!");
                qtda--;
            }
            else
            {
                Console.WriteLine("\nNão foi possível excluir!");
            }
           
        }

        public void estatisticas()
        {
            for (int i = 0; i < qtda; i++)
            {
                somaAnos += ano[i];

            }
            mediaAnos = somaAnos / qtda;
            Console.WriteLine("Média de anos dos quadros: " + mediaAnos);
        }
    }

}

