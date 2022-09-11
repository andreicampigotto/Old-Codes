using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio10
    {
        public Exercicio10()
        {
            int ca = 0, cb = 0, cc = 0, cd = 0, ce = 0, cf = 0, cg = 0, ch = 0, ci = 0, cj = 0, ck = 0, cl = 0, cm = 0,
                cn = 0, co = 0, cp = 0, cq = 0, cr = 0, cs = 0, ct = 0, cu = 0, cv = 0, cw = 0, cx = 0, cy = 0, cz = 0;
            
            Console.Write("Contador de letras.\nDigite a palavra: ");
            string palavra = Console.ReadLine();
            string palavraTolower = palavra.ToLower();
            int contadorPalavra = palavra.Length;
            int letras = 0;

            while (letras != contadorPalavra)
            {

                if (palavra[letras] == 'a'){
                    ca++;
                }
                if (palavra[letras] == 'b')
                {
                    cb++;
                }
                if (palavra[letras] == 'c')
                {
                    cc++;
                }
                if (palavra[letras] == 'd')
                {
                    cd++;
                }
                if (palavra[letras] == 'e')
                {
                    ce++;
                }
                if (palavra[letras] == 'f')
                {
                    cf++;
                }
                if (palavra[letras] == 'g')
                {
                    cg++;
                }
                if (palavra[letras] == 'h')
                {
                    ch++;
                }
                if (palavra[letras] == 'i')
                {
                    ci++;
                }
                if (palavra[letras] == 'j')
                {
                    cj++;
                }
                if (palavra[letras] == 'k')
                {
                    ck++;
                }
                if (palavra[letras] == 'l')
                {
                    cl++;
                }
                if (palavra[letras] == 'm')
                {
                    cm++;
                }
                if (palavra[letras] == 'n')
                {
                    cn++;
                }
                if (palavra[letras] == 'o')
                {
                    co++;
                }
                if (palavra[letras] == 'p')
                {
                    cp++;
                }  
                if (palavra[letras] == 'q')
                {
                    cq++;
                }
                if (palavra[letras] == 'r')
                {
                    cr++;
                }
                if (palavra[letras] == 's')
                {
                    cs++;
                }
                if (palavra[letras] == 't')
                {
                    ct++;
                }
                if (palavra[letras] == 'u')
                {
                    cu++;
                }
                if (palavra[letras] == 'v')
                {
                    cv++;
                }
                if (palavra[letras] == 'w')
                {
                    cw++;
                }
                if (palavra[letras] == 'x')
                {
                    cx++;
                }
                if (palavra[letras] == 'y')
                {
                    cy++;
                }
                if (palavra[letras] == 'z')
                {
                    cz++;
                }

                
                letras++;
            }
            Console.WriteLine("\nA = " + ca +
                              "\nB = " + cb +
                              "\nC = " + cc +
                              "\nD = " + cd +
                              "\nE = " + ce +
                              "\nF = " + cf +
                              "\nG = " + cg +
                              "\nH = " + ch +
                              "\nI = " + ci +
                              "\nJ = " + cj +
                              "\nK = " + ck +
                              "\nL = " + cl +
                              "\nM = " + cm +
                              "\nN = " + cn +
                              "\nO = " + co +
                              "\nP = " + cp +
                              "\nQ = " + cq +
                              "\nR = " + cr +
                              "\nS = " + cs +
                              "\nT = " + ct +
                              "\nU = " + cu +
                              "\nV = " + cv +
                              "\nW = " + cw +
                              "\nX = " + cx +
                              "\nY = " + cy +
                              "\nZ = " + cz);
          
        }
    }
}
