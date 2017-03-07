namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM._1TEAM.Services.Schemas.RRMIWORKLOGService+PublishRRMIWORKLOG", typeof(global::MTFM._1TEAM.Services.Schemas.RRMIWORKLOGService.PublishRRMIWORKLOG))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd", typeof(global::Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd))]
    public sealed class Rr_to_PortalLatestLog : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 ScriptNS0 userCSharp"" version=""1.0"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PublishRRMIWORKLOG"" />
  </xsl:template>
  <xsl:template match=""/s0:PublishRRMIWORKLOG"">
    <miworldcolleaguerequestupd>
      <xsl:if test=""s0:RRMIWORKLOGSet/s0:WORKLOG/s0:SR/s0:MTFMSRCLIENTREF"">
        <mcid>
          <xsl:value-of select=""s0:RRMIWORKLOGSet/s0:WORKLOG/s0:SR/s0:MTFMSRCLIENTREF/text()"" />
        </mcid>
      </xsl:if>
      <xsl:if test=""s0:RRMIWORKLOGSet/s0:WORKLOG/s0:RECORDKEY"">
        <helpdeskid>
          <xsl:value-of select=""s0:RRMIWORKLOGSet/s0:WORKLOG/s0:RECORDKEY/text()"" />
        </helpdeskid>
      </xsl:if>
      <xsl:if test=""s0:RRMIWORKLOGSet/s0:WORKLOG/s0:SR/s0:STATUS"">
        <jobstatus>
          <xsl:value-of select=""s0:RRMIWORKLOGSet/s0:WORKLOG/s0:SR/s0:STATUS/text()"" />
        </jobstatus>
      </xsl:if>
      <xsl:variable name=""var:v1"" select=""ScriptNS0:RemoveScriptFromPlainText(string(s0:RRMIWORKLOGSet/s0:WORKLOG/s0:DESCRIPTION/text()))"" />
      <xsl:variable name=""var:v2"" select=""ScriptNS0:RemoveScriptFromPlainText(string(s0:RRMIWORKLOGSet/s0:WORKLOG/s0:DESCRIPTION_LONGDESCRIPTION/text()))"" />
      <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(string($var:v1) , &quot;: &quot; , string($var:v2))"" />
      <body>
        <xsl:value-of select=""$var:v3"" />
      </body>
      <xsl:if test=""s0:RRMIWORKLOGSet/s0:WORKLOG/s0:CREATEDATE"">
        <statuschangets>
          <xsl:value-of select=""s0:RRMIWORKLOGSet/s0:WORKLOG/s0:CREATEDATE/text()"" />
        </statuschangets>
      </xsl:if>
    </miworldcolleaguerequestupd>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Colleague.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=42852ac7e24bf0e7"" ClassName=""MFM.Colleague.Helper.PortalClient"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MTFM._1TEAM.Services.Schemas.RRMIWORKLOGService+PublishRRMIWORKLOG";
        
        private const global::MTFM._1TEAM.Services.Schemas.RRMIWORKLOGService.PublishRRMIWORKLOG _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MTFM._1TEAM.Services.Schemas.RRMIWORKLOGService+PublishRRMIWORKLOG";
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
