using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Class1
    {
        public double a;
        public double b;
        public double p;
        public double lice;

        public double Perimetyr()
        {
            p = (this.a *2) + (this.b * 2);
            return p;
        }
        public double findArea()
        {
            this.lice = this.a * this.b;
            return lice;
        }
    }
}
