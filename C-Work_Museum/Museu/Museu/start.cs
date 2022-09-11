using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Museu
{
    class start
    {
        Fardas roupas = new Fardas();
        MaterialBelico armas = new MaterialBelico();
        Quadros quadros = new Quadros();
        Veiculos veiculos = new Veiculos();
        CadastroDeFuncionario cadastrofuncionarios = new CadastroDeFuncionario();
        CadastroFidelidade cadastroFidelidade = new CadastroFidelidade();

        public start()
        {
            MenuPrincipal();
        }

        public int Menu()
        {
            Console.Write(

@"                      ------------------------------------- 
                     |  1  |        Funcionários           |
                     |-------------------------------------|
                     |  2  |         Fidelidade            |
                     |-------------------------------------|
                     |  3  |           Roupas              |
                     |-------------------------------------|
                     |  4  |           Armas               |
                     |-------------------------------------|
                     |  5  |          Veiculos             |
                     |-------------------------------------|
                     |  6  |          Quadros              |
                     | ------------------------------------|
                     |  0  |          Sair                 |
                      ------------------------------------- 
                        
                      OPÇÃO: ");
            return Int32.Parse(Console.ReadLine());
        }

        public void MenuPrincipal()
        {
            int op = 0;
            do
            {
                Console.Clear();
                op = Menu();

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        cadastrofuncionarios.iniciar();
                        break;
                    case 2:
                        cadastroFidelidade.iniciar();
                        break;
                    case 3:
                        roupas.iniciar();
                        break;
                    case 4:
                        armas.iniciar();
                        break;
                    case 5:
                        veiculos.iniciar();
                        break;
                    case 6:
                        quadros.iniciar();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (op != 0);
        }
    }
}

