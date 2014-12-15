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
    /// <summary>
    /// Form służaca do scalowania obrazów 
    /// </summary>
    public partial class Form2 : Form
    {
        public int wysokosc, szerokosc;
        Boolean bylBlad = false;
        /// <summary>
        /// konstruktor pobierający obraz z którego są wyciąganie wysokość i szerokość obrazu
        /// </summary>
        /// <param name="obraz">obraz który będziemy scalować</param>
        public Form2(Image obraz)
        {
            wysokosc = obraz.Height;
            szerokosc = obraz.Width;

            InitializeComponent();
            textBox1.Text = "" + wysokosc;
            textBox2.Text = "" + szerokosc;
            checkBox1.Visible = false;
        }
        public Form2( Image obraz, Boolean checboxVisible )
        {


            wysokosc = obraz.Height;
            szerokosc = obraz.Width;

            InitializeComponent();
            textBox1.Text = "" + wysokosc;
            textBox2.Text = "" + szerokosc;
            checkBox1.Visible = checboxVisible;
           

            
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Zwraca nowy rozmiar podany przez użytkownika</returns>
        public Size pobierzRozmiar()
        {


            return new Size(szerokosc, wysokosc);
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!bylBlad)
            {
                wysokosc = Convert.ToInt32(textBox1.Text);
                szerokosc = Convert.ToInt32(textBox2.Text);
            }
           
            
        }

       
        /// <summary>
        /// Gdy zostanie usunięty  focus z pola służącego do podania wysokości, następuje walidacja pola, 
        /// oraz gdy zaznaczona opcja zachowaj proporcje automatyczne uzupełnienie szerokości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Leave(object sender, EventArgs e)
        {
            int boffWysokosc=0;
            bylBlad = false;
            button1.DialogResult = DialogResult.OK;
            try
            {
                boffWysokosc = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException)
            {
                bylBlad = true;
                button1.DialogResult = DialogResult.None;
            }
            
           
            if (checkBox1.Checked && !bylBlad)
            {
                textBox2.Text = "" + ((boffWysokosc * szerokosc) / wysokosc);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            int boffSzerokosc = 0;
            bylBlad = false;
            button1.DialogResult = DialogResult.OK;
            try
            {
                boffSzerokosc = Convert.ToInt32(textBox2.Text);
            }
            catch (FormatException)
            {
                bylBlad = true;
                button1.DialogResult = DialogResult.None;
            }
            if (checkBox1.Checked && !bylBlad)
            {
                textBox1.Text = "" + ((boffSzerokosc * wysokosc) / szerokosc);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

       

      
    }
}
