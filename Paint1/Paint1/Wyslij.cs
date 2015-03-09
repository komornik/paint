using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Paint
{
    public partial class Wyslij : Form
    {
        public delegate Image pobierzObraz();
        pobierzObraz getObraz;
        Bitmap obraz;
        String portnaz = "";
        public Wyslij(string i, pobierzObraz pobierzImage)
        {
            InitializeComponent();
            getObraz = pobierzImage;
            obraz = (Bitmap)getObraz();
            string[] ports = SerialPort.GetPortNames();
            PortChB.Items.Clear();
            PortChB.Items.AddRange(ports);
           
        }
        
        private void PortChB_Click(object sender, EventArgs e)
        {
            string[] porty = SerialPort.GetPortNames();
            PortChB.Items.Clear();
            PortChB.Items.AddRange(porty);

        }
        /// <summary>
        /// Wybór portu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PortChB_SelectedValueChanged(object sender, EventArgs e)
        {
            portnaz = PortChB.SelectedItem.ToString();
        }

        bool wylacz = false;
        /// <summary>
        /// Wysałanie Zdjęcia 
        /// 
        /// </summary>
        private void wyslanie()
        {
            
            if (portnaz !="") // Jeśli port nie wybrany 
            {
                
                if (rozmiar_X.Text != "" && rozmiar_Y.Text != "")
                {
                    /* rozwiązanie tymczasowe dla tablicy zer i jedynek*/
                    int x, y;
                    try
                    {
                        x = Convert.ToInt32(rozmiar_X.Text);
                        y = Convert.ToInt32(rozmiar_Y.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Rozmiar musi byc liczbą całkowitą", "Zły format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        x = 0;
                        y = 0;
                    }
                    catch (Exception ex)
                    {
                        x = 0;
                        y = 0;
                    }
                    progressBar1.Invoke(new Action(delegate()
                    {
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = x * y;
                        progressBar1.Step = 1;
                    }));
                    
                    MessageBox.Show("X: " + x + " Y: " + y);
                    byte [][] tab = new byte[x][];
                    for(int i=0; i<x;i++){
                        tab[i] = new byte[y];
                        for(int j=0;j<y;j++){
                            if (j%2==0){
                                tab[i][j]=1;
                            }
                        }
                       
                    }
                    SerialPort port = new SerialPort(portnaz);
                    port.Open();
                    int c;
                    /*
                     * char koniec_lini = Convert.ToChar(3); "End TEXT"
                    char koniec_koniec = Convert.ToChar(0);
                     */
                    char koniec_lini = Convert.ToChar(3);
                    char koniec_koniec = Convert.ToChar(0);

                    for (int i = 0; i <x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            c = tab[i][j];
                            switch (c)
                            {
                                case 0:
                                    port.Write("0");

                                    break;
                                case 1:
                                    port.Write("1");
                                    break;
                                default:
                                    MessageBox.Show("c = " + c);
                                    break;
                            }
                            progressBar1.Invoke(new Action(delegate()
                            {
                                //obsługa progres baru 
                                progressBar1.PerformStep();
                            }));
                            if (wylacz)
                            {
                                //akcja po kliknięciu Anuluj 
                                i = x;
                                j = y;

                                progressBar1.Invoke(new Action(delegate()
                                {
                                    progressBar1.Value = 0;
                                }));
                                wylacz = false;
                            }
                        }
                        port.Write(""+koniec_lini); //oznaczenie końca lini
                    }
                    /*
                     *Zamknięcie portu 
                     */
                    port.Write(""+koniec_koniec);
                    port.Close();
                    /*
                     * Wyzerowanie progresbaru
                     */
                    progressBar1.Invoke(new Action(delegate()
                    {
                        progressBar1.Value = 0;
                    }));
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano portu.\nWybież port ", "Błędny port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }
        private void wyslijB_Click(object sender, EventArgs e)
        {
            obraz = (Bitmap)getObraz();
            if (obraz != null)
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = obraz.Width * obraz.Height;
                progressBar1.Step = 1;
                Thread thr = new Thread(wyslanie);
                thr.Start();
            }
        }

        private void anulujWyslanie_Click(object sender, EventArgs e)
        {
            wylacz = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
    

