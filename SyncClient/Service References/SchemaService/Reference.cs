﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SyncClient.SchemaService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SchemaService.SchemaService")]
    public interface SchemaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SchemaService/GetSchemaVersion", ReplyAction="http://tempuri.org/SchemaService/GetSchemaVersionResponse")]
        byte GetSchemaVersion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SchemaService/GetSchema", ReplyAction="http://tempuri.org/SchemaService/GetSchemaResponse")]
        string GetSchema();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SchemaServiceChannel : SyncClient.SchemaService.SchemaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SchemaServiceClient : System.ServiceModel.ClientBase<SyncClient.SchemaService.SchemaService>, SyncClient.SchemaService.SchemaService {
        
        public SchemaServiceClient() {
        }
        
        public SchemaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SchemaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SchemaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SchemaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public byte GetSchemaVersion() {
            return base.Channel.GetSchemaVersion();
        }
        
        public string GetSchema() {
            return base.Channel.GetSchema();
        }
    }
}