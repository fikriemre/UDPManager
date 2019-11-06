using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDPTEST
{
    public partial class Form1 : Form
    {

        UdpAl alici;
        UdpGonder gonderici;
        int ipcounter = 0;
        public Form1()
        {
            InitializeComponent();
            RichTextBox.CheckForIllegalCrossThreadCalls = false;
        }

        string[] gelenveriayril;
        int lastindex = 0;
        private void Almaislem()
        {
            gonderici.Send(gonderici.IP + " is now online");
            System.Threading.Thread.Sleep(100);
            while (true)
            {
                alici.Recieve();
                gelenveriayril = alici.GelenVeri.Split(':');
                if (cb_byte.Checked)
                {
                    for (int i = 0; i < 1024; i++)
                    {
                        richTextBox1.AppendText(" [" + alici.Data[i] + "] ");
                    }
                    richTextBox1.AppendText("\n");
                    richTextBox1.ScrollToCaret();
                    richTextBox1.Update();

                }
                else
                {
                    richTextBox1.AppendText(alici.GelenVeri + "\n");
                    richTextBox1.ScrollToCaret();
                    richTextBox1.Update();
                }
                System.Threading.Thread.Sleep(1);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            gonderici.Send(/*gonderici.IP + ": " + */textBox1.Text);
            textBox1.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           //gonderici.Send(gonderici.IP + " KONUSMADAN CIKTI");
           Environment.Exit(0);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys) (e.KeyChar) == Keys.Enter)
            {
                gonderici.Send(/*gonderici.IP + ": " + */textBox1.Text);
                textBox1.Clear();
            }
        }

        private void bt_ip_Click(object sender, EventArgs e)
        {
            gonderici = new UdpGonder(int.Parse(txt_port.Text));

            if (!cb_aliciyok.Checked)
            {
                alici = new UdpAl(txt_ip.Text, int.Parse(txt_port.Text), int.Parse(txt_bsize.Text));
                System.Threading.Thread alicithread = new System.Threading.Thread(Almaislem);
                alicithread.Start();
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            txt_ip.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList[ipcounter].ToString();
            ipcounter++;
            if (ipcounter == Dns.GetHostEntry(Dns.GetHostName()).AddressList.Length) ipcounter = 0;
            */
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    txt_ip.Text= ip.ToString();
                }
            }
           // throw new Exception("No network adapters with an IPv4 address in the system!");






        }

        private void richTextBox1_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
