﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteForm.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento rebelde del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddListServiceRebelde", ReplyAction="*")]
        ClienteForm.ServiceReference1.AddListServiceRebeldeResponse AddListServiceRebelde(ClienteForm.ServiceReference1.AddListServiceRebeldeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddListServiceRebelde", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteForm.ServiceReference1.AddListServiceRebeldeResponse> AddListServiceRebeldeAsync(ClienteForm.ServiceReference1.AddListServiceRebeldeRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetRebeldesServiceResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRebeldesService", ReplyAction="*")]
        ClienteForm.ServiceReference1.GetRebeldesServiceResponse GetRebeldesService(ClienteForm.ServiceReference1.GetRebeldesServiceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRebeldesService", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteForm.ServiceReference1.GetRebeldesServiceResponse> GetRebeldesServiceAsync(ClienteForm.ServiceReference1.GetRebeldesServiceRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento soldado del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddListServiceSoldado", ReplyAction="*")]
        ClienteForm.ServiceReference1.AddListServiceSoldadoResponse AddListServiceSoldado(ClienteForm.ServiceReference1.AddListServiceSoldadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddListServiceSoldado", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteForm.ServiceReference1.AddListServiceSoldadoResponse> AddListServiceSoldadoAsync(ClienteForm.ServiceReference1.AddListServiceSoldadoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetSoldadosServiceResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSoldadosService", ReplyAction="*")]
        ClienteForm.ServiceReference1.GetSoldadosServiceResponse GetSoldadosService(ClienteForm.ServiceReference1.GetSoldadosServiceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSoldadosService", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteForm.ServiceReference1.GetSoldadosServiceResponse> GetSoldadosServiceAsync(ClienteForm.ServiceReference1.GetSoldadosServiceRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddListServiceRebeldeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddListServiceRebelde", Namespace="http://tempuri.org/", Order=0)]
        public ClienteForm.ServiceReference1.AddListServiceRebeldeRequestBody Body;
        
        public AddListServiceRebeldeRequest() {
        }
        
        public AddListServiceRebeldeRequest(ClienteForm.ServiceReference1.AddListServiceRebeldeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddListServiceRebeldeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string rebelde;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string planeta;
        
        public AddListServiceRebeldeRequestBody() {
        }
        
        public AddListServiceRebeldeRequestBody(string rebelde, string planeta) {
            this.rebelde = rebelde;
            this.planeta = planeta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddListServiceRebeldeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddListServiceRebeldeResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteForm.ServiceReference1.AddListServiceRebeldeResponseBody Body;
        
        public AddListServiceRebeldeResponse() {
        }
        
        public AddListServiceRebeldeResponse(ClienteForm.ServiceReference1.AddListServiceRebeldeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddListServiceRebeldeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AddListServiceRebeldeResult;
        
        public AddListServiceRebeldeResponseBody() {
        }
        
        public AddListServiceRebeldeResponseBody(bool AddListServiceRebeldeResult) {
            this.AddListServiceRebeldeResult = AddListServiceRebeldeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRebeldesServiceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRebeldesService", Namespace="http://tempuri.org/", Order=0)]
        public ClienteForm.ServiceReference1.GetRebeldesServiceRequestBody Body;
        
        public GetRebeldesServiceRequest() {
        }
        
        public GetRebeldesServiceRequest(ClienteForm.ServiceReference1.GetRebeldesServiceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetRebeldesServiceRequestBody {
        
        public GetRebeldesServiceRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRebeldesServiceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRebeldesServiceResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteForm.ServiceReference1.GetRebeldesServiceResponseBody Body;
        
        public GetRebeldesServiceResponse() {
        }
        
        public GetRebeldesServiceResponse(ClienteForm.ServiceReference1.GetRebeldesServiceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRebeldesServiceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClienteForm.ServiceReference1.ArrayOfString GetRebeldesServiceResult;
        
        public GetRebeldesServiceResponseBody() {
        }
        
        public GetRebeldesServiceResponseBody(ClienteForm.ServiceReference1.ArrayOfString GetRebeldesServiceResult) {
            this.GetRebeldesServiceResult = GetRebeldesServiceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddListServiceSoldadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddListServiceSoldado", Namespace="http://tempuri.org/", Order=0)]
        public ClienteForm.ServiceReference1.AddListServiceSoldadoRequestBody Body;
        
        public AddListServiceSoldadoRequest() {
        }
        
        public AddListServiceSoldadoRequest(ClienteForm.ServiceReference1.AddListServiceSoldadoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddListServiceSoldadoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string soldado;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string planeta;
        
        public AddListServiceSoldadoRequestBody() {
        }
        
        public AddListServiceSoldadoRequestBody(string soldado, string planeta) {
            this.soldado = soldado;
            this.planeta = planeta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddListServiceSoldadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddListServiceSoldadoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteForm.ServiceReference1.AddListServiceSoldadoResponseBody Body;
        
        public AddListServiceSoldadoResponse() {
        }
        
        public AddListServiceSoldadoResponse(ClienteForm.ServiceReference1.AddListServiceSoldadoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddListServiceSoldadoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AddListServiceSoldadoResult;
        
        public AddListServiceSoldadoResponseBody() {
        }
        
        public AddListServiceSoldadoResponseBody(bool AddListServiceSoldadoResult) {
            this.AddListServiceSoldadoResult = AddListServiceSoldadoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSoldadosServiceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSoldadosService", Namespace="http://tempuri.org/", Order=0)]
        public ClienteForm.ServiceReference1.GetSoldadosServiceRequestBody Body;
        
        public GetSoldadosServiceRequest() {
        }
        
        public GetSoldadosServiceRequest(ClienteForm.ServiceReference1.GetSoldadosServiceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetSoldadosServiceRequestBody {
        
        public GetSoldadosServiceRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSoldadosServiceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSoldadosServiceResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteForm.ServiceReference1.GetSoldadosServiceResponseBody Body;
        
        public GetSoldadosServiceResponse() {
        }
        
        public GetSoldadosServiceResponse(ClienteForm.ServiceReference1.GetSoldadosServiceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetSoldadosServiceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClienteForm.ServiceReference1.ArrayOfString GetSoldadosServiceResult;
        
        public GetSoldadosServiceResponseBody() {
        }
        
        public GetSoldadosServiceResponseBody(ClienteForm.ServiceReference1.ArrayOfString GetSoldadosServiceResult) {
            this.GetSoldadosServiceResult = GetSoldadosServiceResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : ClienteForm.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<ClienteForm.ServiceReference1.WebServiceSoap>, ClienteForm.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteForm.ServiceReference1.AddListServiceRebeldeResponse ClienteForm.ServiceReference1.WebServiceSoap.AddListServiceRebelde(ClienteForm.ServiceReference1.AddListServiceRebeldeRequest request) {
            return base.Channel.AddListServiceRebelde(request);
        }
        
        public bool AddListServiceRebelde(string rebelde, string planeta) {
            ClienteForm.ServiceReference1.AddListServiceRebeldeRequest inValue = new ClienteForm.ServiceReference1.AddListServiceRebeldeRequest();
            inValue.Body = new ClienteForm.ServiceReference1.AddListServiceRebeldeRequestBody();
            inValue.Body.rebelde = rebelde;
            inValue.Body.planeta = planeta;
            ClienteForm.ServiceReference1.AddListServiceRebeldeResponse retVal = ((ClienteForm.ServiceReference1.WebServiceSoap)(this)).AddListServiceRebelde(inValue);
            return retVal.Body.AddListServiceRebeldeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteForm.ServiceReference1.AddListServiceRebeldeResponse> ClienteForm.ServiceReference1.WebServiceSoap.AddListServiceRebeldeAsync(ClienteForm.ServiceReference1.AddListServiceRebeldeRequest request) {
            return base.Channel.AddListServiceRebeldeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteForm.ServiceReference1.AddListServiceRebeldeResponse> AddListServiceRebeldeAsync(string rebelde, string planeta) {
            ClienteForm.ServiceReference1.AddListServiceRebeldeRequest inValue = new ClienteForm.ServiceReference1.AddListServiceRebeldeRequest();
            inValue.Body = new ClienteForm.ServiceReference1.AddListServiceRebeldeRequestBody();
            inValue.Body.rebelde = rebelde;
            inValue.Body.planeta = planeta;
            return ((ClienteForm.ServiceReference1.WebServiceSoap)(this)).AddListServiceRebeldeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteForm.ServiceReference1.GetRebeldesServiceResponse ClienteForm.ServiceReference1.WebServiceSoap.GetRebeldesService(ClienteForm.ServiceReference1.GetRebeldesServiceRequest request) {
            return base.Channel.GetRebeldesService(request);
        }
        
        public ClienteForm.ServiceReference1.ArrayOfString GetRebeldesService() {
            ClienteForm.ServiceReference1.GetRebeldesServiceRequest inValue = new ClienteForm.ServiceReference1.GetRebeldesServiceRequest();
            inValue.Body = new ClienteForm.ServiceReference1.GetRebeldesServiceRequestBody();
            ClienteForm.ServiceReference1.GetRebeldesServiceResponse retVal = ((ClienteForm.ServiceReference1.WebServiceSoap)(this)).GetRebeldesService(inValue);
            return retVal.Body.GetRebeldesServiceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteForm.ServiceReference1.GetRebeldesServiceResponse> ClienteForm.ServiceReference1.WebServiceSoap.GetRebeldesServiceAsync(ClienteForm.ServiceReference1.GetRebeldesServiceRequest request) {
            return base.Channel.GetRebeldesServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteForm.ServiceReference1.GetRebeldesServiceResponse> GetRebeldesServiceAsync() {
            ClienteForm.ServiceReference1.GetRebeldesServiceRequest inValue = new ClienteForm.ServiceReference1.GetRebeldesServiceRequest();
            inValue.Body = new ClienteForm.ServiceReference1.GetRebeldesServiceRequestBody();
            return ((ClienteForm.ServiceReference1.WebServiceSoap)(this)).GetRebeldesServiceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteForm.ServiceReference1.AddListServiceSoldadoResponse ClienteForm.ServiceReference1.WebServiceSoap.AddListServiceSoldado(ClienteForm.ServiceReference1.AddListServiceSoldadoRequest request) {
            return base.Channel.AddListServiceSoldado(request);
        }
        
        public bool AddListServiceSoldado(string soldado, string planeta) {
            ClienteForm.ServiceReference1.AddListServiceSoldadoRequest inValue = new ClienteForm.ServiceReference1.AddListServiceSoldadoRequest();
            inValue.Body = new ClienteForm.ServiceReference1.AddListServiceSoldadoRequestBody();
            inValue.Body.soldado = soldado;
            inValue.Body.planeta = planeta;
            ClienteForm.ServiceReference1.AddListServiceSoldadoResponse retVal = ((ClienteForm.ServiceReference1.WebServiceSoap)(this)).AddListServiceSoldado(inValue);
            return retVal.Body.AddListServiceSoldadoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteForm.ServiceReference1.AddListServiceSoldadoResponse> ClienteForm.ServiceReference1.WebServiceSoap.AddListServiceSoldadoAsync(ClienteForm.ServiceReference1.AddListServiceSoldadoRequest request) {
            return base.Channel.AddListServiceSoldadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteForm.ServiceReference1.AddListServiceSoldadoResponse> AddListServiceSoldadoAsync(string soldado, string planeta) {
            ClienteForm.ServiceReference1.AddListServiceSoldadoRequest inValue = new ClienteForm.ServiceReference1.AddListServiceSoldadoRequest();
            inValue.Body = new ClienteForm.ServiceReference1.AddListServiceSoldadoRequestBody();
            inValue.Body.soldado = soldado;
            inValue.Body.planeta = planeta;
            return ((ClienteForm.ServiceReference1.WebServiceSoap)(this)).AddListServiceSoldadoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteForm.ServiceReference1.GetSoldadosServiceResponse ClienteForm.ServiceReference1.WebServiceSoap.GetSoldadosService(ClienteForm.ServiceReference1.GetSoldadosServiceRequest request) {
            return base.Channel.GetSoldadosService(request);
        }
        
        public ClienteForm.ServiceReference1.ArrayOfString GetSoldadosService() {
            ClienteForm.ServiceReference1.GetSoldadosServiceRequest inValue = new ClienteForm.ServiceReference1.GetSoldadosServiceRequest();
            inValue.Body = new ClienteForm.ServiceReference1.GetSoldadosServiceRequestBody();
            ClienteForm.ServiceReference1.GetSoldadosServiceResponse retVal = ((ClienteForm.ServiceReference1.WebServiceSoap)(this)).GetSoldadosService(inValue);
            return retVal.Body.GetSoldadosServiceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteForm.ServiceReference1.GetSoldadosServiceResponse> ClienteForm.ServiceReference1.WebServiceSoap.GetSoldadosServiceAsync(ClienteForm.ServiceReference1.GetSoldadosServiceRequest request) {
            return base.Channel.GetSoldadosServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteForm.ServiceReference1.GetSoldadosServiceResponse> GetSoldadosServiceAsync() {
            ClienteForm.ServiceReference1.GetSoldadosServiceRequest inValue = new ClienteForm.ServiceReference1.GetSoldadosServiceRequest();
            inValue.Body = new ClienteForm.ServiceReference1.GetSoldadosServiceRequestBody();
            return ((ClienteForm.ServiceReference1.WebServiceSoap)(this)).GetSoldadosServiceAsync(inValue);
        }
    }
}
