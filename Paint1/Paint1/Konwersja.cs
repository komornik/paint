using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
//using System.Windows.Media;
namespace Paint
{
    class Konwersja
    {
        public static Bitmap ConvertTo8Bit(Bitmap input)
        {
            Bitmap output = new Bitmap(input.Width, input.Height);
            Color c;
            int min=0;
            for (int x = 0; x < input.Height; x++)
            {
                for (int y=0; y < input.Width; y++)
                {
                   c= input.GetPixel(y,x);
                   min =(int) Math.Min(c.B, Math.Min(c.R, c.G));
                   output.SetPixel(y,x,Color.FromArgb(c.A,min,min,min));
                   
                }
            }

            return output;
        }

        public static Bitmap ConverteToBlacWhite(Bitmap input)
        {
            Bitmap output = new Bitmap(input.Width, input.Height);
            int romiar_okna = 3;

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
                        output.SetPixel(x, y, Color.FromArgb(240, 255, 255, 255));
                    }else{
                        output.SetPixel(x, y, Color.FromArgb(input.GetPixel(x, y).A, 0, 0, 0));
                    }

                }
            }

            return output;


        }



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

        
    }
}
