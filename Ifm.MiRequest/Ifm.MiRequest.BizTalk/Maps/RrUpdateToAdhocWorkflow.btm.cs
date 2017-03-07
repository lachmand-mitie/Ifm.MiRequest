namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM._1TEAM.Services.Schemas.RRMISRSTATService+PublishRRMISRSTAT", typeof(global::MTFM._1TEAM.Services.Schemas.RRMISRSTATService.PublishRRMISRSTAT))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.AdhocWorkflow", typeof(global::Ifm.MiRequest.BizTalk.Schemas.AdhocWorkflow))]
    public sealed class RrUpdateToAdhocWorkflow : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://IFM.MiRequest.AdhocWorkflow"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PublishRRMISRSTAT"" />
  </xsl:template>
  <xsl:template match=""/s0:PublishRRMISRSTAT"">
    <ns0:AdhocWorkflow>
      <xsl:for-each select=""s0:RRMISRSTATSet/s0:SR"">
        <xsl:for-each select=""s0:WORKTYPE"">
          <Routing>
            <WorkType>
              <xsl:value-of select=""./text()"" />
            </WorkType>
            <xsl:if test=""../s0:STATUS"">
              <Status>
                <xsl:value-of select=""../s0:STATUS/text()"" />
              </Status>
            </xsl:if>
            <xsl:if test=""../s0:STATUS/@changed"">
              <StatusChanged>
                <xsl:value-of select=""../s0:STATUS/@changed"" />
              </StatusChanged>
            </xsl:if>
            <xsl:if test=""../s0:SOURCE"">
              <Source>
                <xsl:value-of select=""../s0:SOURCE/text()"" />
              </Source>
            </xsl:if>
          </Routing>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""s0:RRMISRSTATSet/s0:SR"">
        <xsl:for-each select=""s0:TICKETID"">
          <Workflow>
            <SRNumber>
              <xsl:value-of select=""./text()"" />
            </SRNumber>
            <xsl:if test=""../s0:REPORTEDBY"">
              <Name>
                <xsl:value-of select=""../s0:REPORTEDBY/text()"" />
              </Name>
            </xsl:if>
            <xsl:if test=""../s0:REPORTEDPHONE"">
              <Phone>
                <xsl:value-of select=""../s0:REPORTEDPHONE/text()"" />
              </Phone>
            </xsl:if>
            <xsl:if test=""../s0:REPORTEDEMAIL"">
              <Email>
                <xsl:value-of select=""../s0:REPORTEDEMAIL/text()"" />
              </Email>
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
            <xsl:if test=""../s0:WOWORKGROUP"">
              <WODetailsPersonGroup>
                <xsl:value-of select=""../s0:WOWORKGROUP/text()"" />
              </WODetailsPersonGroup>
            </xsl:if>
            <xsl:if test=""../s0:LOCATION"">
              <Location>
                <xsl:value-of select=""../s0:LOCATION/text()"" />
              </Location>
            </xsl:if>
            <xsl:for-each select=""../s0:RRCHARGEDEPT"">
              <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(s0:VALUE))"" />
              <xsl:if test=""$var:v1"">
                <xsl:variable name=""var:v2"" select=""boolean(s0:VALUE)"" />
                <xsl:variable name=""var:v3"" select=""userCSharp:LogicalExistence($var:v2)"" />
                <xsl:variable name=""var:v4"" select=""userCSharp:LogicalNot(string($var:v3))"" />
                <xsl:if test=""string($var:v4)='true'"">
                  <xsl:variable name=""var:v5"" select=""&quot;&quot;"" />
                  <ChargeDept>
                    <xsl:value-of select=""$var:v5"" />
                  </ChargeDept>
                </xsl:if>
              </xsl:if>
            </xsl:for-each>
            <xsl:if test=""../s0:SCHEMENUM"">
              <SchemeNo>
                <xsl:value-of select=""../s0:SCHEMENUM/text()"" />
              </SchemeNo>
            </xsl:if>
            <xsl:if test=""../s0:RRBUSTYPE"">
              <BusinessCase>
                <xsl:value-of select=""../s0:RRBUSTYPE/text()"" />
              </BusinessCase>
            </xsl:if>
          </Workflow>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:AdhocWorkflow>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
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

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MTFM._1TEAM.Services.Schemas.RRMISRSTATService+PublishRRMISRSTAT";
        
        private const global::MTFM._1TEAM.Services.Schemas.RRMISRSTATService.PublishRRMISRSTAT _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.AdhocWorkflow";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.AdhocWorkflow _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.AdhocWorkflow";
                return _TrgSchemas;
            }
        }
    }
}
