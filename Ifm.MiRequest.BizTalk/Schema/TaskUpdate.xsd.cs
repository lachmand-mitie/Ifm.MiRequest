namespace Ifm.MiRequest.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='TaskUpdateRequest' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ProviderRef", XPath = @"/*[local-name()='TaskUpdateRequest' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='ProviderRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "TaskUpdate.Class", XPath = @"/*[local-name()='TaskUpdateRequest' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='TaskUpdate' and namespace-uri()='']/*[local-name()='Class' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ResultCode", XPath = @"/*[local-name()='TaskUpdateResponse' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='ResultCode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "MessageText", XPath = @"/*[local-name()='TaskUpdateResponse' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='MessageText' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TaskUpdateRequest", @"TaskUpdateResponse"})]
    public sealed class TaskUpdate : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://IFM.MiRequest.TaskUpdate"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://IFM.MiRequest.TaskUpdate"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""TaskUpdateRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskUpdateRequest' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='Provider' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskUpdateRequest' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='ProviderRef' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskUpdateRequest' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='TaskUpdate' and namespace-uri()='']/*[local-name()='Class' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Provider"" type=""xs:string"" />
        <xs:element name=""ProviderRef"" type=""xs:string"" />
        <xs:element name=""PortalRef"" type=""xs:string"" />
        <xs:element name=""TaskUpdate"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Class"" type=""xs:string"" />
              <xs:element name=""Attribute01"" type=""xs:string"" />
              <xs:element name=""Attribute02"" type=""xs:string"" />
              <xs:element name=""Attribute03"" type=""xs:string"" />
              <xs:element name=""Attribute04"" type=""xs:string"" />
              <xs:element name=""Attribute05"" type=""xs:string"" />
              <xs:element name=""Attribute06"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaskUpdateResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskUpdateResponse' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='ResultCode' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskUpdateResponse' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='MessageText' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ResultCode"" type=""xs:string"" />
        <xs:element name=""MessageText"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TaskUpdate() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "TaskUpdateRequest";
                _RootElements[1] = "TaskUpdateResponse";
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
        
        [Schema(@"http://IFM.MiRequest.TaskUpdate",@"TaskUpdateRequest")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='TaskUpdateRequest' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ProviderRef", XPath = @"/*[local-name()='TaskUpdateRequest' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='ProviderRef' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "TaskUpdate.Class", XPath = @"/*[local-name()='TaskUpdateRequest' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='TaskUpdate' and namespace-uri()='']/*[local-name()='Class' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaskUpdateRequest"})]
        public sealed class TaskUpdateRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaskUpdateRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaskUpdateRequest";
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
        
        [Schema(@"http://IFM.MiRequest.TaskUpdate",@"TaskUpdateResponse")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ResultCode", XPath = @"/*[local-name()='TaskUpdateResponse' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='ResultCode' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "MessageText", XPath = @"/*[local-name()='TaskUpdateResponse' and namespace-uri()='http://IFM.MiRequest.TaskUpdate']/*[local-name()='MessageText' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaskUpdateResponse"})]
        public sealed class TaskUpdateResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaskUpdateResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaskUpdateResponse";
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
