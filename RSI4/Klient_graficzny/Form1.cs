using Contract12;
using Klient_graficzny.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient_graficzny
{
    public partial class Form1 : Form
    {
        ServiceReference1.StrumienClient client2;
        public Form1()
        {
            client2 = new ServiceReference1.StrumienClient();
            InitializeComponent();
        }
        /*
        protected void Page_Load(object sender, EventArgs e)
        {
            DaneObrazkow[] list = client2.Lista();


            if (list.Length != 0)
            {
                RadioButton rb = new RadioButton();
                for (int i = 0; i < list.Length; i++)
                {

                    rb.Text = list[i].nazwa;
                    groupBox1.Controls.Add(rb);
                }
            }
            
        }*/

        public static int interwal = 0;

        private void timer1_Tick(object sander, EventArgs e)
        {
            interwal += 1;
            progressBar1.Increment(interwal);
        }

        private void button1_Click(object sander, EventArgs e)
        {
             DaneObrazkow[] list = client2.Lista();
            /*
             DaneObrazkow do1 = new DaneObrazkow();
             do1.nazwa = "nazwa1";
             do1.opis = "opis";

             DaneObrazkow do2 = new DaneObrazkow();
             do2.nazwa = "nazwa2";
             do2.opis = "opis";

             DaneObrazkow do3 = new DaneObrazkow();
             do3.nazwa = "nazwa3";
             do3.opis = "opis";

            DaneObrazkow do4 = new DaneObrazkow();
            do4.nazwa = "nazwa4";
            do4.opis = "opis";

            DaneObrazkow do5 = new DaneObrazkow();
            do5.nazwa = "nazwa5";
            do5.opis = "opis";

            DaneObrazkow[] list = new DaneObrazkow[] { do1, do2, do3, do4, do5 };
            */

             if (list.Length != 0)
             {

                
                RadioButton rb = new RadioButton();
                rb.Location = new System.Drawing.Point(10, 10);

                for (int i = 0; i < list.Length; i++)
            {
                    if (i == 0)
                    {
                        rb.Text = list[i].nazwa + ", " + list[i].opis;
                        listBox1.Controls.Add(rb);
                    }
                    else
                    {
                        RadioButton rbn = new RadioButton();
                        rbn.Text = list[i].nazwa+", "+ list[i].opis;
                        rbn.Location = new System.Drawing.Point(rb.Location.X, rb.Location.Y + (i*rb.Height));
                        listBox1.Controls.Add(rbn);
                    }

                }
            

        } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            // String nazwa = listBox1.Text;
            String nazwa = "klient.jpg";

            String filePath = Path.Combine(System.Environment.CurrentDirectory,nazwa);
            
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox1.Image = Image.FromFile(filePath);


            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            progressBar1.Value = 0;
        }

        private void pictureBox1_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
