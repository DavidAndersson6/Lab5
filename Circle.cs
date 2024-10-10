using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Circle
    {
       
        public int Radie { get; set; }
        public Circle(int radie)
        {
            Radie = radie; 
        }

        public double GetArea()
        {
            return Radie * Radie * Math.PI;
        }
    }
}
