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
        Bitmap obraz;
        String portnaz = "";
        public Wyslij(Image bitmap)
        {
            InitializeComponent();

            obraz = (Bitmap)bitmap;
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

        private void PortChB_SelectedValueChanged(object sender, EventArgs e)
        {
            portnaz = PortChB.SelectedItem.ToString();
        }

        bool wylacz = false;
        private void wyslanie()
        {
            SerialPort port = new SerialPort(portnaz);
                port.Open();
                int c;
                

                for (int x = 0; x < obraz.Width; x++)
                {
                    for (int y = 0; y < obraz.Height; y++)
                    {
                        c = obraz.GetPixel(x, y).R;
                        switch (c)
                        {
                            case 0:
                                port.Write("0");

                                break;
                            case 255:
                                port.Write("1");
                                break;
                            default:
                                MessageBox.Show("c = " + c);
                                break;
                        }
                        port.Read(new char[20], 0, 15);


                        System.Threading.Thread.Sleep(1000);
                        
                        progressBar1.Invoke(new Action(delegate()
                                            {
                                                progressBar1.PerformStep();
                                             }));
                        if (wylacz)
                        {
                            x = obraz.Width;
                            y = obraz.Height;
                            progressBar1.Invoke(new Action(delegate()
                            {
                                progressBar1.Value = 0;
                            }));
                            wylacz = false;
                        }
                    }
                }

                port.Close();
                progressBar1.Invoke(new Action(delegate()
                {
                    progressBar1.Value = 0;
                }));
            

        }
        private void wyslijB_Click(object sender, EventArgs e)
        {
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
    }
}
    

