﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fatorial(5));
            Console.ReadKey();
        }

        public static int Fatorial(int num)
        {
            if(num <= 1)
            {
                return 1;
            }

            return num * Fatorial(num - 1);

            // 5 * Fatorial(4);
                // 4 * Fatorial(3);
                    // 3 * Fatorial(2);
                        // 2 * Fatorial(1);
                            // 1 * Fatorial(0);
                                // return 1;
        }
    }
}
