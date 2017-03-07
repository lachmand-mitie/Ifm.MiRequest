namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry.TaskEnquiryRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryResponse", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry.TaskEnquiryResponse))]
    public sealed class MapDummyTaskEnquiryResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""https://IFM.MiRequest.TaskEnquiry"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:TaskEnquiryRequest"" />
  </xsl:template>
  <xsl:template match=""/ns0:TaskEnquiryRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;-4&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;Provider not implemented&quot;)"" />
    <ns0:TaskEnquiryResponse>
      <Result>
        <ResultCode>
          <xsl:value-of select=""$var:v1"" />
        </ResultCode>
        <Message>
          <xsl:value-of select=""$var:v2"" />
        </Message>
        <PortalRef>
          <xsl:value-of select=""PortalRef/text()"" />
        </PortalRef>
        <Task>
          <xsl:if test=""ProviderRef"">
            <ProviderRef>
              <xsl:value-of select=""ProviderRef/text()"" />
            </ProviderRef>
          </xsl:if>
        </Task>
      </Result>
    </ns0:TaskEnquiryResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry.TaskEnquiryRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryResponse";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry.TaskEnquiryResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryResponse";
                return _TrgSchemas;
            }
        }
    }
}
