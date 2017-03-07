namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskUpdate+TaskUpdateRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskUpdate.TaskUpdateRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+UpdateRRMISR", typeof(global::MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo.UpdateRRMISR))]
    public sealed class TaskUpdateRequestToRrStatusUpdate : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:s0=""http://IFM.MiRequest.TaskUpdate"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TaskUpdateRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:TaskUpdateRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;SR&quot;)"" />
    <ns0:UpdateRRMISR>
      <ns0:RRMISRSet>
        <ns0:SR>
          <ns0:CLASS>
            <xsl:value-of select=""$var:v1"" />
          </ns0:CLASS>
          <ns0:STATUS>
            <xsl:variable name=""var:v2"" select=""ScriptNS0:OneTeamStatusMapping(string(TaskUpdate/Attribute01/text()))"" />
            <xsl:value-of select=""$var:v2"" />
          </ns0:STATUS>
          <ns0:TICKETID>
            <xsl:value-of select=""ProviderRef/text()"" />
          </ns0:TICKETID>
        </ns0:SR>
      </ns0:RRMISRSet>
    </ns0:UpdateRRMISR>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Colleague.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=42852ac7e24bf0e7"" ClassName=""MFM.Colleague.Helper.MiRequestOneTeamClient"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskUpdate+TaskUpdateRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskUpdate.TaskUpdateRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+UpdateRRMISR";
        
        private const global::MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo.UpdateRRMISR _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.TaskUpdate+TaskUpdateRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+UpdateRRMISR";
                return _TrgSchemas;
            }
        }
    }
}
