using Contract12;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Host12
{
    class Program
    {

        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/NazwaBazowa");

            ServiceHost mojHost = new ServiceHost(typeof(MojStrumien), baseAddress);
           
            Uri adress2 = new Uri("http://localhost:8080/InnySerwis");
            ServiceHost drugiHost = new ServiceHost(typeof(MojStrumien), adress2);
            WSDualHttpBinding binding2 = new WSDualHttpBinding();



            try
            {
                ServiceEndpoint endpoint2 = drugiHost.AddServiceEndpoint(typeof(IStrumien), binding2, "Callback Lista");

                BasicHttpBinding b = new BasicHttpBinding();
                b.TransferMode = TransferMode.Streamed;
                b.MaxReceivedMessageSize = 1000000000;
                b.MaxBufferSize = 8192;

                ServiceEndpoint endpoint1 = mojHost.AddServiceEndpoint(typeof(IStrumien), b, "endpoint1");



                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                mojHost.Description.Behaviors.Add(smb);
                ServiceMetadataBehavior smb2 = new ServiceMetadataBehavior();
                smb2.HttpGetEnabled = true;
                drugiHost.Description.Behaviors.Add(smb2);




                mojHost.Open();
                Console.WriteLine("Serwis jest uruchomiony");
                Console.WriteLine("Naciśnij enter aby zakonczyc");

                drugiHost.Open();
                Console.WriteLine("Callback uruchomiony.");
                Console.WriteLine();

                Console.WriteLine();
                Console.ReadLine();



                drugiHost.Close();
                mojHost.Close();



            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Wystąpił wyjątek {0}", ce.Message);
                drugiHost.Abort();
                mojHost.Abort();

            }
        }
    }
}

    
