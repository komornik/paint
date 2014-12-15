using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    

    public partial class opcjeTekstu : Form
    {
        public delegate void opcjeFontu(FontFamily fontName, FontStyle fontStyle, float fontSize, String text, Color color);
        public event opcjeFontu okOpcjeFontu;

        ColorDialog dialog = new ColorDialog();
        private int [] rozmiaryCzcionki = { 2, 4, 6, 8, 9, 10, 11, 12, 16 , 18, 20, 32 };
        private String [] style= {"Normalny" , "Pogrubiny" , "Pochyły" , "Podkreślony" };
        private FontFamily fontName = new FontFamily("Arial");
        private float fontSize= 8;
        private FontStyle fontStyle = FontStyle.Regular;

        public opcjeTekstu()
        {
            InitializeComponent();
        }

        private void kolor_MouseClick(object sender, MouseEventArgs e)
        {
            dialog.ShowDialog();
            kolor.BackColor = dialog.Color;
            textBox1.ForeColor = kolor.BackColor;


        }

        private void opcjeTekstu_Load(object sender, EventArgs e)
        {
            FontFamily[] rodzajeCzionki = FontFamily.Families;
            foreach (FontFamily font in rodzajeCzionki)
            {
                rodzajCzcionki.Items.Add(font.GetName(1).ToString());
            }
            foreach (int i in rozmiaryCzcionki)
            {
                wielkosc.Items.Add(Convert.ToString(i));
            }
            styl.Items.AddRange(style);
            rodzajCzcionki.SelectedIndex = 0;
            wielkosc.SelectedIndex = 0;
            styl.SelectedIndex = 0;

            fontName = new FontFamily(rodzajCzcionki.Text);
            fontSize = (float)Convert.ToDouble(wielkosc.Text);
            fontStyle = pobierzStyl(styl.Text);

            textBox1.Font = new Font(fontName, fontSize, fontStyle);
            
            
        }

        private FontStyle pobierzStyl(String rodzaj)
        {
            switch (rodzaj)
            {
                case ("Normalny") :
                    return FontStyle.Regular;
                break;
                case ("Pogrubiny"):
                    return FontStyle.Bold;
                break;
                case ("Pochyły"):
                     return FontStyle.Italic;
                break;
                case ("Podkreślony"):
                    return FontStyle.Underline;
                break;

            }

            return FontStyle.Regular;
        }

        private void rodzajCzcionki_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontName = new FontFamily(rodzajCzcionki.Text);
            textBox1.Font = new Font(fontName, fontSize, fontStyle);
            
        }

        private void styl_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontStyle = pobierzStyl(styl.Text);
            textBox1.Font = new Font(fontName, fontSize, fontStyle);
        }

        private void wielkosc_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontSize = (float)Convert.ToDouble(wielkosc.Text);
            textBox1.Font = new Font(fontName, fontSize, fontStyle);
        }

        private void OK_MouseClick(object sender, MouseEventArgs e)
        {
            okOpcjeFontu(fontName, fontStyle, fontSize, textBox1.Text, kolor.BackColor);
        }
    }
}
