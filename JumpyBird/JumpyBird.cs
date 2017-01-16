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
        Color backgroundColor = Color.FromArgb(150, 150, 150);
        int xPosition, yPosition;
        Graphics graphics;
        Graphics graphicsOverride;

        public JumpyBird()
        {
            InitializeComponent();
            LoadInstance();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            graphics.Clear(backgroundColor);
            graphics.FillRectangle(brush, new Rectangle(100, 100, 100, 100));
            graphicsOverride.DrawImage(bitmap, 0, 0, this.Width, this.Height);
        }

        void LoadInstance()
        {
            brush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(250, 250, 250));
            wallBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(150, 150, 150));
            bitmap = new Bitmap(this.Width, this.Height);
            graphics = Graphics.FromImage(bitmap);
            graphicsOverride = this.CreateGraphics();
            xPosition = 20;
        }
    }
}
