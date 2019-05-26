using CallbackContrakt;
using Klient.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klient
{
    class CallbackHandler : ICallbackKalkulatorCallback
    {
        public void ZwrotSilnia(double result)
        {
            Console.WriteLine("silnia = {0}", result);
        }
        public void ZwrotObliczCos(String info)
        {
            Console.WriteLine("Obliczenia: {0}", info);
        }


    }
}

