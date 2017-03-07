namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.AddDocument+AddDocumentRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.AddDocument.AddDocumentRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM._1TEAM.Services.GeneratedItems.RRMISRDOC.RRMISRDOC_www_ibm_com_maximo+UpdateRRMISRDOC", typeof(global::MTFM._1TEAM.Services.GeneratedItems.RRMISRDOC.RRMISRDOC_www_ibm_com_maximo.UpdateRRMISRDOC))]
    public sealed class GetRrAttachment : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://IFM.MiRequest.AddDocument"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AddDocumentRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:AddDocumentRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;SR&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;Attachments&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;FILE&quot;)"" />
    <ns0:UpdateRRMISRDOC>
      <ns0:RRMISRDOCSet>
        <ns0:SR>
          <xsl:attribute name=""action"">
            <xsl:text>Change</xsl:text>
          </xsl:attribute>
          <ns0:CLASS>
            <xsl:value-of select=""$var:v1"" />
          </ns0:CLASS>
          <ns0:TICKETID>
            <xsl:value-of select=""ProviderRef/text()"" />
          </ns0:TICKETID>
          <ns0:DOCLINKS>
            <xsl:attribute name=""action"">
              <xsl:text>Add</xsl:text>
            </xsl:attribute>
            <ns0:ADDINFO>
              <xsl:value-of select=""$var:v2"" />
            </ns0:ADDINFO>
            <ns0:DESCRIPTION>
              <xsl:value-of select=""DocRequest/FileDescription/text()"" />
            </ns0:DESCRIPTION>
            <ns0:DOCTYPE>
              <xsl:value-of select=""$var:v3"" />
            </ns0:DOCTYPE>
            <ns0:DOCUMENTDATA>
              <xsl:value-of select=""DocRequest/FileContent/text()"" />
            </ns0:DOCUMENTDATA>
            <ns0:NEWURLNAME>
              <xsl:value-of select=""DocRequest/FileName/text()"" />
            </ns0:NEWURLNAME>
            <ns0:URLTYPE>
              <xsl:value-of select=""$var:v4"" />
            </ns0:URLTYPE>
            <xsl:value-of select=""DocRequest/text()"" />
          </ns0:DOCLINKS>
        </ns0:SR>
      </ns0:RRMISRDOCSet>
      <xsl:value-of select=""./text()"" />
    </ns0:UpdateRRMISRDOC>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.AddDocument+AddDocumentRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.AddDocument.AddDocumentRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM._1TEAM.Services.GeneratedItems.RRMISRDOC.RRMISRDOC_www_ibm_com_maximo+UpdateRRMISRDOC";
        
        private const global::MTFM._1TEAM.Services.GeneratedItems.RRMISRDOC.RRMISRDOC_www_ibm_com_maximo.UpdateRRMISRDOC _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.AddDocument+AddDocumentRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MTFM._1TEAM.Services.GeneratedItems.RRMISRDOC.RRMISRDOC_www_ibm_com_maximo+UpdateRRMISRDOC";
                return _TrgSchemas;
            }
        }
    }
}
