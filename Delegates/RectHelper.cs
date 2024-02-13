using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void RectDelegate(double width, double height);
    public class RectHelper
    {
        public static void GetArea(double width,double height)
        {
            var area = width * height;

            Console.WriteLine($"Area = {width} * {height} = {area}");
        }
        
        public static void GetPerimeter(double width,double height)
        {
            var Perimeter = (width + height)*2;

            Console.WriteLine($"Area = ({width} + {height}) * 2 = {Perimeter}");
        }
    }
}
