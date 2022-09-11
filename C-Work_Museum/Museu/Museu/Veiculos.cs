using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    class Veiculos
    {
        //Armas, munições, granadas, facas, baionetas
        //variaveis tipo private = são utilizadas apenas aqui
        private int[] cod;
        private String[] nome;
        private String[] categoria;
        private String[] descricao;
        private int[] quantidade;

        int cont;

        public Veiculos()//Método construtor inicializando variáveis
        {
            cont = 0;
            cod = new int[100];
            nome = new String[100];
            descricao = new String[100];
            categoria = new String[100];
            quantidade = new int[100];
        }

        //método que inicializa o menu() de opçoes para o gerenciamento de materiais belicos
        public void iniciar()
        {
            int op = 0;
            Console.Clear();
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
                }catch(Exception e){
                    Console.WriteLine("Erro.: "+e.ToString());
                }
                Console.ReadKey();
            } while (op != 0);
        }

        public int menu()
        {
            Console.Write(
                   @" -------------------------------------
                     |  1  |  NOVO CADASTRO DE VEICULOS    |
                     |-------------------------------------|
                     |  2  |      LISTAR VEICULOS          |
                     |-------------------------------------|
                     |  3  |      EDITAR VEICULOS          |
                     |-------------------------------------|
                     |  4  |      REMOVER VEICULOS         |
                     |-------------------------------------|
                     |  0  |            SAIR               |
                      -------------------------------------     
                      \nOPÇÃO: ");






            return Convert.ToInt32(Console.ReadLine());//retorna opção

        }

        public void cadastrar()
        {
            Console.Write("\n--- Cadastro de veículos ---");
            //Tipo um IDENTITY
            if (cont == 0) cod[cont] = cont + 1;
            else cod[cont] = cod[cont - 1] + 1;

            inserirDados(cont);//insere dados conforme indice cont

            cont++;
        }

        public void inserirDados(int n)
        {
            if (n >= 0)
            {

                Console.WriteLine("\n- Código: " + cod[n]);
                
                Console.Write("\nNome veículo: ");
                nome[n] = Console.ReadLine();

                Console.Write("\nDescrição do veículo: ");
                descricao[n] = Console.ReadLine();

                Console.Write("\nCategoria do veículo: ");
                categoria[n] = Console.ReadLine();

                Console.Write("\nQuantidade de veículos: ");
                quantidade[n] = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("\n- Código: " + cod[n]);


                    solicitarNome(n);
                    solicitarDescricao(n);
                    solicitarCategoria(n);
                    solicitarQuantidade(n);

                    Console.Clear();
                }
                while (nome[n] == "");
                {
                    Console.WriteLine("\nSalvo!");

                }
            

            }
            else
            {
                Console.WriteLine("\nNão foi possivel inserir!");
            }
            
        }

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

        private void solicitarCategoria(int n)
        {
            try
            {
                Console.WriteLine("Categoria: ");
                categoria[n] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Infome uma Categoria válida");
                solicitarCategoria(n);
            }
        }

        private void solicitarDescricao(int n)
        {
            try
            {
                Console.WriteLine("Descrição: ");
                descricao[n] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Infome uma Descrição válida");
                solicitarDescricao(n);
            }
        }

        private void solicitarNome(int n)
        {
            try
            {
                Console.WriteLine("Nome do veículo: ");
                nome[n] = Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("Infome um nome Válido");
                solicitarNome(n);
            }
        }

        public void listar()
        {
            Console.WriteLine("\n--- Listar veículos ---");

            Console.WriteLine("\nTotal de veículos: " + totalDeVeiculos());//Soma quantidade de materiais belicos
            for (int n = 0; n < cont; n++)
            {
                imprimirVeiculos(n);
            }
        }

        public void imprimirVeiculos(int i)
        {
            Console.WriteLine("Código: " + cod[i]);
            Console.WriteLine("Nome do veículo: " + nome[i]);
            Console.WriteLine("Descrição: " + descricao[i]);
            Console.WriteLine("Categoria: " + categoria[i]);
            Console.WriteLine("Quantidade: " + quantidade[i]);
            Console.WriteLine("\n--\n");
        }

        public void alterar()
        {
            Console.WriteLine("\n--- Editar veículos ---");
            inserirDados(buscarVeiculos());//retorna índice do material belico. buscado
        }

        public int buscarVeiculos()
        {
            int op = 0, buscado = -1;

            Console.Write("\n--- Buscar veículos ---\n");
            Console.Write("\n1- Buscar por Códiogo");
            Console.Write("\n2- Buscar por Nome");
            Console.Write("\n2- Buscar por Categoria");
            Console.Write("\n0- Cancelar");
            Console.Write("\nOpção: ");
            op = Int32.Parse(Console.ReadLine());

            if (op != 1 && op != 2 && op != 3) Console.WriteLine("\nSaindo...");
            else buscado = buscarBy(op);//busca por opção

            return buscado;
        }

        //Busca por opção e retorna indice do materiai belico buscado
        public int buscarBy(int op)
        {
            int indice = -1, codMB = 0;
            String nomeMB, categoriaMB;

            if (op == 2)
            {
                Console.Write("\nInforme o nome do veículo: ");
                nomeMB = Console.ReadLine();
                for (int i = 0; i < cont; i++)
                {
                    if (nomeMB.Equals(nome[i]))
                    {
                        imprimirVeiculos(i);
                    }
                }
            }
            else if (op == 3)
            {
                Console.Write("\nInforme a categoria do veículo: ");
                categoriaMB = Console.ReadLine();
                for (int i = 0; i < cont; i++)
                {
                    if (categoriaMB.Equals(categoria[i]))
                    {
                        imprimirVeiculos(i);
                    }
                }
            }
            Console.Write("\nInforme o número de cadastro do veículo: ");
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

        public int totalDeVeiculos()
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

        public void remover()
        {
            //O índice removido da espaço ao seu sucessor, e assim sucessivamente. Ao final, decrementa contador de cadastros.
            int buscado = buscarVeiculos();
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
    }
}
