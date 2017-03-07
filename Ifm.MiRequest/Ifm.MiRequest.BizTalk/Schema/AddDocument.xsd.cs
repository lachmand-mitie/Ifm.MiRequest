namespace Ifm.MiRequest.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ProviderRef", XPath = @"/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ProviderRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ClientLocation", XPath = @"/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ClientLocation' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PortalRef", XPath = @"/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='PortalRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PortalRef", XPath = @"/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='PortalRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ProviderRef", XPath = @"/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ProviderRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ResultCode", XPath = @"/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ResultCode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Message", XPath = @"/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='Message' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddDocumentRequest", @"AddDocumentResponse"})]
    public sealed class AddDocument : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://IFM.MiRequest.AddDocument"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://IFM.MiRequest.AddDocument"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""AddDocumentRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ProviderRef' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ClientLocation' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='PortalRef' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='Provider' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PortalRef"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ProviderRef"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ClientLocation"" type=""xs:string"" />
        <xs:element name=""Provider"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""DocRequest"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FileContent"" type=""xs:string"" />
              <xs:element default=""Customer Image"" name=""FileDescription"" type=""xs:string"" />
              <xs:element name=""FileName"" type=""xs:string"" />
              <xs:element name=""FileType"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddDocumentResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='PortalRef' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ProviderRef' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ResultCode' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='Message' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PortalRef"" type=""xs:string"" />
        <xs:element name=""ProviderRef"" type=""xs:string"" />
        <xs:element name=""ResultCode"" type=""xs:string"" />
        <xs:element name=""Message"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AddDocument() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "AddDocumentRequest";
                _RootElements[1] = "AddDocumentResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://IFM.MiRequest.AddDocument",@"AddDocumentRequest")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ProviderRef", XPath = @"/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ProviderRef' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ClientLocation", XPath = @"/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ClientLocation' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PortalRef", XPath = @"/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='PortalRef' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='AddDocumentRequest' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddDocumentRequest"})]
        public sealed class AddDocumentRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddDocumentRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddDocumentRequest";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://IFM.MiRequest.AddDocument",@"AddDocumentResponse")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PortalRef", XPath = @"/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='PortalRef' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ProviderRef", XPath = @"/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ProviderRef' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ResultCode", XPath = @"/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='ResultCode' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Message", XPath = @"/*[local-name()='AddDocumentResponse' and namespace-uri()='http://IFM.MiRequest.AddDocument']/*[local-name()='Message' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddDocumentResponse"})]
        public sealed class AddDocumentResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddDocumentResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddDocumentResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
