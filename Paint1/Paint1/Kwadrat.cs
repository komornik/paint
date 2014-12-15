using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint
{
    class Kwadrat:Figura
    {
        public Kwadrat(int x, int y, Color cWyp, Color CLin, float rozmiar)
            : base(x, y, cWyp, CLin)
        {
            grubosc = (float)rozmiar;
        }
        public override void narysuj(System.Drawing.Graphics g, int lx, int ly)
        {
            if (cWypel != Color.White)
            g.FillRectangle(new SolidBrush(cWypel), Math.Min(x, lx), Math.Min(y, ly), Math.Abs(lx - x), Math.Abs(ly - y));
            if (grubosc >0)
            g.DrawRectangle(new Pen(cLin, grubosc), Math.Min(x, lx), Math.Min(y, ly), Math.Abs(lx - x), Math.Abs(ly - y));
        }
        
           
        
    }
}
