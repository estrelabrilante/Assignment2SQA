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
        //Isosceles Triangle: atleast two sides are equal
        //scalene: No sides are equal
        
        public static string Analyze(int a, int b, int c)
        {
           string x;
            if (((a == b) && (b == c))&&((a>0)&&(b>0)&&(c>0))) {
                x = "Equilateral";
                
            }
            else if ((a == b || b == c || c == a)&& ((a > 0) && (b > 0) && (c > 0))) {
                x = "Isosceles";
            }
            else if (((a!=b)&&(b!=c)&&(a!=c))&& ((a > 0) && (b > 0) && (c > 0))) {
                x = "Scalene";
            }
            else
            {
                x = "Not a triangle";
            }

          return x;

        }


       

    }
}
