using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Contract12
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }

    public class MojStrumien : IStrumien
    {
        public System.IO.Stream getStream(String data)
        {
            FileStream myFile;
            Console.WriteLine("-->wywolano getStream");
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

        public ResponseFileMessage getMStream(RequestFileMessage request) //nie wiem jak to tu ma byc zrobione ;/
        {
            ResponseFileMessage wynik = new ResponseFileMessage();
            string nazwa = request.nazwa1;

            FileStream myFile;
            Console.WriteLine("-->wywolano getStream");

            wynik.nazwa2 = ".\\image.jpg";

            try
            {
                myFile = File.OpenRead(wynik.nazwa2);
            }
            catch (IOException ex)
            {
                Console.WriteLine(String.Format("Wyjątek otrwarcia pliku {0}", wynik.nazwa2));
                Console.WriteLine(ex.ToString());
                throw ex;
            }

            wynik.rozmiar = myFile.Length;
            wynik.dane = myFile;
            return wynik;
        }

        public bool UploadStream(Stream file)
        {
            
            String filePath = Path.Combine(System.Environment.CurrentDirectory,"nowyplik.jpg");

            Console.WriteLine("Wywoałanie uploadu()");
            System.IO.Stream stream2 = file;
            ZapiszPlik(stream2, filePath);


            

        
            Console.WriteLine("koniec uploadu");

            return true;
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
    }

}
