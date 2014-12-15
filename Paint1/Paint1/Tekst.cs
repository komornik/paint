using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint
{
    class Tekst: Figura
    {
        
            private FontFamily fontName;
            private FontStyle fontStyle;
            private float fontSize;
            private String text;

            /// <summary>
            /// Konstruktor klasy Tekst przymuję wartości, fontName - nazwa czcionki, font style = styl np Bold, fontSize = wielkość czcionki w pt, oraz tekst do wypisania na ekranie
            /// </summary>
            public Tekst(Color kolor, float gruboscLini, FontFamily fontName, FontStyle fontStyle, float fontSize, String tekst) :
                base(0, 0, kolor, kolor)
            {
                grubosc =  gruboscLini;
                
                this.fontName = fontName;
                this.fontStyle = fontStyle;
                this.fontSize = fontSize;
                this.text = tekst;
            }


             public override void narysuj(System.Drawing.Graphics g, int lx, int ly)
        {
            
                var font = new Font(this.fontName, this.fontSize, this.fontStyle);
                g.DrawString(this.text, font, new SolidBrush(cWypel), lx, ly);
               
        }  

           
        }
    }

