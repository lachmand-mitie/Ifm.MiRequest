namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.AddDocument+AddDocumentRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.AddDocument.AddDocumentRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.MiAMI.Services.Schemas.AttachmentRequest", typeof(global::MTFM.MiAMI.Services.Schemas.AttachmentRequest))]
    public sealed class PostDocument_to_MiamiDocument : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://MTFM.MiAMI.Services.AttachmentRequest"" xmlns:s0=""http://IFM.MiRequest.AddDocument"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AddDocumentRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:AddDocumentRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;DUMMYVAL&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(string(ProviderRef/text()) , &quot;_&quot; , string(DocRequest/FileName/text()))"" />
    <ns0:MiAMIWonumAttachmentRequest>
      <Wonum>
        <xsl:value-of select=""ProviderRef/text()"" />
      </Wonum>
      <Location>
        <xsl:value-of select=""ClientLocation/text()"" />
      </Location>
      <SiteId>
        <xsl:value-of select=""$var:v1"" />
      </SiteId>
      <FileContent>
        <xsl:value-of select=""DocRequest/FileContent/text()"" />
      </FileContent>
      <FileType>
        <xsl:value-of select=""DocRequest/FileType/text()"" />
      </FileType>
      <FileDescription>
        <xsl:value-of select=""DocRequest/FileDescription/text()"" />
      </FileDescription>
      <FileName>
        <xsl:value-of select=""$var:v2"" />
      </FileName>
    </ns0:MiAMIWonumAttachmentRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.AddDocument+AddDocumentRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.AddDocument.AddDocumentRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM.MiAMI.Services.Schemas.AttachmentRequest";
        
        private const global::MTFM.MiAMI.Services.Schemas.AttachmentRequest _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MTFM.MiAMI.Services.Schemas.AttachmentRequest";
                return _TrgSchemas;
            }
        }
    }
}
