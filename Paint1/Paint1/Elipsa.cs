using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint
{
    class Elipsa:Figura
    {
         public Elipsa(int x, int y, Color cWyp, Color CLin, float rozmiar)
            : base(x, y, cWyp, CLin)
        {
            grubosc = (int)rozmiar;
        }
        public override void narysuj(System.Drawing.Graphics g, int lx, int ly)
        {
            if(cWypel !=Color.White)
            g.FillEllipse(new SolidBrush(cWypel), x, y, lx - x, ly - y);
            if( grubosc> 0)
            g.DrawEllipse(new Pen(cLin, grubosc), x, y, lx - x, ly - y);
        }
    }
}
