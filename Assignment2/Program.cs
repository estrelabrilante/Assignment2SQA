using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            do
            {
                atstart:
                Console.WriteLine("1-Enter triangle dimensions");
                Console.WriteLine("2-Exit");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                       
                        Console.WriteLine("Enter three integer ");
                        Console.WriteLine("Enter first sides");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second side");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter third side");
                        int c = Convert.ToInt32(Console.ReadLine());
                        if ((a+b>c || b+c>a || a+c >b) && (a>0) && (b>0) && (c>0))
                        {
                            Console.WriteLine("Three sides form a triangle");
                           
                            string d = TriangleSolver.Analyze(a, b, c);
                            Console.WriteLine("Triangle is" + d);
                        }
                        else
                        {
                            Console.WriteLine("Enter proper value for sides");
                            goto atstart;
                        }
                        break;
                    case 2:
                        break;

                }

            } while (menu != 2);
        }
    }
}

