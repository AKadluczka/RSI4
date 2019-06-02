using Contract12;
using Klient_graficzny.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient_graficzny { 
class CallbackHandler : ICallbackListaCallback
{
        public void ZwrotListy()
        {
            Form1.ustawLabel();
        }       
}
}

