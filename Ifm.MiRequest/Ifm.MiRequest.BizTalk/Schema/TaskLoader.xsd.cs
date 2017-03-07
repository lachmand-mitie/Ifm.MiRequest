namespace Ifm.MiRequest.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Task_Provider), XPath = @"/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Contract", XPath = @"/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='Contract' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RequestRef", XPath = @"/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='RequestRef' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TaskLoadRequest", @"TaskLoadResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskLoader_Prop", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskLoader_Prop))]
    public sealed class TaskLoader : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""https://IFM.MiRequest.TaskLoader"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns1=""https://IFM.MiRequest.TaskLoader_Prop"" xmlns:ns0=""https://MFM.Colleague.Portal.TaskLoader_Prop"" targetNamespace=""https://IFM.MiRequest.TaskLoader"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns1"" uri=""https://IFM.MiRequest.TaskLoader_Prop"" location=""Ifm.MiRequest.BizTalk.Schemas.TaskLoader_Prop"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""TaskLoadRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns1:Task_Provider"" xpath=""/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='Provider' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='Provider' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='Contract' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='RequestRef' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Provider"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Target system for this task service delivery, specify MiAMI or 1TEAM"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Contract"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""RequestRef"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""MiRequest Id"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""Attribute001"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Worktype"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute002"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""locator info"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute003"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""locator info"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute004"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""locator info"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute005"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""locator info"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute006"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""category info"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute007"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""category info"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute008"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""category info"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute009"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""category info"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute010"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""contact name"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute011"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Contact number"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute012"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Contact mobile"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute013"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Customer"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute014"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Customer supplimentary"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute015"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""contract supplementary"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute016"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""priority"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""1"" name=""Attribute017"" type=""xs:string"" />
        <xs:element maxOccurs=""1"" name=""Attribute018"" type=""xs:string"" />
        <xs:element maxOccurs=""1"" name=""Attribute019"" type=""xs:string"" />
        <xs:element maxOccurs=""1"" name=""Attribute020"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ext01"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ext01attr00"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Supports definition of the business type, sector type, industry type"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""ext01attr01"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Defines the free text RR 1TEAm schemnum"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""ext01attr02"" type=""xs:string"" />
              <xs:element name=""ext01attr03"" type=""xs:string"" />
              <xs:element name=""ext01attr04"" type=""xs:string"" />
              <xs:element name=""ext01attr05"" type=""xs:string"" />
              <xs:element name=""ext01attr06"" type=""xs:string"" />
              <xs:element name=""ext01attr07"" type=""xs:string"" />
              <xs:element name=""ext01attr08"" type=""xs:string"" />
              <xs:element name=""ext01attr09"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""ext02"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ext02attr00"" type=""xs:string"" />
              <xs:element name=""ext02attr01"" type=""xs:string"" />
              <xs:element name=""ext02attr02"" type=""xs:string"" />
              <xs:element name=""ext02attr03"" type=""xs:string"" />
              <xs:element name=""ext02attr04"" type=""xs:string"" />
              <xs:element name=""ext02attr05"" type=""xs:string"" />
              <xs:element name=""ext02attr06"" type=""xs:string"" />
              <xs:element name=""ext02attr07"" type=""xs:string"" />
              <xs:element name=""ext02attr08"" type=""xs:string"" />
              <xs:element name=""ext02attr09"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaskLoadResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RequestRef"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ResultCode"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Message"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProviderRef"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TaskLoader() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "TaskLoadRequest";
                _RootElements[1] = "TaskLoadResponse";
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
        
        [Schema(@"https://IFM.MiRequest.TaskLoader",@"TaskLoadRequest")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Task_Provider), XPath = @"/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Contract", XPath = @"/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='Contract' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RequestRef", XPath = @"/*[local-name()='TaskLoadRequest' and namespace-uri()='https://IFM.MiRequest.TaskLoader']/*[local-name()='RequestRef' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaskLoadRequest"})]
        public sealed class TaskLoadRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaskLoadRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaskLoadRequest";
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
        
        [Schema(@"https://IFM.MiRequest.TaskLoader",@"TaskLoadResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaskLoadResponse"})]
        public sealed class TaskLoadResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaskLoadResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaskLoadResponse";
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
