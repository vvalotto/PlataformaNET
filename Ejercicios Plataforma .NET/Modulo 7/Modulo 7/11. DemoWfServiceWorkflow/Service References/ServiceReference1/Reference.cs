﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.269
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemWFServiceWorkflow.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schema.develop.com/2010/math", ConfigurationName="ServiceReference1.math")]
    public interface math {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schema.develop.com/2010/math/math/Sumar", ReplyAction="http://schema.develop.com/2010/math/math/SumarResponse")]
        DemWFServiceWorkflow.ServiceReference1.SumarResponse Sumar(DemWFServiceWorkflow.ServiceReference1.SumarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Sumar", WrapperNamespace="http://schema.develop.com/2010/math", IsWrapped=true)]
    public partial class SumarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schema.develop.com/2010/math", Order=0)]
        public int xIn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schema.develop.com/2010/math", Order=1)]
        public int yIn;
        
        public SumarRequest() {
        }
        
        public SumarRequest(int xIn, int yIn) {
            this.xIn = xIn;
            this.yIn = yIn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SumarResponse", WrapperNamespace="http://schema.develop.com/2010/math", IsWrapped=true)]
    public partial class SumarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schema.develop.com/2010/math", Order=0)]
        public int sumar;
        
        public SumarResponse() {
        }
        
        public SumarResponse(int sumar) {
            this.sumar = sumar;
        }
    }
}