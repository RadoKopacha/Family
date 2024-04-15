using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class triygylnik
    {
        public double sidea;
        public double sideb;
        public double sidec;
        public double ha;
        public double perimetyr;
        public double lice;

        public double Perimetyr()
        {
            perimetyr= this.sidea  + this.sideb+this.sidec;
            return perimetyr;
        }
        public double Area()
        {
            lice = this.sidea * this.ha;
            return lice;

        }
      
    }
}
