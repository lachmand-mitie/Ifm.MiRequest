namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL", typeof(global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd", typeof(global::Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd))]
    public sealed class MiAMI_to_PortalStatus : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 ScriptNS0 userCSharp"" version=""1.0"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PublishMTFMWODETAIL"" />
  </xsl:template>
  <xsl:template match=""/s0:PublishMTFMWODETAIL"">
    <miworldcolleaguerequestupd>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:MTFMCLIENTREF"">
        <mcid>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:MTFMCLIENTREF/text()"" />
        </mcid>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:WONUM"">
        <helpdeskid>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:WONUM/text()"" />
        </helpdeskid>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUS"">
        <jobstatus>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUS/text()"" />
        </jobstatus>
      </xsl:if>
      <xsl:variable name=""var:v1"" select=""ScriptNS0:GetStatusText(string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUS/text()) , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:ACTSTART/text()) , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:ACTFINISH/text()) , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:MTFM_REASON/text()))"" />
      <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(string($var:v1) , &quot; &quot; , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:NP_STATUSMEMO/text()))"" />
      <body>
        <xsl:value-of select=""$var:v2"" />
      </body>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUSDATE"">
        <statuschangets>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUSDATE/text()"" />
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
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Colleague.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=42852ac7e24bf0e7"" ClassName=""MFM.Colleague.Helper.MiRequestMaximoClient"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL";
        
        private const global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL";
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
