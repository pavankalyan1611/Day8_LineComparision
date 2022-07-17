using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8LineComparisionOops
{
     public class Line
    {
        public Line()
        {
            Console.WriteLine("welcome to Line Comparision Problem :");
        }
        public double Length()
        {
            Console.WriteLine("Enter the Value of X1 for Cal Length1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of X2  for Cal Length1");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of y1 for Cal Length1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of Y2 for Cal Length1");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double result = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            return result;
        }

    }
}
