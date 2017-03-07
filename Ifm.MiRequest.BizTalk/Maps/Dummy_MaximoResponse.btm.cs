namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskLoader+TaskLoadRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskLoader.TaskLoadRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskLoader+TaskLoadResponse", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskLoader.TaskLoadResponse))]
    public sealed class Dummy_MaximoResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""https://IFM.MiRequest.TaskLoader"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:TaskLoadRequest"" />
  </xsl:template>
  <xsl:template match=""/ns0:TaskLoadRequest"">
    <ns0:TaskLoadResponse>
      <RequestRef>
        <xsl:value-of select=""RequestRef/text()"" />
      </RequestRef>
      <ResultCode>
        <xsl:text>0</xsl:text>
      </ResultCode>
      <Message>
        <xsl:text>0</xsl:text>
      </Message>
      <ProviderRef>
        <xsl:text>0</xsl:text>
      </ProviderRef>
      <xsl:value-of select=""./text()"" />
    </ns0:TaskLoadResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskLoader+TaskLoadRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskLoader.TaskLoadRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskLoader+TaskLoadResponse";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskLoader.TaskLoadResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.TaskLoader+TaskLoadRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.TaskLoader+TaskLoadResponse";
                return _TrgSchemas;
            }
        }
    }
}
