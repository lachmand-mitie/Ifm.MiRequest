namespace Ifm.MiRequest.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"miworldcolleaguerequestupd")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"miworldcolleaguerequestupd"})]
    public sealed class miworldcolleaguerequestupd : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""miworldcolleaguerequestupd"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""mcid"" type=""xs:string"" />
        <xs:element name=""helpdeskid"" type=""xs:string"" />
        <xs:element name=""jobstatus"" type=""xs:string"" />
        <xs:element name=""body"" type=""xs:string"" />
        <xs:element name=""statuschangets"" type=""xs:dateTime"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public miworldcolleaguerequestupd() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "miworldcolleaguerequestupd";
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
