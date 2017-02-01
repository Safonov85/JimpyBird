using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpyBird
{
    public partial class JumpyBird : Form
    {
        Bitmap bitmap;
        SolidBrush brush;
        SolidBrush wallBrush;
        Color backgroundColor = Color.FromArgb(70, 70, 70);
        int yPosition, xPositionDown, yPositionDown;
        int[] xPosition;
        int xBirdPosition, yBirdPosition;
        int newWall;
        int jumpStop;
        bool spacePress;
        Graphics graphics;
        Graphics graphicsOverride;

        List<Wall> wall;
        Bird bird;

        public JumpyBird()
        {
            InitializeComponent();
            LoadInstance();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            graphics.Clear(backgroundColor);
            //graphics.FillRectangle(brush, new Rectangle(100, 100, 100, 100));
            int itemCount = 0;
            foreach(Wall item in wall)
            {
                item.wallUp = new Rectangle(xPosition[itemCount], yPosition, item.xWidth, item.yHeight);
                graphics.FillRectangle(item.wallColor, item.wallUp);
                itemCount++;
            }

            bird = new Bird(xBirdPosition, yBirdPosition);
            graphics.FillRectangle(bird.birdBrush, bird.bird);
            itemCount = 0;
            while(itemCount < 4)
            {
                xPosition[itemCount] -= 2;
                itemCount++;
            }
            newWall += 2;

            if(spacePress == false)
            {
                yBirdPosition = bird.SimpleFall(yBirdPosition);
            }
            else
            {
                yBirdPosition -= 3;
                jumpStop += 3;
                if(jumpStop > 40)
                {
                    spacePress = false;
                    jumpStop = 0;
                }
            }

            graphicsOverride.DrawImage(bitmap, 0, 0, this.Width, this.Height);
        }

        void LoadInstance()
        {
            brush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(250, 250, 250));
            wallBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(150, 150, 150));
            bitmap = new Bitmap(this.Width, this.Height);
            graphics = Graphics.FromImage(bitmap);
            graphicsOverride = this.CreateGraphics();
            wall = new List<Wall>();
            xBirdPosition = 50;
            yBirdPosition = 200;
            bird = new Bird(xBirdPosition, yBirdPosition);
            xPosition = new int[4];
            xPosition[0] = 370;
            newWall = 0;
            jumpStop = 0;
            spacePress = false;
            AddWall();
            timer.Start();
        }

        void AddWall()
        {
            if(newWall < 250)
            {
                wall.Add(new Wall(xPosition[0], yPosition, xPositionDown, yPositionDown));
                newWall = 0;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Space)
            {
                spacePress = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
