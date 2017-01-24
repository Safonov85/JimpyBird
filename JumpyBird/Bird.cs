using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JumpyBird
{
    class Bird
    {
        public Rectangle bird;
        public int xWidth, yHeight;
        public DateTime time;

        public Bird(int xPosition, int yPosition)
        {
            bird = new Rectangle(xPosition, yPosition, xWidth, yHeight);
            time = DateTime.Now;
        }

        public void Gravity(int yPosition)
        {
            TimeSpan seconds = time - DateTime.Now;

            double addY = (double)9.8 * (Math.Pow(seconds.TotalSeconds, 2));

            //yPosition += (int)addY;
        }
    }
}
