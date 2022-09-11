using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio06
    {
        public Exercicio06()
        {
            int opcao = 0;
            int bolos = 0;
            int doces = 0;
            int sanduiches = 0;
            int pizzas = 0;
            int produtos = 0;
            double somaTotal = 0; 
          
            Console.WriteLine(
@" CARDÁPIO PADARIA DO JOÃO 
 --------------------------------------------------------------------
| CÓDIGO |    TIPO    |               NOME                |  VALOR   |
|--------------------------------------------------------------------|
|    1   |    BOLOS   | BOLO BRIGADEIRO                   |R$  29,50 |
|--------------------------------------------------------------------|
|    2   |    BOLOS   | BOLO FLORESTA NEGRA               |R$   2,00 |
|--------------------------------------------------------------------|
|    3   |    BOLOS   | BOLO LEITE COM NUTELLA            |R$  29,23 |
|--------------------------------------------------------------------|
|    4   |    BOLOS   | BOLO MOUSSE DE CHOCOLATE          |R$   7,10 |
|--------------------------------------------------------------------|
|    5   |    BOLOS   | BOLO NEGA MALUCA                  |R$  19,33 |
|--------------------------------------------------------------------|
|    6   |    DOCES   | BOMBA CREME                       |R$  17,71 |
|--------------------------------------------------------------------|
|    7   |    DOCES   | BOMBA MORANGO                     |R$   4,82 |
|--------------------------------------------------------------------|
|    8   | SANDUÍCHES | FILÉ-MINGNON COM FRITAS E CHEDDAR |R$  21,16 |
|--------------------------------------------------------------------|
|    9   | SANDUÍCHES | HAMBURGUER COM QUEIJOS,           |R$  12,70 |
|        |            | CHAMPIGNON E RÚCULA                          |
|--------------------------------------------------------------------|
|   10   | SANDUÍCHES | PROVOLONE COM SALAME              |R$  19,70 |
|--------------------------------------------------------------------|
|   11   | SANDUÍCHES | VEGETARIANO DE BERINGELA          |R$  28,22 |
|--------------------------------------------------------------------|
|   12   |   PIZZAS   | CALABRESA                         |R$   8,98 |
|--------------------------------------------------------------------|
|   13   |   PIZZAS   | NAPOLITANA                        |R$   0,42 |
|--------------------------------------------------------------------|
|   14   |   PIZZAS   | PERUANA                           |R$  18,36 |
|--------------------------------------------------------------------|
|   15   |   PIZZAS   | PORTUGUESA                        |R$  27,50 |
|--------------------------------------------------------------------|
|   16                |                  SAIR                        |
 --------------------------------------------------------------------
");
            Console.Write("Escolha uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != 16)
            {

                  produtos = produtos +1;
                
                if (opcao == 1)
                {
                    bolos = bolos + 1;
                    somaTotal = somaTotal + 29.50;
                  
                }
                else if (opcao == 2)
                {
                    bolos = bolos + 1;
                    somaTotal = somaTotal + 2.00; 
                }
                else if (opcao == 3)
                {
                    bolos = bolos + 1;
                    somaTotal = somaTotal + 29.23;
                }
                else if (opcao == 4)
                {
                    bolos = bolos + 1;
                    somaTotal = somaTotal + 7.10;
                }
                else if (opcao == 5)
                {
                    bolos = bolos + 1;
                    somaTotal = somaTotal + 19.33;
                }
                else if (opcao == 6)
                {
                    doces = doces + 1;
                    somaTotal = somaTotal + 17.71;
                }
                else if (opcao == 7)
                {
                    doces = doces + 1;
                    somaTotal = somaTotal + 4.82;
                }
                else if (opcao == 8)
                {
                    sanduiches = sanduiches + 1;
                    somaTotal = somaTotal + 21.16;
                }
                else if (opcao == 9)
                {
                    sanduiches = sanduiches + 1;
                    somaTotal = somaTotal + 12.70;
                }
                else if (opcao == 10)
                {
                    sanduiches = sanduiches + 1;
                    somaTotal = somaTotal + 19.70;
                }
                else if (opcao == 11)
                {
                    sanduiches = sanduiches + 1;
                    somaTotal = somaTotal + 28.22;
                }
                else if (opcao == 12)
                {
                    pizzas = pizzas + 1;
                    somaTotal = somaTotal + 8.98;
                }
                else if (opcao == 13)
                {
                    pizzas = pizzas + 1;
                    somaTotal = somaTotal + 0.42;
                }
                else if (opcao == 14)
                {
                    pizzas = pizzas + 1;
                    somaTotal = somaTotal + 18.36;
                }
                else if (opcao == 15) 
                {
                    pizzas = pizzas + 1;
                    somaTotal = somaTotal + 27.50;
                }
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
           }
            
           
            double mediaProdutos = somaTotal / produtos;
            
            Console.WriteLine("Você comprou " + bolos + " bolos" +
                            "\nVocê comprou " + doces + " doces" +
                            "\nVocê comprou " + sanduiches + " sanduiches" +
                            "\nVocê comprou " + pizzas + " pizzas" + 
                            "\nVocê comprou " + produtos + " itens" + 
                            "\nVocê gastou em média: " + mediaProdutos);

        }
    }
}
