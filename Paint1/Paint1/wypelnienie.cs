using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
namespace Paint
{
     public class Punkty
    {
        public int X { get; set; }
        public int Y { get; set; }


    }

    class Wypelnienie
    {
        static Bitmap bmp;
        static Color c, cWyp;
       
        public Wypelnienie(Bitmap obraz, Color cBa, Color cWy)
        {
            bmp = obraz;
            cWyp = cWy;
            c = cBa;
        }
            
        


        public void wypelnij( int x, int y)
       {
            Stack<Punkty> listapunktow = new Stack<Punkty>();
            Punkty punkt = new Punkty();
            punkt.X = x;
            punkt.Y = y;
            bmp.SetPixel(x, y, cWyp);
            listapunktow.Push(punkt);
               while(listapunktow.Count()>0)
            {
                punkt=listapunktow.Pop();
                x = punkt.X;
                y = punkt.Y;
                
                if ( x+1 <bmp.Width && c== bmp.GetPixel(x + 1, y))
                {
                    punkt = new Punkty();
                    punkt.X = x+1;
                    punkt.Y = y;
                    bmp.SetPixel(x+1, y, cWyp);
                    listapunktow.Push(punkt);

                }
                if( x -1 > -1 && c== bmp.GetPixel(x - 1, y))
                {
                    punkt = new Punkty();
                    punkt.X = x -1 ;
                    punkt.Y = y;
                    punkt.X = x - 1;
                    bmp.SetPixel(x-1, y, cWyp);
                    listapunktow.Push(punkt);
                }
                if( y+1 < bmp.Height && c == bmp.GetPixel(x, y + 1))
                {
                    punkt = new Punkty();
                    punkt.X = x ;
                    punkt.Y = y + 1;
                    bmp.SetPixel(x, y+1, cWyp);
                    listapunktow.Push(punkt);
                }
                if ( y-1>-1 && c == bmp.GetPixel(x, y - 1))
                {
                    punkt = new Punkty();
                    punkt.X = x ;
                    punkt.Y = y - 1;
                    bmp.SetPixel(x, y-1, cWyp);
                    listapunktow.Push(punkt);
                }
                
            }
               
           
           

       }

        public Boolean maluj (int x, int y){
            Boolean zmieniono = false;

            for (int i = 0; i < 3; i++)
            {
                if (c== bmp.GetPixel(x+i,y)){

                }
            }

            return (Boolean) zmieniono;
        }


        public Color cBuf { get; set; }
    }
}
