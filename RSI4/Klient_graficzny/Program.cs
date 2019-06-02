using Contract12;
using Klient_graficzny.ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient_graficzny
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ServiceReference1.StrumienClient client2 = new ServiceReference1.StrumienClient();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            //Download(client2);
           
            Application.Run(form);

            //ServiceReference2.StrumienClient client1 = new ServiceReference2.StrumienClient("WSDualHttpBinding_IStrumien");


            
           
           
            //Wyswietl(client2.Lista());


            //client2.Close();
            //Console.WriteLine();
            //Console.WriteLine("naciśniej enter aby zakończyć");
            //Console.ReadLine();
        }
        private static void Download2(ServiceReference1.StrumienClient client2) {

            String filePath = Path.Combine(System.Environment.CurrentDirectory, "klient.jpg");
            Console.WriteLine("wywoluje getMStream");
            Stream fs = null;
            long rozmiar;
            string nnn = "image.jpg";
            nnn = client2.getMStream(nnn, out rozmiar, out fs);
            filePath = Path.Combine(System.Environment.CurrentDirectory, nnn);

            ZapiszPlik(fs, filePath);
            
        }


        private static void Download(ServiceReference1.StrumienClient client2){

            String filePath = Path.Combine(System.Environment.CurrentDirectory, "klient.jpg");

           
            System.IO.Stream stream2 = client2.getStream("image.jpg");
            ZapiszPlik(stream2, filePath);
        }


        private static void Upload(ServiceReference1.StrumienClient client2,String nazwa) {
            Stream send = WyslijPlik(nazwa);
            client2.UploadStream(send);
        }

        private static void Upload2(ServiceReference1.StrumienClient client2, String nazwa,String opis)
        {
            client2.UploadMStream(nazwa, opis, WyslijMPlik(".\\"+nazwa,opis));           
          
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
            string filePath = Path.Combine(System.Environment.CurrentDirectory, ".\\" + nazwa );

            try
            {
                myFile = File.OpenRead(filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine(String.Format("Wyjątek otrwarcia pliku {0}", filePath));
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            return myFile;
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


        static public void Wyswietl(List<DaneObrazkow> lista)
        {
            foreach (DaneObrazkow o in lista)
            {
                Console.WriteLine("Nazwa: " + o.nazwa + " ,Opis:" + o.opis);
            }

        }
    }
}
