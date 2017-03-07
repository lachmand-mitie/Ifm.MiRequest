namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+QueryRRMISRResponse", typeof(global::MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo.QueryRRMISRResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryResponse", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry.TaskEnquiryResponse))]
    public sealed class RrSrQuertResponse_to_TaskEnquiryResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:ns0=""https://IFM.MiRequest.TaskEnquiry"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryRRMISRResponse"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryRRMISRResponse"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;Dummy&quot;)"" />
    <ns0:TaskEnquiryResponse>
      <Result>
        <ResultCode>
          <xsl:value-of select=""$var:v1"" />
        </ResultCode>
        <Message>
          <xsl:value-of select=""$var:v1"" />
        </Message>
        <PortalRef>
          <xsl:value-of select=""$var:v1"" />
        </PortalRef>
        <xsl:for-each select=""s0:RRMISRSet/s0:SR"">
          <xsl:for-each select=""s0:TICKETID"">
            <Task>
              <ProviderRef>
                <xsl:value-of select=""./text()"" />
              </ProviderRef>
              <xsl:variable name=""var:v2"" select=""ScriptNS0:RemoveScriptFromPlainText(string(../s0:DESCRIPTION/text()))"" />
              <Summary>
                <xsl:value-of select=""$var:v2"" />
              </Summary>
              <xsl:variable name=""var:v3"" select=""ScriptNS0:RemoveScriptFromPlainText(string(../s0:DESCRIPTION_LONGDESCRIPTION/text()))"" />
              <Details>
                <xsl:value-of select=""$var:v3"" />
              </Details>
              <xsl:if test=""../s0:LOCATION"">
                <Location01>
                  <xsl:value-of select=""../s0:LOCATION/text()"" />
                </Location01>
              </xsl:if>
              <Notes>
                <xsl:for-each select=""../s0:WORKLOG"">
                  <Log>
                    <xsl:variable name=""var:v4"" select=""ScriptNS0:RemoveScriptFromPlainText(string(s0:DESCRIPTION/text()))"" />
                    <Description>
                      <xsl:value-of select=""$var:v4"" />
                    </Description>
                    <xsl:variable name=""var:v5"" select=""ScriptNS0:RemoveScriptFromPlainText(string(s0:DESCRIPTION_LONGDESCRIPTION/text()))"" />
                    <LongDescription>
                      <xsl:value-of select=""$var:v5"" />
                    </LongDescription>
                    <xsl:if test=""s0:CREATEDATE"">
                      <CreatedTs>
                        <xsl:value-of select=""s0:CREATEDATE/text()"" />
                      </CreatedTs>
                    </xsl:if>
                    <xsl:if test=""s0:LOGTYPE"">
                      <LogType>
                        <xsl:value-of select=""s0:LOGTYPE/text()"" />
                      </LogType>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </Log>
                </xsl:for-each>
              </Notes>
            </Task>
          </xsl:for-each>
        </xsl:for-each>
      </Result>
    </ns0:TaskEnquiryResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Colleague.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=42852ac7e24bf0e7"" ClassName=""MFM.Colleague.Helper.PortalClient"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+QueryRRMISRResponse";
        
        private const global::MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo.QueryRRMISRResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryResponse";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry.TaskEnquiryResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+QueryRRMISRResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryResponse";
                return _TrgSchemas;
            }
        }
    }
}
