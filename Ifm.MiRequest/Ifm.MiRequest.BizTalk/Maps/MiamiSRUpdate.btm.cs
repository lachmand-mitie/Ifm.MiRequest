namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.MiAMI.Services.Schemas.MiamiSrPublished.MTFMSRSTATUSCHService+PublishMTFMSRSTATUSCH", typeof(global::MTFM.MiAMI.Services.Schemas.MiamiSrPublished.MTFMSRSTATUSCHService.PublishMTFMSRSTATUSCH))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd", typeof(global::Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd))]
    public sealed class MiamiSRUpdate : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PublishMTFMSRSTATUSCH"" />
  </xsl:template>
  <xsl:template match=""/s0:PublishMTFMSRSTATUSCH"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;Status changed to &quot; , string(s0:MTFMSRSTATUSCHSet/s0:SR/s0:STATUS/text()))"" />
    <miworldcolleaguerequestupd>
      <xsl:if test=""s0:MTFMSRSTATUSCHSet/s0:SR/s0:MTFMEDISONREF"">
        <mcid>
          <xsl:value-of select=""s0:MTFMSRSTATUSCHSet/s0:SR/s0:MTFMEDISONREF/text()"" />
        </mcid>
      </xsl:if>
      <xsl:if test=""s0:MTFMSRSTATUSCHSet/s0:SR/s0:TICKETID"">
        <helpdeskid>
          <xsl:value-of select=""s0:MTFMSRSTATUSCHSet/s0:SR/s0:TICKETID/text()"" />
        </helpdeskid>
      </xsl:if>
      <xsl:if test=""s0:MTFMSRSTATUSCHSet/s0:SR/s0:STATUS"">
        <jobstatus>
          <xsl:value-of select=""s0:MTFMSRSTATUSCHSet/s0:SR/s0:STATUS/text()"" />
        </jobstatus>
      </xsl:if>
      <body>
        <xsl:value-of select=""$var:v1"" />
      </body>
      <xsl:if test=""s0:MTFMSRSTATUSCHSet/s0:SR/s0:STATUSDATE"">
        <statuschangets>
          <xsl:value-of select=""s0:MTFMSRSTATUSCHSet/s0:SR/s0:STATUSDATE/text()"" />
        </statuschangets>
      </xsl:if>
      <xsl:value-of select=""./text()"" />
    </miworldcolleaguerequestupd>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MTFM.MiAMI.Services.Schemas.MiamiSrPublished.MTFMSRSTATUSCHService+PublishMTFMSRSTATUSCH";
        
        private const global::MTFM.MiAMI.Services.Schemas.MiamiSrPublished.MTFMSRSTATUSCHService.PublishMTFMSRSTATUSCH _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MTFM.MiAMI.Services.Schemas.MiamiSrPublished.MTFMSRSTATUSCHService+PublishMTFMSRSTATUSCH";
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
