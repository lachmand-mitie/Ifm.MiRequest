namespace Ifm.MiRequest.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Contract", XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Contract' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Match", XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Match' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Contract), XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Contract' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Provider), XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Match), XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Match' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"LocationRequest", @"LocationResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.LocationsQuery_Prop", typeof(global::Ifm.MiRequest.BizTalk.Schemas.LocationsQuery_Prop))]
    public sealed class LocationQuery : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""https://IFM.MiRequest.LocationQuery"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://IFM.MiRequest.LocationsQuery_Prop"" targetNamespace=""https://IFM.MiRequest.LocationQuery"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://IFM.MiRequest.LocationsQuery_Prop"" location=""Ifm.MiRequest.BizTalk.Schemas.LocationsQuery_Prop"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""LocationRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""LocationRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Contract' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Provider' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Match' and namespace-uri()='']"" />
          <b:property name=""ns0:Contract"" xpath=""/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Contract' and namespace-uri()='']"" />
          <b:property name=""ns0:Provider"" xpath=""/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Provider' and namespace-uri()='']"" />
          <b:property name=""ns0:Match"" xpath=""/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Match' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Contract"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Provider"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Match"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LocationResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Result"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ResultCode"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Message"" type=""xs:string"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""NumRecords"" type=""xs:integer"" />
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Locations"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Location"" type=""xs:string"" />
                    <xs:element name=""MxLocation"" type=""xs:string"" />
                    <xs:element name=""MxSiteId"" type=""xs:string"" />
                    <xs:element name=""MxOrgId"" type=""xs:string"" />
                    <xs:element name=""MxAddress"" type=""xs:string"" />
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
        
        public LocationQuery() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "LocationRequest";
                _RootElements[1] = "LocationResponse";
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
        
        [Schema(@"https://IFM.MiRequest.LocationQuery",@"LocationRequest")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Contract", XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Contract' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Match", XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Match' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Contract), XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Contract' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Provider), XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Ifm.MiRequest.BizTalk.Schemas.Match), XPath = @"/*[local-name()='LocationRequest' and namespace-uri()='https://IFM.MiRequest.LocationQuery']/*[local-name()='Match' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LocationRequest"})]
        public sealed class LocationRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LocationRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LocationRequest";
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
        
        [Schema(@"https://IFM.MiRequest.LocationQuery",@"LocationResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LocationResponse"})]
        public sealed class LocationResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LocationResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LocationResponse";
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
