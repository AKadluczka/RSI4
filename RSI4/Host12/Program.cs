using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace Host12
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/NazwaBazowa");

            ServiceHost mojHost = new ServiceHost(typeof(MojStrumien), baseAddress);

            

            try
            {
                BasicHttpBinding b = new BasicHttpBinding();
                b.TransferMode = TransferMode.Streamed;
                b.MaxReceivedMessageSize = 1000000000;
                b.MaxBufferSize = 8192;

                ServiceEndpoint endpoint1 = mojHost.AddServiceEndpoint(typeof(MojStrumien), b, "endpoint1");



                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                mojHost.Description.Behaviors.Add(smb);

                ServiceMetadataBehavior smb2 = new ServiceMetadataBehavior();
                smb2.HttpGetEnabled = true;
                drugiHost.Description.Behaviors.Add(smb2);

                mojHost.Open();
                Console.WriteLine("Serwis jest uruchomiony");
                Console.WriteLine("Naciśnij enter aby zakonczyc");
                Console.WriteLine();
                Console.ReadLine();

                drugiHost.Open();
                Console.WriteLine("CallbackKalkulator uruchomiony.");


                mojHost.Close();
                drugiHost.Close();


            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Wystąpił wyjątek {0}", ce.Message);
                mojHost.Abort();
                drugiHost.Abort();
            }
        }
    }
}
