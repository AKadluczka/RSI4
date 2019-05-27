
using CallbackContrakt;
using Service;
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

                ServiceHost mojHost = new ServiceHost(typeof(Service.Service1), baseAddress);

                Uri adress2 = new Uri("http://localhost:8080/InnySerwis");
                ServiceHost drugiHost = new ServiceHost(typeof(CallbackLista), adress2);
                WSDualHttpBinding binding2 = new WSDualHttpBinding();

            try
                {
                WSHttpBinding mojBinding = new WSHttpBinding();
                ServiceEndpoint endpoint1 = mojHost.AddServiceEndpoint(typeof(Service.IService1), mojBinding, "endpoint1");

                ServiceEndpoint endpoint2 = drugiHost.AddServiceEndpoint(typeof(ICallbackLista), binding2, "Callback Kalkulator");


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
                    Console.WriteLine("CallbackKalkulator uruchomiony.");
                    Console.WriteLine();
                    Console.ReadLine();

                   
                    

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
