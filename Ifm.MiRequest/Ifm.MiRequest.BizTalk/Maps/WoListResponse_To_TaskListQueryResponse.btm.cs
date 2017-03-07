namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo+QueryMTFMCONCEPTWOINResponse", typeof(global::MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo.QueryMTFMCONCEPTWOINResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskListQuery+TaskListResponse", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskListQuery.TaskListResponse))]
    public sealed class WoListResponse_To_TaskListQueryResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""https://IFM.MiRequest.TaskListQuery"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryMTFMCONCEPTWOINResponse"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryMTFMCONCEPTWOINResponse"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(@rsTotal) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v3"" select=""string(@rsTotal)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalGt($var:v3 , &quot;0&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalEq($var:v3 , &quot;0&quot;)"" />
    <ns0:TaskListResponse>
      <Result>
        <xsl:if test=""string($var:v1)='true'"">
          <xsl:variable name=""var:v2"" select=""&quot;-1&quot;"" />
          <ErrorCode>
            <xsl:value-of select=""$var:v2"" />
          </ErrorCode>
        </xsl:if>
        <xsl:if test=""string($var:v4)='true'"">
          <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;0&quot;)"" />
          <ErrorCode>
            <xsl:value-of select=""$var:v5"" />
          </ErrorCode>
        </xsl:if>
        <xsl:if test=""string($var:v6)='true'"">
          <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;NOMATCH&quot;)"" />
          <Message>
            <xsl:value-of select=""$var:v7"" />
          </Message>
        </xsl:if>
        <xsl:if test=""string($var:v4)='true'"">
          <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(&quot;Matched&quot;)"" />
          <Message>
            <xsl:value-of select=""$var:v8"" />
          </Message>
        </xsl:if>
        <User>
          <xsl:text>DUMMY</xsl:text>
        </User>
        <xsl:if test=""@rsTotal"">
          <Total>
            <xsl:value-of select=""@rsTotal"" />
          </Total>
        </xsl:if>
        <xsl:if test=""@rsStart"">
          <Starts>
            <xsl:value-of select=""@rsStart"" />
          </Starts>
        </xsl:if>
        <xsl:for-each select=""s0:MTFMCONCEPTWOINSet/s0:WORKORDER"">
          <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;MiAMI&quot;)"" />
          <TaskItem>
            <xsl:if test=""s0:MTFMCLIENTREF"">
              <PortalRef>
                <xsl:value-of select=""s0:MTFMCLIENTREF/text()"" />
              </PortalRef>
            </xsl:if>
            <Provider>
              <xsl:value-of select=""$var:v9"" />
            </Provider>
            <xsl:if test=""s0:WONUM"">
              <ProviderRef>
                <xsl:value-of select=""s0:WONUM/text()"" />
              </ProviderRef>
            </xsl:if>
            <xsl:if test=""s0:STATUS"">
              <State01>
                <xsl:value-of select=""s0:STATUS/text()"" />
              </State01>
            </xsl:if>
            <xsl:value-of select=""./text()"" />
          </TaskItem>
        </xsl:for-each>
      </Result>
    </ns0:TaskListResponse>
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


public bool LogicalGt(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 > d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;
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
        
        private const string _strTrgSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskListQuery+TaskListResponse";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskListQuery.TaskListResponse _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.TaskListQuery+TaskListResponse";
                return _TrgSchemas;
            }
        }
    }
}
