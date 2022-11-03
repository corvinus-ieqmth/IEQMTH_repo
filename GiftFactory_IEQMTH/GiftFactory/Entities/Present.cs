using GiftFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftFactory.Entities
{
    public class Present : Toy
    {
        public Present()
        {

            AutoSize = false;
            Height = 50; Width = 50;
            Paint += Toy_Paint;

        }

        public SolidBrush PresentColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }

        public Present(Color color, Color color2)
        {
            PresentColor = new SolidBrush(color);
            RibbonColor = new SolidBrush(color2);
        }

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected override void DrawImage(Graphics graphics)
        {
            graphics.FillRectangle(PresentColor, 0, 0, Width, Height);
            graphics.FillRectangle(RibbonColor, 21, 0, Width / 5, Height);
            graphics.FillRectangle(RibbonColor, 0, 21, Width, Height / 5);

        }

        public void MoveToy()
        {
            Left += 1;
        }
    }
}
