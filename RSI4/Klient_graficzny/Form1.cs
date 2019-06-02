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
            // DaneObrazkow[] list = client2.Lista();

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


             if (list.Length != 0)
             {


                //RadioButton rb;
                /*= new RadioButton();
        rb.Text = "nazwa1";
        rb.Location = new System.Drawing.Point(17, 22);
        listBox1.Controls.Add(rb);

        RadioButton rb3 = new RadioButton();
        rb3.Text = "nazwa3";
        rb3.Location = new System.Drawing.Point(rb.Location.X, rb.Location.Y + rb.Height);
        listBox1.Controls.Add(rb3);

        RadioButton rb2 = new RadioButton();
        rb2.Text = "nazwa2";
        rb2.Location = new System.Drawing.Point(rb.Location.X, rb3.Location.Y + rb.Height);
        listBox1.Controls.Add(rb2);*/


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
            // addRadioButton(groupBox1, rbList);

        } 
        }/*
        public void addRadioButton(GroupBox gb,  Control[] rb)
        {
            gb.Controls.AddRange(rb);
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            // String nazwa = listBox1.Text;
            String nazwa = "klient.jpg";

            String filePath = Path.Combine(System.Environment.CurrentDirectory,nazwa);
            
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox1.Image = Image.FromFile(filePath);


            timer1.Stop();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
