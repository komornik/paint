using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint
{
    class Gumka: Figura
    {
         public Gumka(int x, int y, Color cWyp, Color CLin, float rozmiar)
            : base(x, y, cWyp, CLin)
        {
            grubosc = (int) rozmiar;
        }
        public override void narysuj(System.Drawing.Graphics g, int lx, int ly)
        {
            g.FillEllipse(new SolidBrush(cWypel), lx, ly,grubosc , grubosc); 
            
        }
    }
}
