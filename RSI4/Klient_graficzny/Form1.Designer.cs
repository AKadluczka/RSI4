﻿using System;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;





        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "pobierz listę obrazków";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(254, 18);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(199, 20);
            this.progressBar1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 246);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 8);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "lista obrazów";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 283);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 19);
            this.button2.TabIndex = 7;
            this.button2.Text = "próbna";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 36);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 225);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 173);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private static void Download2(ServiceReference1.StrumienClient client2)
        {

            String filePath = Path.Combine(System.Environment.CurrentDirectory, "klient.jpg");
            Console.WriteLine("wywoluje getMStream");
            Stream fs = null;
            long rozmiar;
            string nnn = "image.jpg";
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

        


    }
}

