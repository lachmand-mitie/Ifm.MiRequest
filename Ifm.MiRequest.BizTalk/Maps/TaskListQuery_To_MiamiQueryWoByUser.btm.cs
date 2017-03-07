namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskListQuery+TaskListRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskListQuery.TaskListRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo+QueryMTFMCONCEPTWOIN", typeof(global::MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo.QueryMTFMCONCEPTWOIN))]
    public sealed class TaskListQuery_To_MiamiQueryWoByUser : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:s0=""https://IFM.MiRequest.TaskListQuery"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TaskListRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:TaskListRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;10&quot;)"" />
    <ns0:QueryMTFMCONCEPTWOIN>
      <xsl:attribute name=""uniqueResult"">
        <xsl:text>0</xsl:text>
      </xsl:attribute>
      <xsl:attribute name=""maxItems"">
        <xsl:value-of select=""$var:v1"" />
      </xsl:attribute>
      <xsl:attribute name=""rsStart"">
        <xsl:value-of select=""start/text()"" />
      </xsl:attribute>
      <ns0:MTFMCONCEPTWOINQuery>
        <xsl:attribute name=""operandMode"">
          <xsl:text>AND</xsl:text>
        </xsl:attribute>
        <xsl:variable name=""var:v2"" select=""ScriptNS0:GetWoListQueryWhere(string(user/text()))"" />
        <ns0:WHERE>
          <xsl:value-of select=""$var:v2"" />
        </ns0:WHERE>
      </ns0:MTFMCONCEPTWOINQuery>
    </ns0:QueryMTFMCONCEPTWOIN>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Colleague.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=42852ac7e24bf0e7"" ClassName=""MFM.Colleague.Helper.MiRequestMaximoClient"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskListQuery+TaskListRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskListQuery.TaskListRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo+QueryMTFMCONCEPTWOIN";
        
        private const global::MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo.QueryMTFMCONCEPTWOIN _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.TaskListQuery+TaskListRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo+QueryMTFMCONCEPTWOIN";
                return _TrgSchemas;
            }
        }
    }
}
