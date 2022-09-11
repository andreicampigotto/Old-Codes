using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    class CadastroDeFuncionario
    {
        private int[] cod;
        private String[] nome;
        private String[] sobrenome;
        private int[] idade;
        private String[] funcao;
        private String[] turno;
        private String[] setor;
        private double[] salarioByHrs;
        private double[] hrsBySemana;
        private double[] salario;
        private double[] descontos;

        int cont;

        public CadastroDeFuncionario() 
        {
            cont = 0;
            cod = new int[100];
            nome = new String[100];
            sobrenome = new String[100];
            idade = new int[100];//ou dataNascimento -> calcIdade();
            funcao = new String[100];
            turno = new String[100];
            setor = new String[100];
            salarioByHrs = new double[100];
            hrsBySemana = new double[100];
            salario = new double[100];
            descontos = new double[100];

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
                @"\nFUNCIONÁRIOS:
                              ---------------------------------------
                            |  1  |      NOVO FUNCIONÁRIO             |
                            |-----------------------------------------|
                            |  2  |      LISTAR FUNCIONÁRIOS          |
                            |-----------------------------------------|
                            |  3  |      ALTERAR FUNCIONÁRIO          |
                            |-----------------------------------------|
                            |  4  |      REMOVER FUNCIONÁRIO          |
                            |-----------------------------------------|
                            |  0  |               SAIR                |
                             ---------------------------------------- ");
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
            Console.Write("\n--- Cadastro de Funcionário ---");
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

                solicitarNome(n);
                solicitarSobrenome(n);
                solicitarIdade(n);
                solicitarFuncao(n);
                solicitarTurno(n);
                solicitarSalarioByHrs(n);
                solicitarHorasBySemana(n);
                solicitarDescontos(n);
                solicitarSetor(n);

                salario[n] = calcSalario(salarioByHrs[n], hrsBySemana[n], descontos[n]);

                Console.WriteLine("\nSalvo!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel inserir!");
            }
        }

        public void listar()
        {
            Console.WriteLine("\n--- Lista de Funcionários ---");

            for (int n = 0; n < cont; n++)
            {
                imprimirFuncionario(n);
            }
            Console.WriteLine("Folha de Pagamento: R$" + imprimirFolhaDePagamento());
            Console.WriteLine("Maior Salario: R$" + maiorSalario());
            Console.WriteLine("Media de Salarios: R$" + mediaDeSalarios(cont));
        }

        public void alterar()
        {
            Console.WriteLine("\n--- Alterar dados do Funcionários ---");
            inserirDados(buscarFuncionario());
        }

        public void remover()
        {
            int buscado = buscarFuncionario();
            if (buscado >= 0)
            {
                for (int i = buscado; i < cont; i++)
                {
                    cod[i] = cod[i + 1];
                    nome[i] = nome[i + 1];
                    sobrenome[i] = sobrenome[i + 1];
                    idade[i] = idade[i + 1];
                    funcao[i] = funcao[i + 1];
                    turno[i] = turno[i + 1];
                    setor[i] = setor[i + 1];
                    salarioByHrs[i] = salarioByHrs[i + 1];
                    hrsBySemana[i] = hrsBySemana[i + 1];
                    salario[i] = salario[i + 1];
                    descontos[i] = descontos[i + 1];
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
        public void imprimirFuncionario(int i)
        {
            Console.WriteLine(string.Format("-Código:   {0}\nNome:    {1} Sobrenome: {2}\nIdade:   {3}\nFunção:  {4} Turno: {5} Setor: {6}", cod[i], nome[i], sobrenome[i], idade[i], funcao[i], turno[i], setor[i]));
            Console.WriteLine("--- Salário ---");
            //Console.WriteLine(string.Format("Salário por hora: R$   {0} Horas por semana:   {1} Descontos:   {2} Salário Líquido:   {3}", salarioByHrs[i], hrsBySemana[i], descontos[i], salario[i]));
            Console.WriteLine(string.Format("Salário por hora: R$   {0}\nHoras por semana:   {1}\nDescontos:   {2}\nSalário Líquido:   {3}", salarioByHrs[i], hrsBySemana[i], descontos[i], salario[i]));
            Console.WriteLine("\n.");
        }

        public int buscarFuncionario()
        {
            int op = 0, buscado = -1;

            Console.Write("\n--- Buscar Funcionário ---\n");
            Console.Write("\n1- Buscar por Códiogo");
            Console.Write("\n2- Buscar por Nome");
            Console.Write("\n3- Buscar por Setor");
            Console.Write("\n0- Cancelar");
            Console.Write("\nOpção: ");
            op = Convert.ToInt32(Console.ReadLine());

            if (op != 1 && op != 2 && op != 3)
                Console.WriteLine("\nSaindo...");
            else 
                buscado = buscarBy(op);

            return buscado;
        }

        public int buscarBy(int op)
        {
            int indice = -1, codF = 0;
            String nomeF, setorF;

            if (op == 2)
            {
                Console.Write("\nInforme o Nome do Funcionário: ");
                nomeF = Console.ReadLine();
                for (int i = 0; i < cont; i++)
                {
                    if (nomeF.Equals(nome[i]))
                    {
                        imprimirFuncionario(i);
                    }
                }
            }
            else if (op == 3)
            {
                Console.Write("\nInforme o Setor do Funcionário: ");
                setorF = Console.ReadLine();
                for (int i = 0; i < cont; i++)
                {
                    if (setorF.Equals(setor[i]))
                    {
                        imprimirFuncionario(i);
                    }
                }
            }
            Console.Write("\nInforme o código do Funcionário: ");
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


        //Cálculos
        public double calcSalario(double salarioByHoras, double hrsBySemana, double descontos)
        {
            if (cont > 0)
            {
                try
                {
                    return salarioByHoras * (hrsBySemana * 5) - descontos;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nDados de Salario inválidos");
                }
            }
            return -1;
        }

        public double imprimirFolhaDePagamento()
        {
            double total = 0;
            if (cont > 0)
            {
                for (int i = 0; i < cont; i++)
                {
                    total += salario[i];
                }
            }
            return total;
        }

        public double maiorSalario()
        {
            double maiorSalario = salario[0];
            if (cont > 0)
            {
                for (int n = 0; n < cont; n++)
                {
                    if (maiorSalario < salario[n])
                    {
                        maiorSalario = salario[n];
                    }
                }
            }

            return maiorSalario;
        }

        public double mediaDeSalarios(int n)
        {
            double somaSalarios = 0;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    somaSalarios += salario[i];
                }
                return somaSalarios / n;
            }
            return 0;
        }


        //Solicitando Dados
        private void solicitarSetor(int n)
        {           
            Console.Write("\nSetor: ");
            setor[n] = Console.ReadLine();

            if (string.IsNullOrEmpty(setor[n]) || setor[n].Count() < 2)
            {
                Console.WriteLine("Dados inválidos!");
                solicitarSetor(n);
            }
        }

        private void solicitarDescontos(int n)
        {
            try
            {
                Console.Write("\nDescontos: R$");
                descontos[n] = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarDescontos(n);
            }
        }

        private void solicitarHorasBySemana(int n)
        {
            try
            {
                Console.Write("\nHoras trabalhadas(semana): ");
                hrsBySemana[n] = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarHorasBySemana(n);
            }
        }

        private void solicitarSalarioByHrs(int n)
        {
            try
            {
                Console.Write("\nSalario(hora): R$");
                salarioByHrs[n] = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarSalarioByHrs(n);
            }
        }

        private void solicitarTurno(int n)
        {
            Console.Write("\nTurno: ");
            turno[n] = Console.ReadLine();

            if (string.IsNullOrEmpty(turno[n]) || turno[n].Count() < 2)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarTurno(n);
            }
        }

        private void solicitarFuncao(int n)
        {

            Console.Write("\nFunção: ");
            funcao[n] = Console.ReadLine();

            if (string.IsNullOrEmpty(funcao[n]) || funcao[n].Count() < 2)
            {
                Console.WriteLine("\nDados inválidos!");
                solicitarFuncao(n);
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
    }
}
