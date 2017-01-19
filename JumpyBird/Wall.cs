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
        public int xWidth;
        public int yHeight;
        //public int xPosition, yPosition;

        public Wall(int xPosition, int yPosition, int xPositionDownWall, int yPositionUpWall)
        {
            xWidth = 20;
            yHeight = 500;
            HoleHeight();
            wallUp = new Rectangle(xPosition, yPosition, xWidth, yHeight);
            wallDown = new Rectangle(xPositionDownWall, yPositionUpWall, xWidth, yHeight);
            wallColor = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(220, 220, 220));
        }

        void HoleHeight()
        {
            int middlePositionHeight = RandomWallHeight();

            yHeight = yHeight - middlePositionHeight;
        }

        int RandomWallHeight()
        {
            Random random = new Random();
            int randomNumer = random.Next(150, 400);

            return randomNumer;
        }
    }
}
