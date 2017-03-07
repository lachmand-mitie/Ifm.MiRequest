namespace Ifm.MiRequest.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Lst_User), XPath = @"/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='user' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Lst_Start), XPath = @"/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='start' and namespace-uri()='']", XsdType = @"integer")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "user", XPath = @"/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='user' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Decimal), "start", XPath = @"/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='start' and namespace-uri()='']", XsdType = @"integer")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TaskListRequest", @"TaskListResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskListQuery_Prop", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskListQuery_Prop))]
    public sealed class TaskListQuery : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""https://IFM.MiRequest.TaskListQuery"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns1=""https://IFM.MiRequest.TaskListQuery_Prop"" xmlns:ns0=""https://MFM.Colleague.Portal.TaskListQuery_Prop"" targetNamespace=""https://IFM.MiRequest.TaskListQuery"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns1"" uri=""https://IFM.MiRequest.TaskListQuery_Prop"" location=""Ifm.MiRequest.BizTalk.Schemas.TaskListQuery_Prop"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""TaskListRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns1:Lst_User"" xpath=""/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='user' and namespace-uri()='']"" />
          <b:property name=""ns1:Lst_Start"" xpath=""/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='start' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='user' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='start' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""user"" type=""xs:string"" />
        <xs:element name=""start"" type=""xs:integer"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaskListResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Result"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ErrorCode"" type=""xs:string"" />
              <xs:element name=""Message"" type=""xs:string"" />
              <xs:element name=""User"" type=""xs:string"" />
              <xs:element name=""Total"" type=""xs:integer"" />
              <xs:element name=""Starts"" type=""xs:integer"" />
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""TaskItem"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PortalRef"" type=""xs:string"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Provider"" type=""xs:string"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ProviderRef"" type=""xs:string"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""State01"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""State02"" type=""xs:string"" />
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
        
        public TaskListQuery() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "TaskListRequest";
                _RootElements[1] = "TaskListResponse";
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
        
        [Schema(@"https://IFM.MiRequest.TaskListQuery",@"TaskListRequest")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Lst_User), XPath = @"/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='user' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Lst_Start), XPath = @"/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='start' and namespace-uri()='']", XsdType = @"integer")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "user", XPath = @"/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='user' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Decimal), "start", XPath = @"/*[local-name()='TaskListRequest' and namespace-uri()='https://IFM.MiRequest.TaskListQuery']/*[local-name()='start' and namespace-uri()='']", XsdType = @"integer")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaskListRequest"})]
        public sealed class TaskListRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaskListRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaskListRequest";
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
        
        [Schema(@"https://IFM.MiRequest.TaskListQuery",@"TaskListResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaskListResponse"})]
        public sealed class TaskListResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaskListResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaskListResponse";
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
