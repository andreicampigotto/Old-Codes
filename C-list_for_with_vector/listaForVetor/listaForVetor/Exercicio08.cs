using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio08
    {public Exercicio08 ()
	{
        Console.WriteLine(
@"              HH        HH             IIIIIIIIIIIIII
              HH        HH             IIIIIIIIIIIIII
              HH        HH                   II
              HH        HH                   II
              HH        HH                   II
              HHHHHHHHHHHH                   II
              HHHHHHHHHHHH                   II
              HH        HH                   II
              HH        HH                   II
              HH        HH                   II
              HH        HH             IIIIIIIIIIIIII                    
              HH        HH             IIIIIIIIIIIIII");

        Console.Write("Hi, How many numbers do you want to enter: ");
        int insert = Convert.ToInt32(Console.ReadLine());

        int[] stockAll = new int[insert];
        int[] pair = new int[insert];
        int[] odd = new int[insert];
        string nPairs = "", nOdds = "",stock="";
        
        for (int i = 0; i < insert; i++)
        {
            Console.Write("Insert Numbers: ");
            stockAll[i] = Convert.ToInt32(Console.ReadLine());

        }
        for (int i = 0; i < insert; i++)
        {
            if (stockAll[i] % 2 == 0)
            {
                pair[i] = stockAll[i];
                nPairs += pair[i];
            }
            if(stockAll[i] % 2!= 0)
            {
                odd[i] = stockAll[i];
                nOdds += pair[i];

            }
        stock = string.Join(",", stockAll);
        nPairs = string.Join(",", pair);
        nOdds = string.Join(",", odd);
        }
        Console.WriteLine(stock + "\n" + nPairs + "\n" + nOdds);
	}
        
    }
}
