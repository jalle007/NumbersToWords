﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NumbersToWords.WPF.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IConversionService")]
    public interface IConversionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConversionService/Convert", ReplyAction="http://tempuri.org/IConversionService/ConvertResponse")]
        string Convert(float value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConversionService/Convert", ReplyAction="http://tempuri.org/IConversionService/ConvertResponse")]
        System.Threading.Tasks.Task<string> ConvertAsync(float value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConversionServiceChannel : NumbersToWords.WPF.ServiceReference1.IConversionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConversionServiceClient : System.ServiceModel.ClientBase<NumbersToWords.WPF.ServiceReference1.IConversionService>, NumbersToWords.WPF.ServiceReference1.IConversionService {
        
        public ConversionServiceClient() {
        }
        
        public ConversionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConversionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConversionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConversionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Convert(float value) {
            return base.Channel.Convert(value);
        }
        
        public System.Threading.Tasks.Task<string> ConvertAsync(float value) {
            return base.Channel.ConvertAsync(value);
        }
    }
}
