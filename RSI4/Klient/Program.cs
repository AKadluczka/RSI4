using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klient
{
    

    class Program
    {
        static void Main(string[] args)
        {

            /*nie do końca wiem gdzie to dac.
     * 
    class CallbackHandler : ICallbacKalkulatorCallback
    {
        public void ZwrotSilnia(double result)
        {
            Console.WriteLine("silnia = {0}", result);
        }
        public void ZwrotObliczCos(String info)
        {
            Console.WriteLine("Obliczenia: {0}", info);
        }
    }*/

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
