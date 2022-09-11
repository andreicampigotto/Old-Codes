using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    class CadastroFidelidade
    {
        private int[] cod;
        private double[] cpf; //salario
        private String[] nome;
        private String[] sobrenome;
        private int[] idade;
        private String[] nacionalidade; //funcao
        private String[] profissao; //turno
        private String[] sexo; //setor
        private int[] quantidadeDeVisitas;  //salarioByHrs
        private double[] quantidadeGastosNoMuseu;   //hrsBySemana
        private double[] telefoneContato; // descontos

        int cont;

        public CadastroFidelidade()
        {
            cont = 0;
            cod = new int[100];
            cpf = new double[100];
            nome = new String[100];
            sobrenome = new String[100];
            idade = new int[100];//ou dataNascimento -> calcIdade();
            nacionalidade = new String[100];
            profissao = new String[100];
            sexo = new String[100];
            quantidadeDeVisitas = new int[100];
            quantidadeGastosNoMuseu = new double[100];
            telefoneContato = new double[100];

            //cadastrar();
        }
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
                @"\nFidelidade:
                            -------------------------------------------
                            |  1  |          NOVO CLIENTE             |
                            |-----------------------------------------|
                            |  2  |        LISTAR CLIENTES            |
                            |-----------------------------------------|
                            |  3  |        EDITAR CLIENTES            |
                            |-----------------------------------------|
                            |  4  |      REMOVER CLIENTES             |
                            |-----------------------------------------|
                            |  0  |               SAIR                |
                            ------------------------------------------- ");
            Console.Write("\nOpção: ");

            return solicitarOpcao();
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
            Console.Write("\n--- Cadastro de Clientes ---");
            if (cont == 0) cod[cont] = cont + 1;
            else cod[cont] = cod[cont - 1] + 1;

            inserirDados(cont);

            cont++;
        }
        public void inserirDados(int n)
        {
            if (n >= 0 && n < 100)
            {
                Console.WriteLine("\n- Código: " + cod[n]);

                solicitarCpf(n);
                solicitarNome(n);
                solicitarSobrenome(n);
                solicitarIdade(n);
                solicitarNacionalidade(n);
                solicitarProfissao(n);
                solicitarSexo(n);
                solicitarQuantidadeDeVisitas(n);
                solicitarQuantidadeGastosNoMuseu(n);
                solicitarTelefoneContato(n);


                Console.WriteLine("\nSalvo!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel inserir!");
            }
        }

        private void solicitarTelefoneContato(int n)
        {
            try
            {
                Console.Write("\nTelefone para Contato:");
                telefoneContato[n] = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarTelefoneContato(n);
            }
        }

        private void solicitarQuantidadeGastosNoMuseu(int n)
        {
            try
            {
                Console.Write("\nQuantidade gastos no museu");
                quantidadeGastosNoMuseu[n] = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarQuantidadeGastosNoMuseu(n);
            }
        }

        private void solicitarQuantidadeDeVisitas(int n)
        {
            try
            {
                Console.Write("\nQuantidade de visitas:");
                quantidadeDeVisitas[n] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarQuantidadeDeVisitas(n);
            }
        }

        private void solicitarSexo(int n)
        {
            Console.Write("\nSexo: ");
            sexo[n] = Console.ReadLine();

            if (string.IsNullOrEmpty(sexo[n]) || sexo[n].Count() < 2)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarSexo(n);
            }
        }

        private void solicitarProfissao(int n)
        {
            Console.Write("\nTurno: ");
            profissao[n] = Console.ReadLine();

            if (string.IsNullOrEmpty(profissao[n]) || profissao[n].Count() < 2)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarProfissao(n);
            }
        }

        private void solicitarNacionalidade(int n)
        {
            Console.Write("\nNacionalidade: ");
            nacionalidade[n] = Console.ReadLine();

            if (string.IsNullOrEmpty(nacionalidade[n]) || nacionalidade[n].Count() < 2)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarNacionalidade(n);
            }
        }

        private void solicitarIdade(int n)
        {
            try
            {
                Console.Write("\nIdade: ");
                idade[n] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarIdade(n);
            }
        }

        private void solicitarSobrenome(int n)
        {
            Console.Write("\nSobrenome: ");
            sobrenome[n] = Console.ReadLine();

            if (string.IsNullOrEmpty(sobrenome[n]) || sobrenome[n].Count() < 2)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarSobrenome(n);
            }
        }

        private void solicitarNome(int n)
        {
            Console.Write("\nNome: ");
            nome[n] = Console.ReadLine();

            if (string.IsNullOrEmpty(nome[n]) || nome[n].Count() < 2)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarNome(n);
            }
        }

        public void listar()
        {
            Console.WriteLine("\n--- Lista de clientes ---");

            for (int n = 0; n < cont; n++)
            {
                imprimirCliente(n);
            }
            Console.WriteLine("Média das visitas: " + imprimirMediaVisita());
            Console.WriteLine("Total de visitas:" + imprimirTotalVisitas() +
                "\nTotal de gastos clientes: " + imprimirGastosClientes() +
                "\nMédia de gastos por cliente: " + imprimirMediaDeGastos());

        }

        private double imprimirMediaDeGastos()
        {

            double somaMediaGastos = 0;
            for (int i = 0; i < cont; i++)
            {
                somaMediaGastos += quantidadeGastosNoMuseu[i];
            }
            double media = somaMediaGastos / cont;
            return media;
        }

        private double imprimirGastosClientes()
        {
            double somaGastos = 0;
            for (int i = 0; i < cont; i++)
            {
                somaGastos += quantidadeGastosNoMuseu[i];
            }
            return somaGastos;
        }

        private int imprimirTotalVisitas()
        {
            int somaTotal = 0;
            for (int i = 0; i < cont; i++)
            {
                somaTotal += quantidadeDeVisitas[i];
            }
            return somaTotal;
        }

        private int imprimirMediaVisita()
        {
            int somaVisitas = 0;
            for (int i = 0; i < cont; i++)
            {
                somaVisitas += quantidadeDeVisitas[i];
            }
            return somaVisitas / cont;
        }
        public void alterar()
        {
            Console.WriteLine("\n--- Editar dados do cliente ---");
            inserirDados(buscarCliente());
        }

        private int buscarCliente()
        {
            int codC = 0, indice = 0;
            Console.Write("\nInforme o código do cliente: ");
            codC = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cont; i++)
            {
                if (codC.Equals(cod[i]))
                {
                    imprimirCliente(i);
                    indice = i;
                }
            }
            return indice;
        }
        public void remover()
        {
            int buscado = buscarCliente();
            if (buscado >= 0)
            {
                for (int i = buscado; i < cont; i++)
                {
                    cod[i] = cod[i + 1];
                    cpf[i] = cpf[i + 1];
                    nome[i] = nome[i + 1];
                    sobrenome[i] = sobrenome[i + 1];
                    idade[i] = idade[i + 1];
                    nacionalidade[i] = nacionalidade[i + 1];
                    profissao[i] = profissao[i + 1];
                    sexo[i] = sexo[i + 1];
                    quantidadeDeVisitas[i] = quantidadeDeVisitas[i + 1];
                    quantidadeGastosNoMuseu[i] = quantidadeGastosNoMuseu[i + 1];
                    telefoneContato[i] = telefoneContato[i + 1];
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
        public void imprimirCliente(int i)
        {
            Console.WriteLine(string.Format("-Código:   {0}\nNome:    {1} Sobrenome: {2}\nIdade:   {3}\nNacionalidade:  {4}\nProfissão: {5} Sexo: {6}\nQuantidade de visitas: {7}\nQuantidade Gastos no museu: {8}\nTelefone para contato:  {9}", cod[i], nome[i], sobrenome[i], idade[i], nacionalidade[i], profissao[i], sexo[i], quantidadeDeVisitas[i], quantidadeGastosNoMuseu[i], telefoneContato[i]));

        }
        public int buscarFuncionario()
        {
            int op = 0, buscado = -1;

            Console.Write("\n--- Buscar cliente ---\n" +
                          "\n1- Buscar por Códiogo" +
                          "\n2- Buscar por nome" +
                          "\n3- Buscar por sobrenome" +
                          "\n0- Cancelar" +
                          "\nOpção: ");
            op = Convert.ToInt32(Console.ReadLine());

            if (op != 1 && op != 2 && op != 3) Console.WriteLine("\nSaindo...");
            else buscado = buscarBy(op);

            return buscado;
        }

        public int buscarBy(int op)
        {
            int indice = -1, codF = 0;
            String nomeF, sobrenomeF;

            if (op == 2)
            {
                Console.Write("\nInforme o nome do cliente: ");
                nomeF = Console.ReadLine();
                for (int i = 0; i < cont; i++)
                {
                    if (nomeF.Equals(nome[i]))
                    {
                        imprimirCliente(i);
                    }
                }
            }
            else if (op == 3)
            {
                Console.Write("\nInforme o sobrenome do cliente: ");
                sobrenomeF = Console.ReadLine();
                for (int i = 0; i < cont; i++)
                {
                    if (sobrenomeF.Equals(sobrenome[i]))
                    {
                        imprimirCliente(i);
                    }
                }
            }
            Console.Write("\nInforme o código do cliente: ");
            codF = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cont; i++)
            {
                if (cod[i] == codF)
                {
                    indice = i;
                }
            }

            return indice;
        }

        private void solicitarCpf(int n)
        {
            try
            {
                Console.Write("\nInforme o cpf do cliente: ");
                cpf[n] = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Dados Inválidos!");
                solicitarCpf(n);
            }
        }
    }
}


