using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
   public static class TriangleSolver
    {
        //Equilateral Triangle: three sides are equal
        // Isosceles Triangle: atleast two sides are equal
        //scalene: No sides are equal
        
        public static string Analyze(int a, int b, int c)
        {
            string x;
            if ((a == b) && (b == c)) {
                x = "Equilateral";
                //return x;
            }
            else if (a == b || b == c || c == a)
            {
                x = "Isosceles";
            }
            else
            {
                x = "Scales";
            }

            return x;

        }


       

    }
}
