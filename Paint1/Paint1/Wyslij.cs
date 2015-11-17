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
        bool pauza = false;
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
        private void wyslanie(Object obaraz1)
        {
            var obraz = (Bitmap)obaraz1;
            if (portnaz !="") // Jeśli port nie wybrany 
            {
                int x = obraz.Height;
                int y = obraz.Width;
                      
                   
                    progressBar1.Invoke(new Action(delegate()
                    {
                        progressBar1.Minimum = 0;
                        progressBar1.Step = 1;
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = x * y;
                        progressBar1.Step = 1;
                    }));
                    
                   
                    SerialPort port = new SerialPort(portnaz, 2400, Parity.None, 8, StopBits.One);
                    try
                    {
                        port.Open();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Nie można otworzyć portu "+ portnaz);
                        return;

                    }
                    int c;
                    /*
                     * char koniec_lini = Convert.ToChar(3); "End TEXT"
                    char koniec_koniec = Convert.ToChar(0);
                     */
                    char koniec_lini = Convert.ToChar(3);
                    char koniec_koniec = Convert.ToChar(0);
                    char zero = '0';
                    char jeden = '1';

                    for (int i = 0; i <x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            while (pauza) ;
                        c = obraz.GetPixel(i, y).R;
                            switch (c)
                            {
                                case 0:
                                    port.Write(""+zero);
                                    port.ReadChar();
                                    break;
                                case 1:
                                    port.Write(""+jeden);
                                    port.ReadChar();
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
                        port.ReadChar();
                    }
                    /*
                     *Zamknięcie portu 
                     */
                    port.Write(""+koniec_koniec);
                    port.ReadChar();
                    port.Close();
                    /*
                     * Wyzerowanie progresbaru
                     */
                    progressBar1.Invoke(new Action(delegate()
                    {
                        progressBar1.Value = 0;
                    }));
                
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
                
                Thread thr = new Thread(new ParameterizedThreadStart(wyslanie));
                thr.Start(obraz);
            }
            else
            {
                MessageBox.Show("Otwórz najpier obraz do wysłania", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anulujWyslanie_Click(object sender, EventArgs e)
        {
            wylacz = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pauza = true;
            MessageBox.Show("Włączona Pauza");
            pauza = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obraz = (Bitmap)getObraz();
            if (obraz != null)
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = obraz.Width * obraz.Height;
                progressBar1.Step = 1;
                Thread thr = new Thread(napelnij);
                thr.Start();
            }
            else
            {
                MessageBox.Show("Otwórz najpier obraz do wysłania", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void napelnij()
        {
            if (portnaz != "") // Jeśli port nie wybrany 
            {
                SerialPort port = new SerialPort(portnaz, 2400, Parity.None, 8, StopBits.One);
                try
                {
                    port.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie można otworzyć portu " + portnaz);
                    return;
                }
                char koniec_lini = Convert.ToChar(3);
                char koniec_koniec = Convert.ToChar(0);
                char dwa = '2';
                char trzy = '3';

                while (!wylacz)
                {
                    while (pauza)
                    {
                        //zamknięcie zaworu ______________________________________________________________________________
                    }

                    port.Write("" + dwa);
                    port.ReadChar();

                }
                // zamknięcie zaworu
                port.Write("" + trzy);
                port.ReadChar();

                wylacz = false;
                /*
                 *Zamknięcie portu 
                 */
                port.Close();
                /*
                 * Wyzerowanie progresbaru
                 */
                progressBar1.Invoke(new Action(delegate()
                {
                    progressBar1.Value = 0;
                }));
            }
            else
            {
                MessageBox.Show("Nie wybrano portu.\nWybież port ", "Błędny port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
    

