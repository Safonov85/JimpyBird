using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpyBird
{
    class Wall
    {
        public Rectangle wallUp;
        public Rectangle wallDown;
        public SolidBrush wallColor;
        public int xWidht;
        public int yHeight;

        public Wall(int xPosition, int yPosition)
        {
            wallUp = new Rectangle(xPosition, yPosition, xWidht, yHeight);
            wallDown = new Rectangle(xPosition, yPosition, xWidht, yHeight);
            wallColor = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(210, 210, 210));
        }

        void RandomWallHeight()
        {

        }
    }
}
