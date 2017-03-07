namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskUpdate+TaskUpdateRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskUpdate.TaskUpdateRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskUpdate+TaskUpdateResponse", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskUpdate.TaskUpdateResponse))]
    public sealed class RequestUpdateDummyResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://IFM.MiRequest.TaskUpdate"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:TaskUpdateRequest"" />
  </xsl:template>
  <xsl:template match=""/ns0:TaskUpdateRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;-1&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;DUMMY&quot;)"" />
    <ns0:TaskUpdateResponse>
      <ResultCode>
        <xsl:value-of select=""$var:v1"" />
      </ResultCode>
      <MessageText>
        <xsl:value-of select=""$var:v2"" />
      </MessageText>
      <xsl:value-of select=""./text()"" />
    </ns0:TaskUpdateResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskUpdate+TaskUpdateRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskUpdate.TaskUpdateRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskUpdate+TaskUpdateResponse";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskUpdate.TaskUpdateResponse _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.TaskUpdate+TaskUpdateRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.TaskUpdate+TaskUpdateResponse";
                return _TrgSchemas;
            }
        }
    }
}
