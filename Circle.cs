using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Circle
    {
        private double radius, c, area, a;
        private string formatC;
        private string formatA, formatN;


        public Circle(double radius)
        {
            this.radius = radius;
        }

        //private string FormatNumber(double x)
        //{

        //    double radius = string.Format("{0:0.00}", x);
        //    return formatN;
        //}

        public double CalculateCircumference()
        {
            c = radius * 2 * Math.PI;
            return c;
        }

        public string CalculateFormattedCircumference()
        {
            c = CalculateCircumference();
            formatC = string.Format("The Circumference of your circle is  {0:0.00}", c);
            return formatC;
        }

        public double CalculateArea()
        {
            a = (Math.PI * radius * radius);
            return a;
        }

        public string CalculateFormattedArea()
        {
            a = CalculateArea();
            formatA = string.Format("The Area of your circle is {0:0.00}", a);
            return formatA;
        }

      

    }
}
