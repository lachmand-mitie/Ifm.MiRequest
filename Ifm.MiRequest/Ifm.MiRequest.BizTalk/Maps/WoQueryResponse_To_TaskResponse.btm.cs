namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo+QueryMTFMCONCEPTWOINResponse", typeof(global::MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo.QueryMTFMCONCEPTWOINResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry+TaskEnquiryResponse", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskEnquiry.TaskEnquiryResponse))]
    public sealed class WoQueryResponse_To_TaskResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""https://IFM.MiRequest.TaskEnquiry"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryMTFMCONCEPTWOINResponse"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryMTFMCONCEPTWOINResponse"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(@rsTotal) , &quot;1&quot;)"" />
    <xsl:variable name=""var:v3"" select=""string(@rsTotal)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalNe($var:v3 , &quot;1&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalEq($var:v3 , &quot;1&quot;)"" />
    <ns0:TaskEnquiryResponse>
      <Result>
        <xsl:if test=""string($var:v1)='true'"">
          <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;0&quot;)"" />
          <ResultCode>
            <xsl:value-of select=""$var:v2"" />
          </ResultCode>
        </xsl:if>
        <xsl:if test=""string($var:v4)='true'"">
          <xsl:variable name=""var:v5"" select=""&quot;-1&quot;"" />
          <ResultCode>
            <xsl:value-of select=""$var:v5"" />
          </ResultCode>
        </xsl:if>
        <xsl:if test=""string($var:v6)='true'"">
          <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;Matched&quot;)"" />
          <Message>
            <xsl:value-of select=""$var:v7"" />
          </Message>
        </xsl:if>
        <xsl:if test=""string($var:v4)='true'"">
          <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(&quot;NOMATCH&quot;)"" />
          <Message>
            <xsl:value-of select=""$var:v8"" />
          </Message>
        </xsl:if>
        <PortalRef>
          <xsl:text>DUMMY</xsl:text>
        </PortalRef>
        <xsl:for-each select=""s0:MTFMCONCEPTWOINSet/s0:WORKORDER"">
          <xsl:for-each select=""s0:WONUM"">
            <Task>
              <ProviderRef>
                <xsl:value-of select=""./text()"" />
              </ProviderRef>
              <xsl:if test=""../s0:STATUS"">
                <State01>
                  <xsl:value-of select=""../s0:STATUS/text()"" />
                </State01>
              </xsl:if>
              <xsl:if test=""../s0:STATUSDATE"">
                <StateChanged>
                  <xsl:value-of select=""../s0:STATUSDATE/text()"" />
                </StateChanged>
              </xsl:if>
              <xsl:if test=""../s0:DESCRIPTION"">
                <Summary>
                  <xsl:value-of select=""../s0:DESCRIPTION/text()"" />
                </Summary>
              </xsl:if>
              <xsl:if test=""../s0:DESCRIPTION_LONGDESCRIPTION"">
                <Details>
                  <xsl:value-of select=""../s0:DESCRIPTION_LONGDESCRIPTION/text()"" />
                </Details>
              </xsl:if>
              <xsl:if test=""../s0:MTFM_REASON"">
                <AdditionalInfo>
                  <xsl:value-of select=""../s0:MTFM_REASON/text()"" />
                </AdditionalInfo>
              </xsl:if>
              <xsl:if test=""../s0:TARGSTARTDATE"">
                <keydate01>
                  <xsl:value-of select=""../s0:TARGSTARTDATE/text()"" />
                </keydate01>
              </xsl:if>
              <xsl:if test=""../s0:TARGCOMPDATE"">
                <keydate02>
                  <xsl:value-of select=""../s0:TARGCOMPDATE/text()"" />
                </keydate02>
              </xsl:if>
              <xsl:if test=""../s0:ACTSTART"">
                <keydate03>
                  <xsl:value-of select=""../s0:ACTSTART/text()"" />
                </keydate03>
              </xsl:if>
              <xsl:if test=""../s0:ACTFINISH"">
                <keydate04>
                  <xsl:value-of select=""../s0:ACTFINISH/text()"" />
                </keydate04>
              </xsl:if>
              <xsl:if test=""../s0:LOCATION"">
                <Location01>
                  <xsl:value-of select=""../s0:LOCATION/text()"" />
                </Location01>
              </xsl:if>
              <Notes>
                <xsl:for-each select=""../s0:WORKLOG"">
                  <Log>
                    <xsl:if test=""s0:DESCRIPTION"">
                      <Description>
                        <xsl:value-of select=""s0:DESCRIPTION/text()"" />
                      </Description>
                    </xsl:if>
                    <xsl:if test=""s0:DESCRIPTION_LONGDESCRIPTION"">
                      <LongDescription>
                        <xsl:value-of select=""s0:DESCRIPTION_LONGDESCRIPTION/text()"" />
                      </LongDescription>
                    </xsl:if>
                    <xsl:if test=""s0:CLIENTVIEWABLE"">
                      <ClientViewable>
                        <xsl:value-of select=""s0:CLIENTVIEWABLE/text()"" />
                      </ClientViewable>
                    </xsl:if>
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
        <xsl:value-of select=""s0:MTFMCONCEPTWOINSet/text()"" />
      </Result>
      <xsl:value-of select=""./text()"" />
    </ns0:TaskEnquiryResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public bool LogicalNe(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 != d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) != 0;
	}
	return ret;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo+QueryMTFMCONCEPTWOINResponse";
        
        private const global::MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo.QueryMTFMCONCEPTWOINResponse _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo+QueryMTFMCONCEPTWOINResponse";
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
