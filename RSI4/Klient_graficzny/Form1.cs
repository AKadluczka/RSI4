using Contract12;
using Klient_graficzny.ServiceReference1;
using Klient_graficzny.ServiceReference2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient_graficzny
{
    public partial class Form1 : Form
    {
        
        ServiceReference1.StrumienClient client2;

        CallbackListaClient callbackLista;
        public Form1()
        {
            CallbackHandler mojCallbackHandler = new CallbackHandler();
            InstanceContext instanceContext = new InstanceContext(mojCallbackHandler);
            callbackLista = new CallbackListaClient(instanceContext);

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
             do1.nazwa = "klient.jpg";
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
                        rb.Text = list[i].nazwa;
                        listBox1.Controls.Add(rb);
                    }
                    else
                    {
                        RadioButton rbn = new RadioButton();
                        rbn.Text = list[i].nazwa;
                       
                        rbn.Location = new System.Drawing.Point(rb.Location.X, rb.Location.Y + (i*rb.Height));
                        listBox1.Controls.Add(rbn);
                    }

                }
            

        } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                var checkedButton = listBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                String name = checkedButton.Text;

                String filePath = Path.Combine(System.Environment.CurrentDirectory, name);

                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                pictureBox1.Image = Image.FromStream(stream);
                stream.Close();

                //pictureBox1.Image = Image.FromFile(filePath);
                //Image.FromFile(filePath).Dispose();
            } catch(Exception ee) {
                textBox1.Text = "brak zdjecia";
            }
            

    
            
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

        private void button5_Click(object sender, EventArgs e)
        {
            int temp = client2.Lista().Length;
            String name = textBox1.Text;
            Upload2(client2, name, textBox2.Text);
            if (temp == client2.Lista().Length)
                label6.Text = "Upload nieudany, plik juz istnieje";
            else
                label6.Text = "Zuploadowano " + textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var checkedButton = listBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

           
            String nazwa = checkedButton.Text;
            String opis = "";
            DaneObrazkow[] list = client2.Lista();
            for(int i =0; i<list.Length; i++)
            {
                if (nazwa == list[i].nazwa) opis = list[i].opis;
            }


            label2.Text = opis;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            var checkedButton = listBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            Download2(client2, checkedButton.Text);
            label6.Text = "Pobrano " + checkedButton.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            label3.Text = "Trwa konwersja prosze czekac";
            callbackLista.ZwrocListe();
            
            //label3.Text = "Przekonwertowano";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public static void ustawLabel() {
            label3.Text = "przekonwertowano";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
