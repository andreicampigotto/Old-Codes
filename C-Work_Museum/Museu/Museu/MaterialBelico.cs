using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Museu
{
    class MaterialBelico
    {
        //Armas, munições, granadas, facas, baionetas
        //variaveis tipo private = são utilizadas apenas aqui
        private int[] cod;
        private String[] nome;
        private String[] categoria;
        private String[] descricao;
        private int[] quantidade;
        private int[] ano;

        int cont;

        public MaterialBelico()//Método construtor inicializando variáveis
        {
            cont = 0;
            cod = new int[100];
            nome = new String[100];
            descricao = new String[100];
            categoria = new String[100];
            quantidade = new int[100];
            ano = new int[100];
        }

        //método que inicializa o menu() de opçoes para o gerenciamento de materiais belicos
        public void iniciar()
        {
            int op = 0;
            do
            {
                try
                {
                    Console.Clear();
                    op = menu();//munu de opções
                    switch (op)
                    {
                        case 0:
                            Console.WriteLine("\nSaindo...");
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
                            @"MATERIAIS BELICOS:
                             -----------------------------------------
                            |  1  |      NOVO MATERIAL BELICO         |
                            |-----------------------------------------|
                            |  2  |      LISTAR MATERIAIS BELICOS     |
                            |-----------------------------------------|
                            |  3  |      ALTER MATERIAIS BELICOS      |
                            |-----------------------------------------|
                            |  4  |      REMOVER MATERIAIS BELICOS    |
                            |-----------------------------------------|
                            |  0  |               SAIR                |
                             ----------------------------------------- ");
            Console.Write("\nOpção: ");

            return solicitarOpcao();
            //retorna opção
        }

        //Operações
        private int solicitarOpcao()
        {
            int op = 0;
            try
            {
                op = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("\nOpção inválida!");
                solicitarOpcao();
            }
            return op;
        }
        public void cadastrar()
        {
            Console.Write("\n--- Cadastro de Material Bélico ---");
            //Tipo um IDENTITY
            if (cont == 0) cod[cont] = cont + 1;
            else cod[cont] = cod[cont - 1] + 1;

            inserirDados(cont);//insere dados conforme indice cont

            cont++;
        }
        public void inserirDados(int n)
        {
            if (n >= 0 && n < 100)
            {

                Console.WriteLine("\n- Código: " + cod[n]);

                solicitarNome(n);
                solicitarDescricao(n);
                solicitarCategoria(n);
                solicitarAnoAquisicao(n);
                solicitarQuantidade(n);

                Console.WriteLine("\nSalvo!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel inserir!");
            }
        }

        public void listar()
        {
            Console.WriteLine("\n--- Lista de Materias Bélicos ---");

            for (int n = 0; n < cont; n++)
            {
                imprimirMaterialBelico(n);
            }
            Console.WriteLine("\nTotal de Materiais Bélicos: " + totalDeMateriaisBelicos());//Soma quantidade de materiais belicos            
            Console.WriteLine("\nMédia de anos dos Materiais Bélicos: " + mediaAnoAquisicao(cont));
        }

        public void alterar()
        {
            Console.WriteLine("\n--- Alterar dados do Material Bélico ---");
            inserirDados(buscarMaterialBelico());//retorna índice do material belico. buscado
        }

        public void remover()
        {
            //O índice removido da espaço ao seu sucessor, e assim sucessivamente. Ao final, decrementa contador de cadastros.
            int buscado = buscarMaterialBelico();
            if (buscado >= 0)
            {
                for (int i = buscado; i < cont; i++)
                {
                    cod[i] = cod[i + 1];
                    nome[i] = nome[i + 1];
                    descricao[i] = descricao[i + 1];
                    categoria[i] = categoria[i + 1];
                    quantidade[i] = quantidade[i + 1];
                }
                Console.WriteLine("\nRemovido!");
                cont--;
            }
            else
            {
                Console.WriteLine("\nNão foi possível excluir!");
            }
        }

        //Buscas e Impressões
        public void imprimirMaterialBelico(int i)
        {
            Console.WriteLine("- Código: " + cod[i]);
            Console.WriteLine("Nome: " + nome[i]);
            Console.WriteLine("Descrição: " + descricao[i]);
            Console.WriteLine("Categoria: " + categoria[i]);
            Console.WriteLine("Ano de aquisição: " + ano[i]);
            Console.WriteLine("Quantidade: " + quantidade[i]);
            Console.WriteLine("\n--\n");
        }

        public int buscarMaterialBelico()
        {
            int op = 0, buscado = -1;

            Console.Write("\n--- Buscar Material Belico ---\n");
            Console.Write("\n1- Buscar por Códiogo");
            Console.Write("\n2- Buscar por Nome");
            Console.Write("\n2- Buscar por Categoria");
            Console.Write("\n0- Cancelar");
            Console.Write("\nOpção: ");

            op = solicitarOpcao();

            if (op != 1 && op != 2 && op != 3)
                Console.WriteLine("\nSaindo...");
            else
                buscado = buscarBy(op);//busca por opção

            return buscado;
        }
        public int buscarBy(int op)
        {
            int indice = -1, codMB = 0;
            String nomeMB, categoriaMB;

            if (op == 2)
            {
                Console.Write("\nInforme o Nome do Material Bélico: ");
                nomeMB = Console.ReadLine();
                for (int i = 0; i < cont; i++)
                {
                    if (nomeMB.Equals(nome[i]))
                    {
                        imprimirMaterialBelico(i);
                    }
                }
            }
            else if (op == 3)
            {
                Console.Write("\nInforme a Categoria do Material Bélico: ");
                categoriaMB = Console.ReadLine();
                for (int i = 0; i < cont; i++)
                {
                    if (categoriaMB.Equals(categoria[i]))
                    {
                        imprimirMaterialBelico(i);
                    }
                }
            }
            Console.Write("\nInforme o código do Material Bélico: ");
            codMB = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cont; i++)
            {
                if (cod[i] == codMB)
                {
                    indice = i;
                }
            }

            return indice;
        }

        //Cálculos
        public int totalDeMateriaisBelicos()
        {
            int total = 0;
            if (cont > 0)
            {
                for (int i = 0; i < cont; i++)
                {
                    total += quantidade[i];
                }
            }
            return total;
        }

        public double mediaAnoAquisicao(int n)
        {
            double somaAnos = 0;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    somaAnos += ano[i];
                }
                return somaAnos / n;
            }
            return 0;
        }

        //Inserindo Dados
        private void solicitarQuantidade(int n)
        {
            try
            {
                Console.WriteLine("Quantidade: ");
                quantidade[n] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Infome uma Quantidade válida");
                solicitarQuantidade(n);
            }
        }

        private void solicitarAnoAquisicao(int n)
        {
            try
            {
                Console.WriteLine("Ano de aquisição: ");
                ano[n] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Infome uma Quantidade válida");
                solicitarAnoAquisicao(n);
            }
        }

        private void solicitarCategoria(int n)
        {
            Console.WriteLine("Categoria: ");
            categoria[n] = Console.ReadLine();

            if (string.IsNullOrEmpty(categoria[n]) || categoria[n].Count() < 2)
            {
                Console.WriteLine("Infome uma Categoria válida");
                solicitarCategoria(n);
            }
        }

        private void solicitarDescricao(int n)
        {
            Console.WriteLine("Descrição: ");
            descricao[n] = Console.ReadLine();

            if (string.IsNullOrEmpty(descricao[n]) || descricao[n].Count() < 2)
            {
                Console.WriteLine("Infome uma Descrição válida");
                solicitarDescricao(n);
            }
        }

        private void solicitarNome(int n)
        {

            Console.WriteLine("Nome: ");
            nome[n] = Console.ReadLine();

            if (string.IsNullOrEmpty(nome[n]) || nome[n].Count() < 2)
            {
                Console.WriteLine("Infome um Nome!");
                solicitarNome(n);
            }
        }
    }
}
