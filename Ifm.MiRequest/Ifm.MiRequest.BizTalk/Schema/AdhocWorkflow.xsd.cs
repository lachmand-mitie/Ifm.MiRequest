namespace Ifm.MiRequest.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://IFM.MiRequest.AdhocWorkflow",@"AdhocWorkflow")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Routing.WorkType", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Routing' and namespace-uri()='']/*[local-name()='WorkType' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Routing.Status", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Routing' and namespace-uri()='']/*[local-name()='Status' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Routing.StatusChanged", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Routing' and namespace-uri()='']/*[local-name()='StatusChanged' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Workflow.SRNumber", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='SRNumber' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Workflow.Name", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Name' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Workflow.Phone", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Phone' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Workflow.Email", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Email' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Workflow.Summary", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Summary' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Workflow.Details", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Details' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Workflow.WODetailsPersonGroup", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='WODetailsPersonGroup' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Workflow.Location", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Location' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Workflow.ChargeDept", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='ChargeDept' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Workflow.SchemeNo", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='SchemeNo' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Routing.Source", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Routing' and namespace-uri()='']/*[local-name()='Source' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Workflow.BusinessCase", XPath = @"/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='BusinessCase' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AdhocWorkflow"})]
    public sealed class AdhocWorkflow : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://IFM.MiRequest.AdhocWorkflow"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://IFM.MiRequest.AdhocWorkflow"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""AdhocWorkflow"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Routing' and namespace-uri()='']/*[local-name()='WorkType' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Routing' and namespace-uri()='']/*[local-name()='Status' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Routing' and namespace-uri()='']/*[local-name()='StatusChanged' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='SRNumber' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Name' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Phone' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Email' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Summary' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Details' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='WODetailsPersonGroup' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='Location' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='ChargeDept' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='SchemeNo' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Routing' and namespace-uri()='']/*[local-name()='Source' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AdhocWorkflow' and namespace-uri()='http://IFM.MiRequest.AdhocWorkflow']/*[local-name()='Workflow' and namespace-uri()='']/*[local-name()='BusinessCase' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Routing"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""WorkType"" type=""xs:string"" />
              <xs:element name=""Status"" type=""xs:string"" />
              <xs:element name=""StatusChanged"" type=""xs:string"" />
              <xs:element name=""Source"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Workflow"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""SRNumber"" type=""xs:string"" />
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Phone"" type=""xs:string"" />
              <xs:element name=""Email"" type=""xs:string"" />
              <xs:element name=""Summary"" type=""xs:string"" />
              <xs:element name=""Details"" type=""xs:string"" />
              <xs:element name=""WODetailsPersonGroup"" type=""xs:string"" />
              <xs:element name=""Location"" type=""xs:string"" />
              <xs:element name=""ChargeDept"" type=""xs:string"" />
              <xs:element name=""SchemeNo"" type=""xs:string"" />
              <xs:element name=""BusinessCase"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AdhocWorkflow() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AdhocWorkflow";
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
