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
    }

}
