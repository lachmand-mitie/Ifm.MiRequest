namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest+PersonRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest.PersonRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest+PersonResponse", typeof(global::Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest.PersonResponse))]
    public sealed class RequestPersonDummyResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://IFM.MiRequest.NewPersonRequest"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:PersonRequest"" />
  </xsl:template>
  <xsl:template match=""/ns0:PersonRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;-1&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;DUMMY&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;N\A&quot;)"" />
    <ns0:PersonResponse>
      <Result>
        <ResultCode>
          <xsl:value-of select=""$var:v1"" />
        </ResultCode>
        <Message>
          <xsl:value-of select=""$var:v2"" />
        </Message>
        <PortalUser>
          <xsl:value-of select=""Email/text()"" />
        </PortalUser>
        <PersonIdentifier>
          <xsl:value-of select=""$var:v3"" />
        </PersonIdentifier>
      </Result>
    </ns0:PersonResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest+PersonRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest.PersonRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest+PersonResponse";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest.PersonResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest+PersonRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest+PersonResponse";
                return _TrgSchemas;
            }
        }
    }
}
