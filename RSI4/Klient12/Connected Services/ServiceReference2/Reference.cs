﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klient12.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IStrumien")]
    public interface IStrumien {
        
        // CODEGEN: Generating message contract since the wrapper name (RequestFileMessage) of message RequestFileMessage does not match the default value (getMStream)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/getMStream", ReplyAction="http://tempuri.org/IStrumien/getMStreamResponse")]
        Klient12.ServiceReference2.ResponseFileMessage getMStream(Klient12.ServiceReference2.RequestFileMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/getMStream", ReplyAction="http://tempuri.org/IStrumien/getMStreamResponse")]
        System.Threading.Tasks.Task<Klient12.ServiceReference2.ResponseFileMessage> getMStreamAsync(Klient12.ServiceReference2.RequestFileMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/UploadStream", ReplyAction="http://tempuri.org/IStrumien/UploadStreamResponse")]
        bool UploadStream(System.IO.Stream file);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/UploadStream", ReplyAction="http://tempuri.org/IStrumien/UploadStreamResponse")]
        System.Threading.Tasks.Task<bool> UploadStreamAsync(System.IO.Stream file);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/getStream", ReplyAction="http://tempuri.org/IStrumien/getStreamResponse")]
        System.IO.Stream getStream(string nazwa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/getStream", ReplyAction="http://tempuri.org/IStrumien/getStreamResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> getStreamAsync(string nazwa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/Lista", ReplyAction="http://tempuri.org/IStrumien/ListaResponse")]
        Contract12.DaneObrazkow[] Lista();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/Lista", ReplyAction="http://tempuri.org/IStrumien/ListaResponse")]
        System.Threading.Tasks.Task<Contract12.DaneObrazkow[]> ListaAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RequestFileMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class RequestFileMessage {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string nazwa1;
        
        public RequestFileMessage() {
        }
        
        public RequestFileMessage(string nazwa1) {
            this.nazwa1 = nazwa1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ResponseFileMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ResponseFileMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string nazwa2;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long rozmiar;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream dane;
        
        public ResponseFileMessage() {
        }
        
        public ResponseFileMessage(string nazwa2, long rozmiar, System.IO.Stream dane) {
            this.nazwa2 = nazwa2;
            this.rozmiar = rozmiar;
            this.dane = dane;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStrumienChannel : Klient12.ServiceReference2.IStrumien, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StrumienClient : System.ServiceModel.ClientBase<Klient12.ServiceReference2.IStrumien>, Klient12.ServiceReference2.IStrumien {
        
        public StrumienClient() {
        }
        
        public StrumienClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StrumienClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StrumienClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StrumienClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Klient12.ServiceReference2.ResponseFileMessage Klient12.ServiceReference2.IStrumien.getMStream(Klient12.ServiceReference2.RequestFileMessage request) {
            return base.Channel.getMStream(request);
        }
        
        public string getMStream(string nazwa1, out long rozmiar, out System.IO.Stream dane) {
            Klient12.ServiceReference2.RequestFileMessage inValue = new Klient12.ServiceReference2.RequestFileMessage();
            inValue.nazwa1 = nazwa1;
            Klient12.ServiceReference2.ResponseFileMessage retVal = ((Klient12.ServiceReference2.IStrumien)(this)).getMStream(inValue);
            rozmiar = retVal.rozmiar;
            dane = retVal.dane;
            return retVal.nazwa2;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Klient12.ServiceReference2.ResponseFileMessage> Klient12.ServiceReference2.IStrumien.getMStreamAsync(Klient12.ServiceReference2.RequestFileMessage request) {
            return base.Channel.getMStreamAsync(request);
        }
        
        public System.Threading.Tasks.Task<Klient12.ServiceReference2.ResponseFileMessage> getMStreamAsync(string nazwa1) {
            Klient12.ServiceReference2.RequestFileMessage inValue = new Klient12.ServiceReference2.RequestFileMessage();
            inValue.nazwa1 = nazwa1;
            return ((Klient12.ServiceReference2.IStrumien)(this)).getMStreamAsync(inValue);
        }
        
        public bool UploadStream(System.IO.Stream file) {
            return base.Channel.UploadStream(file);
        }
        
        public System.Threading.Tasks.Task<bool> UploadStreamAsync(System.IO.Stream file) {
            return base.Channel.UploadStreamAsync(file);
        }
        
        public System.IO.Stream getStream(string nazwa) {
            return base.Channel.getStream(nazwa);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> getStreamAsync(string nazwa) {
            return base.Channel.getStreamAsync(nazwa);
        }
        
        public Contract12.DaneObrazkow[] Lista() {
            return base.Channel.Lista();
        }
        
        public System.Threading.Tasks.Task<Contract12.DaneObrazkow[]> ListaAsync() {
            return base.Channel.ListaAsync();
        }
    }
}
