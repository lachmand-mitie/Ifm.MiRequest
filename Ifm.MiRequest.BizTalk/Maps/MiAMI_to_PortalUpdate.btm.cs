namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL", typeof(global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.PortalLightweightUpdate", typeof(global::Ifm.MiRequest.BizTalk.Schemas.PortalLightweightUpdate))]
    public sealed class MiAMI_to_PortalUpdate : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""https://IFM.MiRequest.PortalLightweightUpdate"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PublishMTFMWODETAIL"" />
  </xsl:template>
  <xsl:template match=""/s0:PublishMTFMWODETAIL"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;MIAMI&quot;)"" />
    <ns0:MiRequestPortalUpdate>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:MTFMCLIENTREF"">
        <PortalRef>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:MTFMCLIENTREF/text()"" />
        </PortalRef>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:WONUM"">
        <ProviderRef>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:WONUM/text()"" />
        </ProviderRef>
      </xsl:if>
      <Provider>
        <xsl:value-of select=""$var:v1"" />
      </Provider>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUS"">
        <Status>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUS/text()"" />
        </Status>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUSDATE"">
        <StatusData>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUSDATE/text()"" />
        </StatusData>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUS/@changed"">
        <IsStatusChange>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUS/@changed"" />
        </IsStatusChange>
      </xsl:if>
    </ns0:MiRequestPortalUpdate>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL";
        
        private const global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.PortalLightweightUpdate";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.PortalLightweightUpdate _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.PortalLightweightUpdate";
                return _TrgSchemas;
            }
        }
    }
}
