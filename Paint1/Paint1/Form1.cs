using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Paint
{
    public partial class Form1 : Form
    {
        ColorDialog dialcol = new ColorDialog();
        Item choseItem;
        Bitmap buf, buf2;
        bool draw = false;
        int sizeDefault = 0; 
        
        Graphics g;
        Figura referencja;
        public enum Item
        {
            kwadrat, elipsa, linia, pendzel, olowek, gumka, wypel,
            tekst
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void color1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                default1.BackColor = color1.BackColor; 
            }
            else if (e.Button == MouseButtons.Right)
            {
                default2.BackColor = color1.BackColor;
            }


        }
 
        private void color1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dialcol.ShowDialog();
            color1.BackColor = dialcol.Color;
            if (e.Button == MouseButtons.Left)
            {

                default1.BackColor = dialcol.Color;
            }
            else if (e.Button == MouseButtons.Right)
            {
                default2.BackColor = dialcol.Color;
            }

        }

        private void color2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                default1.BackColor = color2.BackColor;
            }
            else if (e.Button == MouseButtons.Right)
            {
                default2.BackColor = color2.BackColor;
            }
        }

        private void color2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dialcol.ShowDialog();
            color2.BackColor = dialcol.Color;
            if (e.Button == MouseButtons.Left)
            {

                default1.BackColor = dialcol.Color;
            }
            else if (e.Button == MouseButtons.Right)
            {
                default2.BackColor = dialcol.Color;
            }
        }

        private void color3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                default1.BackColor = color3.BackColor;
            }
            else if (e.Button == MouseButtons.Right)
            {
                default2.BackColor = color3.BackColor;
            }
        }

        private void color3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dialcol.ShowDialog();
            color3.BackColor = dialcol.Color;
            if (e.Button == MouseButtons.Left)
            {

                default1.BackColor = dialcol.Color;
            }
            else if (e.Button == MouseButtons.Right)
            {
                default2.BackColor = dialcol.Color;
            }
        }

        private void color4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                default1.BackColor = color4.BackColor;
            }
            else if (e.Button == MouseButtons.Right)
            {
                default2.BackColor = color4.BackColor;
            }
        }
        

        private void color4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dialcol.ShowDialog();
            color4.BackColor = dialcol.Color;
            if (e.Button == MouseButtons.Left)
            {

                default1.BackColor = dialcol.Color;
            }
            else if (e.Button == MouseButtons.Right)
            {
                default2.BackColor = dialcol.Color;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                if (!draw)
                {
                    buf = new Bitmap(pictureBox2.Image);
                    buf2 = (Bitmap)buf.Clone();
                   

                    switch (choseItem)
                    {
                        case Item.linia:
                            g = Graphics.FromImage(buf);
                            Linia l = new Linia(e.X, e.Y, default1.BackColor, default2.BackColor, (float)Convert.ToDouble(textBox1.Text));
                            referencja = l;
                            draw = true;
                            break;
                        case Item.kwadrat:
                            Kwadrat kwadrat = new Kwadrat(e.X, e.Y, default1.BackColor, default2.BackColor, (float)Convert.ToDouble(textBox1.Text));
                            referencja = kwadrat;
                            draw = true;
                            break;
                        case Item.elipsa:
                             g = Graphics.FromImage(buf);
                             Elipsa el = new Elipsa(e.X, e.Y, default1.BackColor, default2.BackColor, (float)Convert.ToDouble(textBox1.Text));
                            referencja = el;
                            draw = true;
                            break;
                        case Item.olowek:
                             g = Graphics.FromImage(buf);
                             Olowek dow = new Olowek(e.X, e.Y, default1.BackColor, default2.BackColor, (float)Convert.ToDouble(textBox1.Text));
                            referencja = dow;
                            draw = true;
                            break;
                        case Item.gumka:
                            g = Graphics.FromImage(buf);
                            Gumka gumi = new Gumka(e.X, e.Y, default1.BackColor, default2.BackColor, (float)Convert.ToDouble(textBox1.Text));
                            referencja = gumi;
                            draw = true;
                            break;
                        case Item.wypel:
                            Wypelnienie wyp = new Wypelnienie((Bitmap)buf, buf.GetPixel(e.X, e.Y), default1.BackColor );
                            wyp.wypelnij(e.X, e.Y);
                            pictureBox2.Image = buf;
                            break;
                        case Item.tekst:
                            g = Graphics.FromImage(buf);
                            referencja.narysuj(g, e.X, e.Y);
                            pictureBox2.Image = buf;
                            break;

                    }

                }
                
               
            }

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (e.Y < pictureBox2.Height && e.Y>0 && e.X >0 && e.X < pictureBox2.Width)
            {
                toolStripStatusTextX.Text = Convert.ToString(e.X);
                toolStripStatusTextY.Text = Convert.ToString(e.Y);
            }
            if (draw )
            {   
                /// przewijanie panelu 
                if ((-1 * (int)panel1.AutoScrollPosition.Y + (int)panel1.Size.Height) < e.Y + 17)
                {
                    
                        panel1.VerticalScroll.Value += 10;
                   
                }
                else if ((-1 * (int)panel1.AutoScrollPosition.Y) > e.Y ){
                    if (panel1.VerticalScroll.Value > 10)
                    {
                        panel1.VerticalScroll.Value -= 10;
                    } 
                    else panel1.VerticalScroll.Value = 0;
                }
                else if ((-1 * (int)panel1.AutoScrollPosition.X + (int)panel1.Size.Width) < e.X + 14)
                {

                    panel1.HorizontalScroll.Value += 10;

                }
                else if ((-1 * (int)panel1.AutoScrollPosition.X) > e.X)
                {
                    if (panel1.HorizontalScroll.Value > 10)
                    {
                        panel1.HorizontalScroll.Value -= 10;
                    }
                    else panel1.HorizontalScroll.Value = 0;
                }
                if (choseItem != Item.olowek && choseItem != Item.gumka)
                {
                    g = Graphics.FromImage(buf);
                    referencja.narysuj(g, e.X, e.Y);
                    pictureBox2.Image = buf;
                    buf = (Bitmap)buf2.Clone();
                    g.Dispose();
                }
                else
                {
                    g = Graphics.FromImage(buf);
                    referencja.narysuj(g, e.X, e.Y);
                    pictureBox2.Image = buf;
                    g.Dispose();
                }




            }
            

        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
          
        }

        private void linia_Click(object sender, EventArgs e)
        {
            choseItem = Item.linia;
            sizeDefault = 1;
            label1.Text = "Rozmiar lini";
            textBox1.Text = Convert.ToString(sizeDefault);
            label2.Text="( "+Convert.ToString(sizeDefault)+"-50 )" ;
            rozmiar.Minimum = sizeDefault;
            rozmiar.Value = sizeDefault;
        }

        private void kwadrat_Click(object sender, EventArgs e)
        {
            choseItem = Item.kwadrat;
            sizeDefault = 0;
            label1.Text = "Rozmiar lini";
            textBox1.Text = Convert.ToString(sizeDefault);
            label2.Text = "( " + Convert.ToString(sizeDefault) + "-50 )";
            rozmiar.Minimum = sizeDefault;
            rozmiar.Value = sizeDefault;
        }

        private void elipsa_Click(object sender, EventArgs e)
        {
            choseItem = Item.elipsa;
            sizeDefault = 0;
            label1.Text = "Rozmiar lini";
            textBox1.Text = Convert.ToString(sizeDefault);
            label2.Text = "( " + Convert.ToString(sizeDefault) + "-50 )";
            rozmiar.Minimum = sizeDefault;
            rozmiar.Value = sizeDefault;
        }

        private void olowek_Click(object sender, EventArgs e)
        {
            choseItem = Item.olowek;
            sizeDefault = 2;
            label1.Text = "Rozmiar";
            textBox1.Text = Convert.ToString(sizeDefault);
            label2.Text = "( " + Convert.ToString(sizeDefault) + "-50 )";
            rozmiar.Minimum = sizeDefault;
            rozmiar.Value = sizeDefault;
        }

        private void gumka_Click(object sender, EventArgs e)
        {
            choseItem = Item.gumka;
            sizeDefault = 5;
            label1.Text = "Rozmiar";
            textBox1.Text = Convert.ToString(sizeDefault);
            label2.Text = "( " + Convert.ToString(sizeDefault) + "-50 )";
            rozmiar.Minimum = sizeDefault;
            rozmiar.Value = sizeDefault;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                int width = Form1.ActiveForm.Width;
                int height = Form1.ActiveForm.Height;
                panel1.Size = new Size(width - 132, height - 96);
                panel2.Location = new Point(width - 126, 27);
                groupBox1.Location = new Point(width - (496 - 370), height - (401 - 232));
            }
            catch (Exception ex)
            {
                MessageBox.Show("ksa");
            }
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            DialogResult result= dialog.ShowDialog();
            if (result == DialogResult.OK)
            {

                String nazwa = dialog.FileName;
                pictureBox2.Image = new Bitmap(dialog.FileName);
                pictureBox2.ImageLocation = nazwa;
                //Image obraz = pictureBox2.Image;
                pictureBox2.Size = new Size(pictureBox2.Image.Width, pictureBox2.Image.Height);
                pictureBox2.Invalidate();
            }

        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Nie otworzyłeś żadnego obrazu", "Brak zdjęcia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String nazwa;

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.Filter = "Image Files(*.JPG;*.BMP;*.GIF)|*.JPG;*.BMP;*.GIF";
                DialogResult result = saveFileDialog1.ShowDialog();
                nazwa = saveFileDialog1.FileName;
                if (nazwa != "" && result == DialogResult.OK)
                {


                    Image zdjecie = pictureBox2.Image;


                    try
                    {
                        zdjecie.Save(nazwa);

                    }
                    catch (NullReferenceException)
                    {
                    }
                    catch (ArgumentException)
                    {
                    }
                    catch (IOException)
                    {
                    }


                }
            }
        }

        private void scalowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Image obraz = pictureBox2.Image;
            if (obraz == null)
            {
                MessageBox.Show("Nie otworzyłeś żadnego obrazu otwórz obraz ", "Brak zdjęcia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2 dialog = new Form2(obraz,true);
                dialog.Text = "Scalowanie";
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Size a = dialog.pobierzRozmiar();
                    Bitmap obrazek = new Bitmap(obraz, a);
                    pictureBox2.Image = obrazek;
                    pictureBox2.Size = new Size(pictureBox2.Image.Width, pictureBox2.Image.Height);
                    

                }
            }
        }

       

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBox2.Image = new Bitmap(10, 10);
            Image obraz = pictureBox2.Image;
            
                Form2 dialog = new Form2(obraz, false);
                dialog.Text = "Nowy";
               

                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Size a = dialog.pobierzRozmiar();
                    Bitmap obrazek = new Bitmap(obraz, a);
                    pictureBox2.Image = obrazek;
                    pictureBox2.Size = new Size(pictureBox2.Image.Width, pictureBox2.Image.Height);


                }
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                int rozmiar = Convert.ToInt32(textBox1.Text);
                if (rozmiar < sizeDefault || rozmiar > 50)
                    throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj rozmiar z zakresu od 0 do 50", "Zły Format rozmiaru", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rozmiar_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(rozmiar.Value);
        }

        private void defoult1_Paint(object sender, PaintEventArgs e)
        {
            if (default1.BackColor == Color.White)
            {
                sizeDefault = 1;
                textBox1.Text = Convert.ToString(sizeDefault);

            }
        }

        private void prawoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Nie otworzyłeś żadnego obrazu", "Brak zdjęcia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Image obraz = pictureBox2.Image;

                obraz.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox2.Image = obraz;
            }
        }

        private void lewoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Nie otworzyłeś żadnego obrazu", "Brak zdjęcia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Image obraz = pictureBox2.Image;

                obraz.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox2.Image = obraz;
            }
        }

        private void względemOsiXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Nie otworzyłeś żadnego obrazu", "Brak zdjęcia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Image obraz = pictureBox2.Image;

                obraz.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox2.Image = obraz;
            }
        }

        private void względemOsiYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Nie otworzyłeś żadnego obrazu", "Brak zdjęcia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Image obraz = pictureBox2.Image;

                obraz.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox2.Image = obraz;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choseItem = Item.wypel;
        }

        private void tekst_MouseClick(object sender, MouseEventArgs e)
        {
            var dial = new opcjeTekstu();
            dial.okOpcjeFontu += new opcjeTekstu.opcjeFontu(setTextDraw);
            dial.ShowDialog();

            
        }

        private void setTextDraw(FontFamily fontName, FontStyle fontStyle, float fontSize, String text, Color color)
        {
            referencja = new Tekst(color, (float)Convert.ToDouble(textBox1.Text), fontName, fontStyle, fontSize, text);

            choseItem = Item.tekst;
        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(printDocPrinter);
            drukujDialog.Document = printDoc;
            if (drukujDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void printDocPrinter(Object sender, PrintPageEventArgs e)
        {
            Bitmap myBitmap1 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.DrawToBitmap(myBitmap1, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
            e.Graphics.DrawImage(myBitmap1, 0, 0);
            myBitmap1.Dispose();
        }

        private void ądWydrukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(printDocPrinter);
            widokWydrukuDialog.Document = printDoc;
            if (widokWydrukuDialog.ShowDialog() == DialogResult.OK)
            {


            }
        }

        private void convertToMonochromate1BitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Nie otworzyłeś żadnego obrazu", "Brak zdjęcia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pictureBox2.Image = Konwersja.ConvertTo8Bit((Bitmap)pictureBox2.Image);


            }
        }

   
      
       

       
       

        

       
      

        
       






        }

    }