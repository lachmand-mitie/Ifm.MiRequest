namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM._1TEAM.Services.Schemas.RRMISRSTATService+PublishRRMISRSTAT", typeof(global::MTFM._1TEAM.Services.Schemas.RRMISRSTATService.PublishRRMISRSTAT))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd", typeof(global::Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd))]
    public sealed class Rr_ro_PortalStatus : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://www.ibm.com/maximo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PublishRRMISRSTAT"" />
  </xsl:template>
  <xsl:template match=""/s0:PublishRRMISRSTAT"">
    <miworldcolleaguerequestupd>
      <xsl:if test=""s0:RRMISRSTATSet/s0:SR/s0:MTFMSRCLIENTREF"">
        <mcid>
          <xsl:value-of select=""s0:RRMISRSTATSet/s0:SR/s0:MTFMSRCLIENTREF/text()"" />
        </mcid>
      </xsl:if>
      <xsl:if test=""s0:RRMISRSTATSet/s0:SR/s0:TICKETID"">
        <helpdeskid>
          <xsl:value-of select=""s0:RRMISRSTATSet/s0:SR/s0:TICKETID/text()"" />
        </helpdeskid>
      </xsl:if>
      <xsl:if test=""s0:RRMISRSTATSet/s0:SR/s0:STATUS"">
        <jobstatus>
          <xsl:value-of select=""s0:RRMISRSTATSet/s0:SR/s0:STATUS/text()"" />
        </jobstatus>
      </xsl:if>
      <xsl:if test=""s0:RRMISRSTATSet/s0:SR/s0:STATUS"">
        <body>
          <xsl:value-of select=""s0:RRMISRSTATSet/s0:SR/s0:STATUS/text()"" />
        </body>
      </xsl:if>
      <xsl:if test=""s0:RRMISRSTATSet/s0:SR/s0:STATUSDATE"">
        <statuschangets>
          <xsl:value-of select=""s0:RRMISRSTATSet/s0:SR/s0:STATUSDATE/text()"" />
        </statuschangets>
      </xsl:if>
    </miworldcolleaguerequestupd>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MTFM._1TEAM.Services.Schemas.RRMISRSTATService+PublishRRMISRSTAT";
        
        private const global::MTFM._1TEAM.Services.Schemas.RRMISRSTATService.PublishRRMISRSTAT _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MTFM._1TEAM.Services.Schemas.RRMISRSTATService+PublishRRMISRSTAT";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd";
                return _TrgSchemas;
            }
        }
    }
}
