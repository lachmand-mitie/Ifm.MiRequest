namespace Ifm.MiRequest.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Contract", @"Provider", @"Match"})]
    public sealed class LocationsQuery_Prop : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MFM.Colleague.Portal.LocationsQuery_Prop"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://IFM.MiRequest.LocationsQuery_Prop"" targetNamespace=""https://IFM.MiRequest.LocationsQuery_Prop"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Contract"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""3d6a1530-4b68-435c-bac6-f00957a25249"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Provider"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""55cab7cd-7df6-4023-8fc8-e8ef5f3a8821"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Match"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""3fe5f6fd-9c6e-4641-bafb-e96e9dce0838"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public LocationsQuery_Prop() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [3];
                _RootElements[0] = "Contract";
                _RootElements[1] = "Provider";
                _RootElements[2] = "Match";
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
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"Contract",@"https://IFM.MiRequest.LocationsQuery_Prop","string","System.String")]
    [PropertyGuidAttribute(@"3d6a1530-4b68-435c-bac6-f00957a25249")]
    public sealed class Contract : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Contract", @"https://IFM.MiRequest.LocationsQuery_Prop");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"Provider",@"https://IFM.MiRequest.LocationsQuery_Prop","string","System.String")]
    [PropertyGuidAttribute(@"55cab7cd-7df6-4023-8fc8-e8ef5f3a8821")]
    public sealed class Provider : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Provider", @"https://IFM.MiRequest.LocationsQuery_Prop");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"Match",@"https://IFM.MiRequest.LocationsQuery_Prop","string","System.String")]
    [PropertyGuidAttribute(@"3fe5f6fd-9c6e-4641-bafb-e96e9dce0838")]
    public sealed class Match : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Match", @"https://IFM.MiRequest.LocationsQuery_Prop");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
}
