namespace Ifm.MiRequest.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"https://IFM.MiRequest.PortalLightweightUpdate",@"MiRequestPortalUpdate")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PortalRef", XPath = @"/*[local-name()='MiRequestPortalUpdate' and namespace-uri()='https://IFM.MiRequest.PortalLightweightUpdate']/*[local-name()='PortalRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ProviderRef", XPath = @"/*[local-name()='MiRequestPortalUpdate' and namespace-uri()='https://IFM.MiRequest.PortalLightweightUpdate']/*[local-name()='ProviderRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Provider", XPath = @"/*[local-name()='MiRequestPortalUpdate' and namespace-uri()='https://IFM.MiRequest.PortalLightweightUpdate']/*[local-name()='Provider' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Status", XPath = @"/*[local-name()='MiRequestPortalUpdate' and namespace-uri()='https://IFM.MiRequest.PortalLightweightUpdate']/*[local-name()='Status' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "IsStatusChange", XPath = @"/*[local-name()='MiRequestPortalUpdate' and namespace-uri()='https://IFM.MiRequest.PortalLightweightUpdate']/*[local-name()='IsStatusChange' and namespace-uri()='']", XsdType = @"boolean")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MiRequestPortalUpdate"})]
    public sealed class PortalLightweightUpdate : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""https://IFM.MiRequest.PortalLightweightUpdate"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""https://IFM.MiRequest.PortalLightweightUpdate"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""MiRequestPortalUpdate"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='MiRequestPortalUpdate' and namespace-uri()='https://IFM.MiRequest.PortalLightweightUpdate']/*[local-name()='PortalRef' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MiRequestPortalUpdate' and namespace-uri()='https://IFM.MiRequest.PortalLightweightUpdate']/*[local-name()='ProviderRef' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MiRequestPortalUpdate' and namespace-uri()='https://IFM.MiRequest.PortalLightweightUpdate']/*[local-name()='Provider' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MiRequestPortalUpdate' and namespace-uri()='https://IFM.MiRequest.PortalLightweightUpdate']/*[local-name()='Status' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MiRequestPortalUpdate' and namespace-uri()='https://IFM.MiRequest.PortalLightweightUpdate']/*[local-name()='IsStatusChange' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PortalRef"" type=""xs:string"" />
        <xs:element name=""ProviderRef"" type=""xs:string"" />
        <xs:element name=""Provider"" type=""xs:string"" />
        <xs:element name=""Status"" type=""xs:string"" />
        <xs:element name=""StatusData"" type=""xs:string"" />
        <xs:element name=""IsStatusChange"" type=""xs:boolean"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PortalLightweightUpdate() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "MiRequestPortalUpdate";
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
