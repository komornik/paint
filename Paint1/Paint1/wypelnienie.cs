using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Paint
{
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
           
               bmp.SetPixel(x, y, cWyp);
               if (x + 1 < bmp.Width && c == bmp.GetPixel(x + 1, y))
               {
                   wypelnij(x + 1, y);
               }

               if (x - 1 >= 0 && c == bmp.GetPixel(x - 1, y))
               {
                   wypelnij(x - 1, y);
               }

               if (y + 1 < bmp.Height && c == bmp.GetPixel(x, y + 1))
               {
                   wypelnij(x, y + 1);
               }
               if (y - 1 >= 0 && c == bmp.GetPixel(x, y - 1))
               {
                   wypelnij(x, y - 1);
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
