namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry.TaskEnquiryRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+QueryRRMISR", typeof(global::MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo.QueryRRMISR))]
    public sealed class TaskEnquiry_to_1teamSrQuery : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""https://IFM.MiRequest.TaskEnquiry"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TaskEnquiryRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:TaskEnquiryRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;TICKETID='&quot; , string(ProviderRef/text()) , &quot;'&quot;)"" />
    <ns0:QueryRRMISR>
      <xsl:attribute name=""uniqueResult"">
        <xsl:text>0</xsl:text>
      </xsl:attribute>
      <xsl:attribute name=""maxItems"">
        <xsl:text>1</xsl:text>
      </xsl:attribute>
      <xsl:attribute name=""rsStart"">
        <xsl:text>0</xsl:text>
      </xsl:attribute>
      <ns0:RRMISRQuery>
        <xsl:attribute name=""operandMode"">
          <xsl:text>AND</xsl:text>
        </xsl:attribute>
        <ns0:WHERE>
          <xsl:value-of select=""$var:v1"" />
        </ns0:WHERE>
      </ns0:RRMISRQuery>
    </ns0:QueryRRMISR>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry.TaskEnquiryRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+QueryRRMISR";
        
        private const global::MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo.QueryRRMISR _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+QueryRRMISR";
                return _TrgSchemas;
            }
        }
    }
}
