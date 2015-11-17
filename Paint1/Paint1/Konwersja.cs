using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
//using System.Windows.Media;
namespace Paint
{
    class Konwersja
    {
        static int[] LUT= null;

        /// <summary>
        /// Konwersja z RGB na 8 bitów ustawienie wszystkich kolorów na ten sam
        /// </summary>
        /// <param name="input"> obraz do Konwersji</param>
        /// <returns>obraz przerobiony</returns>
        public static Bitmap ConvertTo8Bit(Bitmap input, ToolStripProgressBar progresbar )

        {
            Bitmap output = new Bitmap(input.Width, input.Height);
            Color c;
            int gray,wynik;
            if (LUT == null)
            {
                LUT = new int[256];
                double a = 1.25;
                for(int i = 0; i < 256; i++)
                {
                    wynik =Convert.ToInt32( a * (i - 255 / 2) + 255 / 2);
                    if (wynik < 0)
                    {
                        LUT[i] = 0;
                    }else if (wynik > 255)
                    {
                        LUT[i] = 255;
                    }
                    else
                    {
                        LUT[i] = wynik;
                    }
                }
            }
            
            progresbar.Step = 1;
            progresbar.Minimum = 0;
            progresbar.Maximum = input.Height * input.Width;
            progresbar.Step = 1;
            for (int x = 0; x < input.Height; x++)
            {
                for (int y=0; y < input.Width; y++)
                {
                   c= input.GetPixel(y,x);
                    // konwersja do skali szarości 
                   gray =Convert.ToInt32( 0.21*c.R + 0.72 * c.G + 0.07 * c.B);
                    
                    //poprawa contrastu
                   gray = LUT[gray];
                   output.SetPixel(y,x,Color.FromArgb(c.A,gray,gray,gray));
                    progresbar.PerformStep();
                }
            }
            progresbar.Value = 0;
            return output;
        }

        /// <summary>
        /// Konwersja na B&W
        /// </summary>
        /// <param name="input">Obraz do konwersji</param>
        /// <returns>obraz przerobiony</returns>
        public static Bitmap ConverteToBlacWhite(Bitmap input, ToolStripProgressBar progresbar)
        {
            Bitmap output = new Bitmap(input.Width, input.Height);
            int romiar_okna = 1;
            progresbar.Step = 1;
            progresbar.Minimum = 0;
            progresbar.Maximum = input.Height * input.Width;
            progresbar.Step = 1;
            for (int y = romiar_okna; y < (input.Height - romiar_okna-1); y++)
            {
                for (int x = romiar_okna; x < (input.Width - romiar_okna-1); x++)
                {
                    int srednia= 0;

                    for (int i = (-1*romiar_okna); i <  romiar_okna; i++)
                    {
                        for (int j = (-1*romiar_okna); j < romiar_okna; j++)
                        {
                            srednia += input.GetPixel(x+i,y+j).B;
                        }
                    }
                    if (srednia >= 127)
                    {
                        output.SetPixel(x, y, Color.FromArgb(input.GetPixel(x, y).A, 255, 255, 255)); //alfa była 240
                    }else{
                        output.SetPixel(x, y, Color.FromArgb(input.GetPixel(x, y).A, 0, 0, 0));
                    }
                    progresbar.PerformStep();

                }
            }
            progresbar.Value = 0;
            return output;


        }



        /*
        public static Bitmap ConvertTo1Bit(Bitmap input)
        {
            Color pix = input.GetPixel(1, 1);

            Bitmap obraz = new Bitmap(input.Width, input.Height);
            
            var masks = new byte[] { 0x80, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01 };
            var output = new Bitmap(input.Width, input.Height, PixelFormat.Format1bppIndexed);
            var data = new sbyte[input.Width, input.Height];
            var inputData = input.LockBits(new Rectangle(0, 0, input.Width, input.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            try
            {
                var scanLine = inputData.Scan0;
                var line = new byte[inputData.Stride];
                for (var y = 0; y < inputData.Height; y++, scanLine += inputData.Stride)
                {
                    Marshal.Copy(scanLine, line, 0, line.Length);
                    for (var x = 0; x < input.Width; x++)
                    {
                        data[x, y] = (sbyte)(64 * (GetGreyLevel(line[x * 3 + 2], line[x * 3 + 1], line[x * 3 + 0]) - 0.5));
                    }
                }
            }
            finally
            {
                input.UnlockBits(inputData);
            }
            var outputData = output.LockBits(new Rectangle(0, 0, output.Width, output.Height), ImageLockMode.WriteOnly, PixelFormat.Format1bppIndexed);
            try
            {
                var scanLine = outputData.Scan0;
                for (var y = 0; y < outputData.Height; y++, scanLine += outputData.Stride)
                {
                    var line = new byte[outputData.Stride];
                    for (var x = 0; x < input.Width; x++)
                    {
                        var j = data[x, y] > 0;
                        if (j) line[x / 8] |= masks[x % 8];
                        var error = (sbyte)(data[x, y] - (j ? 32 : -32));
                        if (x < input.Width - 1) data[x + 1, y] += (sbyte)(7 * error / 16);
                        if (y < input.Height - 1)
                        {
                            if (x > 0) data[x - 1, y + 1] += (sbyte)(3 * error / 16);
                            data[x, y + 1] += (sbyte)(5 * error / 16);
                            if (x < input.Width - 1) data[x + 1, y + 1] += (sbyte)(1 * error / 16);
                        }
                    }
                    Marshal.Copy(line, 0, scanLine, outputData.Stride);
                }
            }
            finally
            {
                output.UnlockBits(outputData);
            }
            return output;
        }

        public static double GetGreyLevel(byte r, byte g, byte b)
        {
            return (r * 0.299 + g * 0.587 + b * 0.114) / 255;
        }

        */
    }
}
