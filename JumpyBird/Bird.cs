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

        public Bird(int xPosition, int yPosition)
        {
            bird = new Rectangle(xPosition, yPosition, xWidth, yHeight);
            
        }


    }
}
