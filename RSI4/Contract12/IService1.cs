using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Contract12 { 

    [ServiceContract]
public interface IStrumien
{

        [OperationContract]
        ResponseFileMessage getMStream(RequestFileMessage request);

        [OperationContract]
        ResponseFileUpload UploadMStream(RequestFileUpload request);

        [OperationContract]
        bool UploadStream(Stream file);

        [OperationContract]
         System.IO.Stream getStream(String nazwa);

        [OperationContract]
        List<DaneObrazkow> Lista();
    }

    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(ICallbackHandler))]
    public interface ICallbackLista
    {

        [OperationContract(IsOneWay = true)]
        void ZwrocListe();
    }

    public interface ICallbackHandler
    {
        [OperationContract(IsOneWay = true)]
        void ZwrotListy(List<DaneObrazkow> result);

    }

    [MessageContract]
    public class RequestFileUpload {
        [MessageHeader]
        public string nazwa;
        [MessageHeader]
        public string opis;
        [MessageBodyMember]
        public Stream dane;
    }


    [MessageContract]
    public class ResponseFileUpload {
        public string msg;
    }




    [MessageContract]
    public class RequestFileMessage {
        [MessageBodyMember]
        public string nazwa1;      
    }

    [MessageContract]
    public class ResponseFileMessage
    {
        [MessageHeader]
        public string nazwa2;
        [MessageHeader]
        public long rozmiar;
        [MessageBodyMember]
        public Stream dane;
    }

    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: dodaj tutaj operacje usługi
    }




    // Użyj kontraktu danych, jak pokazano w poniższym przykładzie, aby dodać typy złożone do operacji usługi.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
