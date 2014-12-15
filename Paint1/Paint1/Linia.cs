using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint
{
    class Linia:Figura
    {
        public Linia(int x, int y, Color cWyp, Color CLin, float rozmiar)
            : base(x, y, cWyp, CLin)
        {
            grubosc = rozmiar;
        }
        public override void narysuj(System.Drawing.Graphics g, int lx, int ly)
        {

            g.DrawLine(new Pen(new SolidBrush(cWypel),grubosc), new Point(x, y), new Point(lx, ly));
        }
    }
}
