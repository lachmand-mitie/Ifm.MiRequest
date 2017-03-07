namespace Ifm.MiRequest.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PersonIdentifer", XPath = @"/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='PersonIdentifer' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "FirstName", XPath = @"/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='FirstName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Surname", XPath = @"/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Surname' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Email", XPath = @"/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Email' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.ResultCode", XPath = @"/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='ResultCode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.Message", XPath = @"/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='Message' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.PortalUser", XPath = @"/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='PortalUser' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.PersonIdentifier", XPath = @"/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='PersonIdentifier' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PersonRequest", @"PersonResponse"})]
    public sealed class NewPersonRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://IFM.MiRequest.NewPersonRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://IFM.MiRequest.NewPersonRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PersonRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='PersonIdentifer' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='FirstName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Surname' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Email' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Provider' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Provider"" type=""xs:string"" />
        <xs:element name=""FirstName"" type=""xs:string"" />
        <xs:element name=""Surname"" type=""xs:string"" />
        <xs:element name=""Email"" type=""xs:string"" />
        <xs:element name=""Phone"" type=""xs:string"" />
        <xs:element name=""PersonIdentifer"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PersonResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='ResultCode' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='Message' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='PortalUser' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='PersonIdentifier' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Result"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ResultCode"" type=""xs:string"" />
              <xs:element name=""Message"" type=""xs:string"" />
              <xs:element name=""PortalUser"" type=""xs:string"" />
              <xs:element name=""PersonIdentifier"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public NewPersonRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "PersonRequest";
                _RootElements[1] = "PersonResponse";
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
        
        [Schema(@"http://IFM.MiRequest.NewPersonRequest",@"PersonRequest")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PersonIdentifer", XPath = @"/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='PersonIdentifer' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "FirstName", XPath = @"/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='FirstName' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Surname", XPath = @"/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Surname' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Email", XPath = @"/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Email' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='PersonRequest' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PersonRequest"})]
        public sealed class PersonRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PersonRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PersonRequest";
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
        
        [Schema(@"http://IFM.MiRequest.NewPersonRequest",@"PersonResponse")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.ResultCode", XPath = @"/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='ResultCode' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.Message", XPath = @"/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='Message' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.PortalUser", XPath = @"/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='PortalUser' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.PersonIdentifier", XPath = @"/*[local-name()='PersonResponse' and namespace-uri()='http://IFM.MiRequest.NewPersonRequest']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='PersonIdentifier' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PersonResponse"})]
        public sealed class PersonResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PersonResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PersonResponse";
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
