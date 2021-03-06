﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.Threading;
using Newtonsoft.Json;


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

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CallbackLista : ICallbackLista
    {
        public List<DaneObrazkow> result = new List<DaneObrazkow>();
        ICallbackHandler callback = null;

        public CallbackLista()
        {
            callback = OperationContext.Current.GetCallbackChannel<ICallbackHandler>();
        }

        public void ZwrocListe()
        {
            Console.Write("Wywołano Callback");
            Thread.Sleep(5000);
            callback.ZwrotListy();
        }

    }


    public class MojStrumien : IStrumien
    {
        public static void SaveFile(List<DaneObrazkow> baza)
        {
            using (StreamWriter file = File.CreateText(@"C:\path.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(file, baza);
            }
        }

        public static List<DaneObrazkow> CheckFile()
        {

            string json = File.ReadAllText(@"C:\path.txt");
            List<DaneObrazkow> baza = JsonConvert.DeserializeObject<List<DaneObrazkow>>(json);
            if (baza == null)
                baza = new List<DaneObrazkow>();

            if (baza.Count() > 0)
            {
                var firstElement = baza.First();
                //Console.Write(firstElement.nazwa);
                //Console.Write(firstElement.opis);
            }
            return baza;
        }


        public System.IO.Stream getStream(String data)
        {
            //List<DaneObrazkow> baza = CheckFile();         

            //SaveFile(baza);
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

        public ResponseFileMessage getMStream(RequestFileMessage request) 
        {
            ResponseFileMessage wynik = new ResponseFileMessage();
            string nazwa = request.nazwa1;

            FileStream myFile;
            Console.WriteLine("-->wywolano getStream");

            wynik.nazwa2 = ".\\" + request.nazwa1;

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

        public ResponseFileUpload UploadMStream(RequestFileUpload request)
        {
            Console.WriteLine("Wywołano mstreamupload");
            ResponseFileUpload wynik = new ResponseFileUpload();
            Boolean duplicates = false;
            List<DaneObrazkow> baza = CheckFile();
            foreach (DaneObrazkow db in baza) {
                if (db.nazwa.Equals(request.nazwa))
                    duplicates = true;
               
            }
            if (duplicates == false) {              
            System.IO.Stream myFile = request.dane;
            String filePath = Path.Combine(System.Environment.CurrentDirectory, request.nazwa);
            ZapiszPlik(myFile, filePath);
            DaneObrazkow obiekt = new DaneObrazkow();
            obiekt.nazwa = request.nazwa;
            obiekt.opis = request.opis;
            baza.Add(obiekt);
            SaveFile(baza);
            }

            wynik.msg = "Zakonczono";
            Console.WriteLine("Zakonczono mstreamupload");
            

            return wynik;
        }

        public bool UploadStream(Stream file)
        {
            List<DaneObrazkow> baza = CheckFile();
            String filePath = Path.Combine(System.Environment.CurrentDirectory, "nowyplik.jpg");
            DaneObrazkow obiekt = new DaneObrazkow();
            obiekt.nazwa = "nazwa";
            obiekt.opis = "opis";

            baza.Add(obiekt);
            Console.WriteLine("Dodano plik wielkosc: " + baza.Count());
            Console.WriteLine("Wywoałanie uploadu()");
            System.IO.Stream stream2 = file;
            ZapiszPlik(stream2, filePath);
            SaveFile(baza);


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
            try
            {
                FileStream outstream = File.Open(filePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);

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
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

            Console.WriteLine();
            Console.WriteLine("-->Plik {0} zapisany", filePath);
        }

        public List<DaneObrazkow> Lista()
        {
            return CheckFile();
        }
    }
    public struct DaneObrazkow
    {
        public String nazwa;
        public String opis;
    }



}


