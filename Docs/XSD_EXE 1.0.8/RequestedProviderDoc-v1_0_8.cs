﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.4084.0.
// 
namespace AxMyData.AADE {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class RequestedProviderDoc {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("continuationToken")]
        public continuationTokenType[] continuationToken;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceProviderType")]
        public InvoiceProviderType[] InvoiceProviderType;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class continuationTokenType {
        
        /// <remarks/>
        public string nextPartitionKey;
        
        /// <remarks/>
        public string nextRowKey;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceProviderType {
        
        /// <remarks/>
        public string issuerVAT;
        
        /// <remarks/>
        public long invoiceProviderMark;
        
        /// <remarks/>
        public string invoiceUid;
        
        /// <remarks/>
        public string authenticationCode;
    }
}