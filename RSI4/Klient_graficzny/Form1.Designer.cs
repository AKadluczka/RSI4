using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Klient_graficzny.ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contract12;

namespace Klient_graficzny
{
    partial class Form1 : Form
    {
        

       
           
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;





        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "pobierz listę obrazków";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(339, 11);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(265, 25);
            this.progressBar1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 306);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 276);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "ładowanie zdj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(28, 36);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 292);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(339, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 232);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(689, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(689, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(339, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "upload";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(78, 392);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "opis";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(469, 347);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "download";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "lista plików";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 19;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        


        


        

        private void checkedListBox1_Click(object sander, EventArgs e)
        {
            timer1.Start();
            /* trzeba wyswietlic odpowiednie zdj*/
            
            string path = Path.Combine(System.Environment.CurrentDirectory, "image.jpg");
            string text = "tekst z nacisnietego zdj";
           
                    

             pictureBox1.Image = Image.FromFile(path);
            textBox1.Text = text;
              
            if (progressBar1.Value > progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
            }
            else
            {
                timer1.Stop();

            }
        }
        private static void Download2(ServiceReference1.StrumienClient client2, String nazwa)
        {

            String filePath = Path.Combine(System.Environment.CurrentDirectory, nazwa);
            Console.WriteLine("wywoluje getMStream");
            Stream fs = null;
            long rozmiar;
            string nnn = nazwa;
            nnn = client2.getMStream(nnn, out rozmiar, out fs);
            filePath = Path.Combine(System.Environment.CurrentDirectory, nnn);
            ZapiszPlik(fs, filePath);

        }


        private static void Download(ServiceReference1.StrumienClient client2)
        {

            String filePath = Path.Combine(System.Environment.CurrentDirectory, "klient.jpg");


            System.IO.Stream stream2 = client2.getStream("image.jpg");
            ZapiszPlik(stream2, filePath);
        }


        private static void Upload(ServiceReference1.StrumienClient client2, String nazwa)
        {
            Stream send = WyslijPlik(nazwa);
            client2.UploadStream(send);
        }


        private static void Wyswietl(DaneObrazkow[] daneObrazkow)
        {

            List<DaneObrazkow> lista = daneObrazkow.ToList<DaneObrazkow>();
            Console.WriteLine("Wywołano wyświetlanie " + lista.Count());
            foreach (DaneObrazkow o in lista)
            {
                Console.WriteLine("Nazwa: " + o.nazwa + " ,Opis:" + o.opis);
            }
        }

        private Button button5;
        private Button button3;
        private Button button4;
        private ListBox listBox1;

        static void ZapiszPlik(System.IO.Stream instream, string filePath)
        {
            const int bufferLength = 8192;
            int bytecount = 0;
            int counter = 0;

            byte[] buffer = new byte[bufferLength];
            Console.WriteLine("--->Zapisuje plik {0}", filePath);
            FileStream outstream = File.Open(filePath, FileMode.Create, FileAccess.Write);

            while ((counter = instream.Read(buffer, 0, bufferLength)) > 0)
            {
                outstream.Write(buffer, 0, counter);
                Console.Write(".{0}", counter);
                bytecount += counter;
            }
            Console.WriteLine();
            Console.WriteLine("Zapisano {0} bajtów", bytecount);

            outstream.Close();
            instream.Close();
            Console.WriteLine();
            Console.WriteLine("-->Plik {0} zapisany", filePath);
        }

        static public System.IO.Stream WyslijPlik(String nazwa)
        {
            FileStream myFile;
            Console.WriteLine("-->wywolano upload");
            string filePath = Path.Combine(System.Environment.CurrentDirectory, ".\\" + nazwa);

            try
            {
                myFile = File.OpenRead(filePath);
               // Console.WriteLine(String.Format("poszło"));
            }
            catch (IOException ex)
            {
                Console.WriteLine(String.Format("Wyjątek otrwarcia pliku {0}", filePath));
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            return myFile;
        }

        static public void Wyswietl(List<DaneObrazkow> lista)
        {
            foreach (DaneObrazkow o in lista)
            {
                Console.WriteLine("Nazwa: " + o.nazwa + " ,Opis:" + o.opis);
            }

        }

        private static void Upload2(ServiceReference1.StrumienClient client2, String nazwa, String opis)
        {
            client2.UploadMStream(nazwa, opis, WyslijMPlik(".\\" + nazwa, opis));

        }

        static public Stream WyslijMPlik(String nazwa, String opis)
        {
            ServiceReference1.RequestFileUpload wynik = new ServiceReference1.RequestFileUpload();
            wynik.nazwa = nazwa;

            FileStream myFile;
            Console.WriteLine("-->wywolano getStream");

            //wynik.nazwa2 = ".\\image.jpg";

            try
            {
                myFile = File.OpenRead(wynik.nazwa);
            }
            catch (IOException ex)
            {
                Console.WriteLine(String.Format("Wyjątek otrwarcia pliku {0}", wynik.opis));
                Console.WriteLine(ex.ToString());
                throw ex;
            }

            //wynik.rozmiar = myFile.Length;
            //wynik.dane = myFile;
            return myFile;
        }
        private Button button6;
        private Button button7;
        private Label label1;
        private Label label2;
    }
}

