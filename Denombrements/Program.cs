using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {   // déclaration valeur
            int c = 1;
            fghfgh
            // Condition
            while (c != 0)
            {fthyufgtjfghykfyjkfg............. 1");h
                Console.WriteLine("Arrangement fgh...................... 2");
                Console.WriteLine("Combinaison .....hj............. 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                       fg
                    jf

                if (c == 1)
                {   
                    // le nombre d'éléments à gérer et saisie
                    Console.Write("nombre total d'éléments à gérer = "); 

                    int n = int.Parse(Console.ReadLine()); 
                  
                    // calcul de r
                    long r = 1;
                    for (int k = 1; k <= n; k++)
                        r *= k;
                    Console.WriteLine(n + "! = " + r);
                }

                else

                {
                    if (c == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int n = int.Parse(Console.ReadLine()); // saisir le nombre

                        // calcul de r
                        long r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;

                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }

                    else

                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int n = int.Parse(Console.ReadLine()); // saisir le nombre

                        // calcul de r1
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;

                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
