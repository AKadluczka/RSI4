using Contract12;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace CallbackContrakt
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
        List<DaneObrazkow> result;
        ICallbackHandler callback = null;

        public CallbackLista()
        {
            callback = OperationContext.Current.GetCallbackChannel<ICallbackHandler>();
        }

        public void ZwrocListe() {

            callback.ZwrotListy(result);
        }
    
    }

    

    
}
