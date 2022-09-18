using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Classes
{
    internal class Interval
    {
        private int bot;
        private int top;

        public Interval(int bot, int top)
        {
            if(top >= bot)
            {
                this.top = top;
                this.bot = bot;
                return;
            }
            throw new ArgumentException("Top > min");

        }

        public int getTop()
        {
            return top;
        }

        public int getBot()
        {
            return bot;
        }

        public void setTop(int top)
        {
            this.top = top;
        }

        public void setBot(int bot)
        {
            this.bot = bot;
        }

        public bool isInterval(int n)
        {
            if(n <= top && n >= bot)
            {
                return true;
            }
            return false;
        }


        public static Interval getIntersection(Interval i1, Interval i2)
        {
            int x1, x2, y1, y2;

            x1 = i1.getBot();
            x2 = i1.getTop();
            y1 = i2.getBot();
            y2 = i2.getTop();

            //Interval not intersecting
            if(x2 < y1 || x1 > y2)
            {
                return null;
            }

            //Interval within interval
            if(x1 >= y1 && x2 <= y1)
            {
                return new Interval(x1, x2);
            }

            if(y1 >= x1 && y2 <= x2)
            {
                return new Interval(y1, y2);
            }

            //Left to right intersection
            if(x1<=y2 && x2 >= y2)
            {
                return new Interval(x1, y2);
            }

            if(y1 <= x2 && y2 >= x2)
            {
                return new Interval(y1, x2);
            }
           




            return null;



                
        }

        public override string? ToString()
        {
            return "Interval : "+this.bot + "_" + this.top;
        }
    }
}
