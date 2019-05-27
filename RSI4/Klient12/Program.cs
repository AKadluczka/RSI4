using Contract12;
using Klient12.ServiceReference2;
using Klient12.ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Klient12
{
    class Program
    {
        static void Main(string[] args)
        {

            //ServiceReference2.StrumienClient client1 = new ServiceReference2.StrumienClient("WSDualHttpBinding_IStrumien");
            ServiceReference1.StrumienClient client2 = new ServiceReference1.StrumienClient();
            String filePath = Path.Combine(System.Environment.CurrentDirectory, "klient.jpg");

            Console.WriteLine("Wywoałanie getStream()");
            System.IO.Stream stream2 = client2.getStream("image.jpg");
            ZapiszPlik(stream2, filePath);

            Console.WriteLine("wywoluje getMStream");
            Stream fs = null;
            long rozmiar;
            string nnn = "image.jpg";
            nnn = client2.getMStream(nnn, out rozmiar, out fs);
            filePath = Path.Combine(System.Environment.CurrentDirectory, nnn);

            ZapiszPlik(fs, filePath);
            Console.WriteLine("koniec getMStream");

            Stream send = WyslijPlik();
            client2.UploadStream(send);
            Thread.Sleep(3000);
            Wyswietl(client2.Lista());
            

            client2.Close();
            Console.WriteLine();
            Console.WriteLine("naciśniej enter aby zakończyć");
            Console.ReadLine();
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

        static public System.IO.Stream WyslijPlik()
        {
            FileStream myFile;
            Console.WriteLine("-->wywolano upload");
            string filePath = Path.Combine(System.Environment.CurrentDirectory, ".\\image.jpg");

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

        static public void Wyswietl(List<DaneObrazkow> lista) {
            foreach (DaneObrazkow o in lista) {
                Console.WriteLine("Nazwa: " + o.nazwa + " ,Opis:" + o.opis);
            }
        }
    }
}