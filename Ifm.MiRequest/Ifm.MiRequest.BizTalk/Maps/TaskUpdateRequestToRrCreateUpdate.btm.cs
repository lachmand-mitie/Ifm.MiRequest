namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskUpdate+TaskUpdateRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskUpdate.TaskUpdateRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+UpdateRRMISR", typeof(global::MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo.UpdateRRMISR))]
    public sealed class TaskUpdateRequestToRrCreateUpdate : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://IFM.MiRequest.TaskUpdate"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TaskUpdateRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:TaskUpdateRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;SR&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;MiColleague Update: &quot; , string(TaskUpdate/Attribute02/text()))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringLeft(string($var:v2) , &quot;100&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(string(TaskUpdate/Attribute01/text()) , &quot; (&quot; , string(TaskUpdate/Attribute03/text()) , &quot;) &quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;EXT_CLIENT&quot;)"" />
    <ns0:UpdateRRMISR>
      <ns0:RRMISRSet>
        <ns0:SR>
          <xsl:attribute name=""action"">
            <xsl:text>Change</xsl:text>
          </xsl:attribute>
          <ns0:CLASS>
            <xsl:value-of select=""$var:v1"" />
          </ns0:CLASS>
          <ns0:TICKETID>
            <xsl:value-of select=""ProviderRef/text()"" />
          </ns0:TICKETID>
          <ns0:WORKLOG>
            <xsl:attribute name=""action"">
              <xsl:text>Add</xsl:text>
            </xsl:attribute>
            <ns0:DESCRIPTION>
              <xsl:value-of select=""$var:v3"" />
            </ns0:DESCRIPTION>
            <ns0:DESCRIPTION_LONGDESCRIPTION>
              <xsl:value-of select=""$var:v4"" />
            </ns0:DESCRIPTION_LONGDESCRIPTION>
            <ns0:LOGTYPE>
              <xsl:value-of select=""$var:v5"" />
            </ns0:LOGTYPE>
          </ns0:WORKLOG>
        </ns0:SR>
      </ns0:RRMISRSet>
    </ns0:UpdateRRMISR>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public string StringLeft(string str, string count)
{
	string retval = """";
	double d = 0;
	if (str != null && IsNumeric(count, ref d))
	{
		int i = (int) d;
		if (i > 0)
		{ 
			if (i <= str.Length)
			{
				retval = str.Substring(0, i);
			}
			else
			{
				retval = str;
			}
		}
	}
	return retval;
}


public string StringConcat(string param0, string param1, string param2, string param3)
{
   return param0 + param1 + param2 + param3;
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
