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
        private int startX;
        private int startY;
        private int endX;
        private int endY;

        public Line(int startX, int startY, int endX, int endY)
        {
            if(startX < 0 || startX > 100)
            {
                throw new ArgumentException("Coordinations must be between 0-100");
            }
            if (startY < 0 || startY > 100)
            {
                throw new ArgumentException("Coordinations must be between 0-100");
            }
            if (endX < 0 || endX > 100)
            {
                throw new ArgumentException("Coordinations must be between 0-100");
            }
            if (endY < 0 || endY > 100)
            {
                throw new ArgumentException("Coordinations must be between 0-100");
            }
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }

        public string draw()
        {
            String x = "";
            for(int i = 0; i < 100; i++)
            {
                x += "\n";
                
                for (int j = 0; j<100; j++)
                {
                    if(startX == j && startY == i)
                    {
                        x += ">";
                        continue;


                    }
                    x += "x";
                }
            }
            return x;
        }
    }
}
