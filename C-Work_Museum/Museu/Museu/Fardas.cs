using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    public class Fardas
    {
        string[] nomeCabecaFarda = new string[150];
        string[] nomeFarda= new string[150];
        string[] graduacaoFarda = new string[150];
        string[] descricao = new string[150];
        int[] ano = new int[150];
        int[] cod = new int[150];
        int qtda = 0;
        int somaAnos = 0;
        double mediaAnos = 0;

        public Fardas()
        {
            nomeFarda[qtda] = "Túnica Verde-Oliva";
            nomeCabecaFarda[qtda] = "Quepe oficial";
            graduacaoFarda[qtda] = "Oficial";
            ano[qtda] = 1960;
            descricao[qtda] = "Usada em Eventos";
            cod[qtda]++;
            qtda++;

            nomeFarda[qtda] = "Fraque Exercito Brasileiro";
            nomeCabecaFarda[qtda] = "Quepe de Gala";
            graduacaoFarda[qtda] = "Sargento";
            descricao[qtda] = "Usada em casamentos militares";
            ano[qtda] = 1888;
            cod[qtda]++;
            qtda++;

            nomeFarda[qtda] = "Jacketa de um Oficial Panzer";
            nomeCabecaFarda[qtda] = "Quepe Oficial Panzer";
            graduacaoFarda[qtda] = "Ofial Panzer";
            descricao[qtda] = "Usada pelos oficiais Panzers na II guerra mundial";
            ano[qtda] = 1938;
            cod[qtda]++;
            qtda++;
           
        } // vetor alimentado

        public void iniciar()
        {
            int op = 0;
            Console.Clear();
           do
            {
                try
                {
                    Console.Clear();
                    op = Menu();
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

        public int Menu()
        {
            Console.WriteLine(
                            @"QUADROS:
                              -----------------------------
                            |  1  |       NOVA FARDA       |
                            |------------------------------|
                            |  2  |      LISTAR FARDA      |
                            |------------------------------|
                            |  3  |     ALTERAR FARDA      |
                            |------------------------------|
                            |  4  |     REMOVER FARDA      |
                            |------------------------------|
                            |  5  |     ESTATISTICAS       |
                            |------------------------------|
                            |  0  |         SAIR           |
                             -----------------------------   
                            \nEscolha uma opção: ");

         return Convert.ToInt32(Console.ReadLine());//retorna opçã
        }

        public void cadastrar()
        {
            Console.Write("\n ~ ~ ~ Cadastro de Fardas ~ ~ ~ ");
            //verificação códico
            cod[qtda] = cod[qtda - 1] + 1;

            inserirDados(qtda);//insere dados conforme indice qtda

            qtda++;//validado aqui
        }
        public void inserirDados(int qtda)
        {
            Console.Clear();
            if (qtda >= 0)
            {

                Console.WriteLine("\n- Código: " + cod[qtda]);

                solicitarFarda(qtda);
                solicitarBoina(qtda);
                solicitarGraduacaoFarda(qtda);
                solicitarAno(qtda);
                solicitarDescricao(qtda);

                Console.WriteLine("\nSALVO");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel salvar");
            }
        }
        private void solicitarFarda(int qtda)
        {
            try
            {
                Console.WriteLine("Nome: ");
                nomeFarda[qtda] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Infome um Nome Válido");
                solicitarFarda(qtda);
            }

        }
        private void solicitarBoina(int qtda)
        {
            try
            {
                Console.WriteLine("Nome da boina: ");
                nomeCabecaFarda[qtda] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Infome um nome válido");
                solicitarBoina(qtda);
            }
        }
        private void solicitarGraduacaoFarda(int qtda)
        {
            try
            {
                Console.WriteLine("Graduação da farda: ");
                graduacaoFarda[qtda] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Infome uma graduação válida");
                solicitarGraduacaoFarda(qtda);
            }
        }
        private void solicitarAno(int qtda)
        {
            try
            {
                Console.WriteLine("ano: ");
                ano[qtda] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Infome um ano válida");
                solicitarAno(qtda);
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

        public void imprimirFardas(int i)
        {
            Console.WriteLine("\nCódigo: " + cod[i] +
                              "\nNome do Farda: " + nomeFarda[i] +
                              "\nNome do Boina: " + nomeCabecaFarda[i] +
                              "\nAno: " + ano[i] +
                              "\nGraduação: " + graduacaoFarda[i] +
                              "\nDescrição: " + descricao[i] +
                              "\n");
        }//testar

        public void listar()
        {
            Console.WriteLine("\n ~ ~ ~ Lista de Fardas ~ ~ ~ ");

            for (int j = 0; j < qtda; j++)
            {
                imprimirFardas(j);
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
                    imprimirFardas(i);
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
                    Console.Write("Digite o códico da farda a ser removida: ");
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
                    nomeFarda[i] = nomeFarda[i++];
                    nomeCabecaFarda[i] = nomeCabecaFarda[i++];
                    ano[i] = ano[i++];
                    graduacaoFarda[i] = graduacaoFarda[i++];
                    descricao[i] = descricao[i++];
                }

                Console.WriteLine("Farda removida com sucesso!");
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
