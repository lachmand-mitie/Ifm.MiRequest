namespace Ifm.MiRequest.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PortalRef", XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='PortalRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ProviderRef", XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='ProviderRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Enq_PortalRef), XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='PortalRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Enq_Provider), XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Enq_ProviderRef), XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='ProviderRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.ResultCode", XPath = @"/*[local-name()='TaskEnquiryResponse' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='ResultCode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.Message", XPath = @"/*[local-name()='TaskEnquiryResponse' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='Message' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.PortalRef", XPath = @"/*[local-name()='TaskEnquiryResponse' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='PortalRef' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TaskEnquiryRequest", @"TaskEnquiryResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry_Prop", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry_Prop))]
    public sealed class TaskEnquiry : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""https://IFM.MiRequest.TaskEnquiry"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://IFM.MiRequest.TaskEnquiry_Prop"" targetNamespace=""https://IFM.MiRequest.TaskEnquiry"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://IFM.MiRequest.TaskEnquiry_Prop"" location=""Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry_Prop"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""TaskEnquiryRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='PortalRef' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Provider' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='ProviderRef' and namespace-uri()='']"" />
          <b:property name=""ns0:Enq_PortalRef"" xpath=""/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='PortalRef' and namespace-uri()='']"" />
          <b:property name=""ns0:Enq_Provider"" xpath=""/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Provider' and namespace-uri()='']"" />
          <b:property name=""ns0:Enq_ProviderRef"" xpath=""/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='ProviderRef' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PortalRef"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Provider"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProviderRef"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaskEnquiryResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskEnquiryResponse' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='ResultCode' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskEnquiryResponse' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='Message' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskEnquiryResponse' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='PortalRef' and namespace-uri()='']"" />
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
              <xs:element name=""PortalRef"" type=""xs:string"" />
              <xs:element name=""Task"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ProviderRef"" type=""xs:string"" />
                    <xs:element name=""State01"" type=""xs:string"" />
                    <xs:element name=""State02"" type=""xs:string"" />
                    <xs:element name=""StateChanged"" type=""xs:string"" />
                    <xs:element name=""Summary"" type=""xs:string"" />
                    <xs:element name=""Details"" type=""xs:string"" />
                    <xs:element name=""AdditionalInfo"" type=""xs:string"" />
                    <xs:element name=""keydate01"" type=""xs:string"" />
                    <xs:element name=""keydate02"" type=""xs:string"" />
                    <xs:element name=""keydate03"" type=""xs:string"" />
                    <xs:element name=""keydate04"" type=""xs:string"" />
                    <xs:element name=""Location01"" type=""xs:string"" />
                    <xs:element name=""Location02"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Notes"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Log"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""Description"" type=""xs:string"" />
                                <xs:element name=""LongDescription"" type=""xs:string"" />
                                <xs:element name=""ClientViewable"" type=""xs:string"" />
                                <xs:element name=""CreatedTs"" type=""xs:dateTime"" />
                                <xs:element name=""LogType"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TaskEnquiry() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "TaskEnquiryRequest";
                _RootElements[1] = "TaskEnquiryResponse";
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
        
        [Schema(@"https://IFM.MiRequest.TaskEnquiry",@"TaskEnquiryRequest")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PortalRef", XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='PortalRef' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ProviderRef", XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='ProviderRef' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Enq_PortalRef), XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='PortalRef' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Enq_Provider), XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Enq_ProviderRef), XPath = @"/*[local-name()='TaskEnquiryRequest' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='ProviderRef' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaskEnquiryRequest"})]
        public sealed class TaskEnquiryRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaskEnquiryRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaskEnquiryRequest";
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
        
        [Schema(@"https://IFM.MiRequest.TaskEnquiry",@"TaskEnquiryResponse")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.ResultCode", XPath = @"/*[local-name()='TaskEnquiryResponse' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='ResultCode' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.Message", XPath = @"/*[local-name()='TaskEnquiryResponse' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='Message' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result.PortalRef", XPath = @"/*[local-name()='TaskEnquiryResponse' and namespace-uri()='https://IFM.MiRequest.TaskEnquiry']/*[local-name()='Result' and namespace-uri()='']/*[local-name()='PortalRef' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaskEnquiryResponse"})]
        public sealed class TaskEnquiryResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaskEnquiryResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaskEnquiryResponse";
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
