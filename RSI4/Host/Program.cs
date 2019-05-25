using Serwis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;


namespace Host
{
    class Program
    {
       
            static void Main(string[] args)
            {
                Uri baseAddress = new Uri("http://localhost:8080/NazwaBazowa");

                ServiceHost mojHost = new ServiceHost(typeof(IService1), baseAddress);

                try
                {
                WSHttpBinding mojBinding = new WSHttpBinding();
                ServiceEndpoint endpoint1 = mojHost.AddServiceEndpoint(typeof(IService1), mojBinding, "endpoint1");    

                    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                    smb.HttpGetEnabled = true;
                    mojHost.Description.Behaviors.Add(smb);

                    mojHost.Open();
                    Console.WriteLine("Serwis jest uruchomiony");
                    Console.WriteLine("Naciśnij enter aby zakonczyc");
                    Console.WriteLine();
                    Console.ReadLine();
                    mojHost.Close();
                }
                catch (CommunicationException ce)
                {
                    Console.WriteLine("Wystąpił wyjątek {0}", ce.Message);
                    mojHost.Abort();
                }
            }
    }
}
