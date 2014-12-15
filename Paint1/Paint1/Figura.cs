using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint
{
    class Figura
    {
        protected int x, y;
        protected Color cWypel, cLin;
        protected float grubosc;

        public Figura(int x, int y,Color cWypel, Color cLin)
        {
            this.x = x;
            this.y = y;
            this.cWypel = cWypel;
            this.cLin = cLin;
        }
        public virtual void narysuj(Graphics g, int lx , int ly){}
    }
}
