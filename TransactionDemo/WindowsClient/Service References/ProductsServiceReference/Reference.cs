﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsClient.ProductsServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductsServiceReference.IProducts")]
    public interface IProducts {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/AddCategory", ReplyAction="http://tempuri.org/IProducts/AddCategoryResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        int AddCategory(string CategoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/AddCategory", ReplyAction="http://tempuri.org/IProducts/AddCategoryResponse")]
        System.Threading.Tasks.Task<int> AddCategoryAsync(string CategoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/AddProducts", ReplyAction="http://tempuri.org/IProducts/AddProductsResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        int AddProducts(int CategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/AddProducts", ReplyAction="http://tempuri.org/IProducts/AddProductsResponse")]
        System.Threading.Tasks.Task<int> AddProductsAsync(int CategoryId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsChannel : WindowsClient.ProductsServiceReference.IProducts, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsClient : System.ServiceModel.ClientBase<WindowsClient.ProductsServiceReference.IProducts>, WindowsClient.ProductsServiceReference.IProducts {
        
        public ProductsClient() {
        }
        
        public ProductsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddCategory(string CategoryName) {
            return base.Channel.AddCategory(CategoryName);
        }
        
        public System.Threading.Tasks.Task<int> AddCategoryAsync(string CategoryName) {
            return base.Channel.AddCategoryAsync(CategoryName);
        }
        
        public int AddProducts(int CategoryId) {
            return base.Channel.AddProducts(CategoryId);
        }
        
        public System.Threading.Tasks.Task<int> AddProductsAsync(int CategoryId) {
            return base.Channel.AddProductsAsync(CategoryId);
        }
    }
}
