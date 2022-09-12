using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Classes
{
    internal class Line
    {
        private int length;

        public Line(int length)
        {
            this.length = length;
        }


        public string draw()
        {
            String x = "";
            while(x.Length < this.length)
            {
                x += "-";
            }
            return x;
        }
    }
}
