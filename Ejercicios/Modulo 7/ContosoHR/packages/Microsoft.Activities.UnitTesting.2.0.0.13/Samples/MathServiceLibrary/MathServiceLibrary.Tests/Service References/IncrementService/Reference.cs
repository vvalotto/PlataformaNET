﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathServiceLibrary.Tests.IncrementService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IncrementService.IService")]
    public interface IService {
        
        // CODEGEN: Generating message contract since the operation Increment is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Increment", ReplyAction="http://tempuri.org/IService/IncrementResponse")]
        MathServiceLibrary.Tests.IncrementService.IncrementResponse Increment(MathServiceLibrary.Tests.IncrementService.IncrementRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IncrementRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public System.Nullable<int> @int;
        
        public IncrementRequest() {
        }
        
        public IncrementRequest(System.Nullable<int> @int) {
            this.@int = @int;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IncrementResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public System.Nullable<int> @int;
        
        public IncrementResponse() {
        }
        
        public IncrementResponse(System.Nullable<int> @int) {
            this.@int = @int;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : MathServiceLibrary.Tests.IncrementService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<MathServiceLibrary.Tests.IncrementService.IService>, MathServiceLibrary.Tests.IncrementService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MathServiceLibrary.Tests.IncrementService.IncrementResponse MathServiceLibrary.Tests.IncrementService.IService.Increment(MathServiceLibrary.Tests.IncrementService.IncrementRequest request) {
            return base.Channel.Increment(request);
        }
        
        public void Increment(ref System.Nullable<int> @int) {
            MathServiceLibrary.Tests.IncrementService.IncrementRequest inValue = new MathServiceLibrary.Tests.IncrementService.IncrementRequest();
            inValue.@int = @int;
            MathServiceLibrary.Tests.IncrementService.IncrementResponse retVal = ((MathServiceLibrary.Tests.IncrementService.IService)(this)).Increment(inValue);
            @int = retVal.@int;
        }
    }
}
