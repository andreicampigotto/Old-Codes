using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSolicitacaoInformacao
{
    class Exemplo04
    {
        public Exemplo04()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();
            string nomeCompleto = nome + " " + sobrenome;

            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Infome seu Salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Você está vivo? ");
            bool vivo = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Informe seu sexo: ");
            char sexo = Console.ReadLine()[0];
            

            Console.Clear();
            Console.WriteLine(
                "Seu nome é: " + nomeCompleto + 
                "\nSua idade é: " + idade + 
                "\nSeu salário é: " + salario + 
                "\nO usuario está vivo: " + vivo +
                "\nO seu sexo é: " + sexo

            );
        }
    }
}
