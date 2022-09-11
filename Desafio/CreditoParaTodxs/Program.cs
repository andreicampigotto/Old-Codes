using System;
using CreditoParaTodxs.Classes;

namespace CreditoParaTodxs
{
    class Program
    {
        static OfertadorRepositorio repositorio = new OfertadorRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "S")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarOfertas();
                        break;
                    
                    case "2":
                        InserirOfertas();
                        break;

                    case "3":
                        AtualizarOferta();
                        break;

                    case "4":
                        ExcluirOferta();
                        break;
                    
                    case "5":
                        VisualizarOferta();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por ultilizar nossos servicos.");
            Console.ReadLine();
        }

        private static void ListarOfertas(){
            Console.WriteLine("Listar Ofertas");

            var lista = repositorio.Lista();

            if(lista.Count == 0){
                Console.WriteLine("Nenhuma oferta cadastrada");
                return;
            }
            foreach(var oferta in lista){
                var excluido = oferta.retronaExcluido();
                Console.WriteLine("#ID {0}: - {1}", oferta.retornaId(), oferta.retornaOferta());
            }
        }

        public static void InserirOfertas(){
            
            foreach (int i in Enum.GetValues(typeof(Instituicao)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Instituicao), i));
            }

            Console.WriteLine("Digite o Instituicao entre as opcoes acima: ");
            int entradaInstituicao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descricao da oferta: ");
            string entradaDescricao= Console.ReadLine();

            Console.WriteLine("Digite o valor a ser disponibilizado ja contado os jutos: ");
            double entradaValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descricao da serie: ");
            double entradaTaxa = double.Parse(Console.ReadLine());

            Ofertador novaOferta = new Ofertador(id: repositorio.ProximoId(),
                                        instituicao: (Instituicao)entradaInstituicao,
                                        descricao: entradaDescricao,
                                        valor: entradaValor,
                                        taxa: entradaTaxa);

            repositorio.Insere(novaOferta);
        }

        public static void AtualizarOferta(){
            Console.WriteLine("Digite o id da oferta: ");
            int indiceOferta = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Instituicao)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Instituicao), i));
    
            }

            Console.WriteLine("Digite o Instituicao entre as opcoes acima: ");
            int entradaInstituicao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descricao da oferta: ");
            string entradaDescricao= Console.ReadLine();

            Console.WriteLine("Digite o valor a ser disponibilizado ja contado os jutos: ");
            double entradaValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descricao da serie: ");
            double entradaTaxa = double.Parse(Console.ReadLine());


            Ofertador atualizaOferta = new Ofertador(id: indiceOferta,
                                        instituicao: (Instituicao)entradaInstituicao,
                                        descricao: entradaDescricao,
                                        valor: entradaValor,
                                        taxa: entradaTaxa);

            repositorio.Atualiza(indiceOferta, atualizaOferta);
        }

        public static void ExcluirOferta(){
            Console.WriteLine("Digite o id da oferta: ");
            int indiceOferta = int.Parse(Console.ReadLine());

            repositorio.Excluir(indiceOferta);
        }


        public static void VisualizarOferta(){
            Console.WriteLine("Digite o id da oferta: ");
            int indiceOferta = int.Parse(Console.ReadLine());

            var oferta = repositorio.RetornaPorId(indiceOferta);

            Console.WriteLine("#ID {0}: - {1}", oferta, oferta.retornaOferta());
        }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("---- CreditoParaTodxs ---" );
            Console.WriteLine("Informe a opcao que deseja:");

            Console.WriteLine("1 - Listar ofetas");
            Console.WriteLine("2 - Inserir oferta");
            Console.WriteLine("3 - Atualizar oferta");
            Console.WriteLine("4 - Excluir oferta");
            Console.WriteLine("5 - Visualizar oferta");
            Console.WriteLine("C - Limpa tela");
            Console.WriteLine("S - S");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
