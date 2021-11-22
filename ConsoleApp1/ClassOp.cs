using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ClassOp
    {
        double x, y;

        public ClassOp(double x, double y) 
        {
            this.x = x;
            this.y = y;
        }

        public double opsuma() 
        {
            return x + y;
        }

        public double opresta() 
        {
            return x - y;
        }

        public double opmultiplicar() 
        {
            return x * y;
        }

        public double opdividir() 
        {
            return x / y;
        }

        public bool mayorque()
        {
            return x > y;
        }

        public bool menorque()
        {
            return x < y;
        }
    }
}
