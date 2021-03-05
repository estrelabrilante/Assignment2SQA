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
            string input;
            do
            {
                atstart:
                Console.WriteLine("1-Enter triangle dimensions");
                Console.WriteLine("2-Exit");
                input = Console.ReadLine();
                //int result = 0;

                if (int.TryParse(input, out menu))
                {

                     menu = Convert.ToInt32(input);
                    switch (menu)
                    {
                        case 1:
                            int a, b, c;
                            Console.WriteLine("Enter three integer ");
                            begin:
                            Console.WriteLine("Enter first sides");
                            //int a = Convert.ToInt32(Console.ReadLine());
                            //First side
                            String firstside = Console.ReadLine();
                            int result1 = 0;

                            if (int.TryParse(firstside, out result1))
                            {
                                a = Convert.ToInt32(firstside);
                            }
                            else
                            {
                                Console.WriteLine("Not a number");
                                goto begin;
                            }
                            //Second side
                            begin2:
                            Console.WriteLine("Enter second side");
                            String secondside = Console.ReadLine();
                            int result2 = 0;

                            if (int.TryParse(secondside, out result2))
                            {
                                b = Convert.ToInt32(secondside);
                            }
                            else
                            {
                                Console.WriteLine("Not a number");
                                goto begin2;
                            }
                            //Third side
                            begin3:
                            Console.WriteLine("Enter third side");
                            String thirdside = Console.ReadLine();
                            int result3 = 0;

                            if (int.TryParse(thirdside, out result3))
                            {
                                c = Convert.ToInt32(thirdside);
                            }
                            else
                            {
                                Console.WriteLine("Not a number");
                                goto begin3;
                            }

                            
                            
                            

                            //int b = Convert.ToInt32(Console.ReadLine());

                            //int c = Convert.ToInt32(Console.ReadLine());
                            if ((a + b > c || b + c > a || a + c > b) && (a > 0) && (b > 0) && (c > 0))
                            {
                                Console.WriteLine("Three sides form a triangle");

                                string d = TriangleSolver.Analyze(a, b, c);
                                Console.WriteLine("Triangle is " + " " + d);
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
                }
                else
                {
                    Console.WriteLine("Not a number");
                    goto atstart;
                }


            } while (menu != 2);
        }
    }
}

