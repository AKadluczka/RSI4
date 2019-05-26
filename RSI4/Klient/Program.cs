using Klient.ServiceReference1;
using Klient.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klient
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Service1Client serwisClient = new Service1Client("WSHttpBinding_IService1");
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            Console.Write("\nKLIENT1");
            Console.WriteLine("wywolanie fkcj1");
            serwisClient.Funkcja1("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("kontynuacja fkcj1");

            Console.WriteLine("wywolanie fkcj2");
            serwisClient.Funkcja1("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("kontynuacja fkcj2");

            Console.WriteLine("wywolanie fkcj1");
            serwisClient.Funkcja2("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("kontynuacja fkcj1");
            serwisClient.Close();
            Console.Write("KONIEC KLIENT1");


            Console.WriteLine("\nKLIENT2:");
            CallbackHandler mojCallbackHandler = new CallbackHandler();
            InstanceContext instanceContext = new InstanceContext(mojCallbackHandler);
            CallbackKalkulatorClient client2 = new CallbackKalkulatorClient(instanceContext);

            double value1 = 10;
            Console.WriteLine("...wywoluje silnia({0})", value1);
            client2.Silnia(value1);

             value1 = 20;
            Console.WriteLine("...wywoluje silnia({0})", value1);
            client2.Silnia(value1);

            int value2= 2;
            Console.WriteLine("...wywoluje obliczenia cosia", value1);
            client2.ObliczCos(value2);
            Console.WriteLine("czekam na obliczenia");
            Thread.Sleep(5000);
            client2.Close();
            Console.WriteLine("KONIEC KLIENT2");


            



            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    
}
