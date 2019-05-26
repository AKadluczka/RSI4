using Klient12.ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Klient12
{
    class Program
    {
        static void Main(string[] args)
        {
            StrumienClient client2 = new StrumienClient();
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


            client2.Close();
            Console.WriteLine();
            Console.WriteLine("naciśniej enter aby zakończyć");
            Console.ReadLine();
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
    }
}