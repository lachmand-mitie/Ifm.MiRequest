namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskLoader+TaskLoadRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskLoader.TaskLoadRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+CreateRRMISR", typeof(global::MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo.CreateRRMISR))]
    public sealed class TaskRequest_To_RRCreateSr : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0 ScriptNS1"" version=""1.0"" xmlns:s0=""https://IFM.MiRequest.TaskLoader"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:ScriptNS1=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TaskLoadRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:TaskLoadRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;SR&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringLeft(string(Attribute008/text()) , &quot;100&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringUpperCase(string(Attribute016/text()))"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalNe(string($var:v5) , &quot;NONE&quot;)"" />
    <xsl:variable name=""var:v13"" select=""string(Attribute016/text())"" />
    <xsl:variable name=""var:v14"" select=""userCSharp:StringUpperCase($var:v13)"" />
    <xsl:variable name=""var:v15"" select=""userCSharp:LogicalNe(string($var:v14) , &quot;NONE&quot;)"" />
    <xsl:variable name=""var:v18"" select=""userCSharp:StringLeft(string(Attribute011/text()) , &quot;20&quot;)"" />
    <xsl:variable name=""var:v19"" select=""userCSharp:StringConcat(&quot;MIREQUEST&quot;)"" />
    <xsl:variable name=""var:v20"" select=""userCSharp:StringConcat(&quot;PORTAL&quot;)"" />
    <ns0:CreateRRMISR>
      <ns0:RRMISRSet>
        <ns0:SR>
          <ns0:ASSETNUM>
            <xsl:value-of select=""Attribute014/text()"" />
          </ns0:ASSETNUM>
          <ns0:ASSETORGID>
            <xsl:value-of select=""Attribute004/text()"" />
          </ns0:ASSETORGID>
          <ns0:ASSETSITEID>
            <xsl:value-of select=""Attribute003/text()"" />
          </ns0:ASSETSITEID>
          <ns0:CLASS>
            <xsl:value-of select=""$var:v1"" />
          </ns0:CLASS>
          <ns0:CLASSSTRUCTUREID>
            <xsl:variable name=""var:v2"" select=""ScriptNS0:OneTeamClassificationMapping(string(Attribute006/text()))"" />
            <xsl:value-of select=""$var:v2"" />
          </ns0:CLASSSTRUCTUREID>
          <ns0:DESCRIPTION>
            <xsl:value-of select=""$var:v3"" />
          </ns0:DESCRIPTION>
          <ns0:DESCRIPTION_LONGDESCRIPTION>
            <xsl:value-of select=""Attribute009/text()"" />
          </ns0:DESCRIPTION_LONGDESCRIPTION>
          <ns0:GLACCOUNT>
            <xsl:variable name=""var:v4"" select=""ScriptNS1:GetRrLocationGlcode(string(Attribute002/text()))"" />
            <ns0:VALUE>
              <xsl:value-of select=""$var:v4"" />
            </ns0:VALUE>
          </ns0:GLACCOUNT>
          <ns0:INTERNALPRIORITY>
            <xsl:if test=""string($var:v6)='true'"">
              <xsl:variable name=""var:v7"" select=""Contract/text()"" />
              <xsl:variable name=""var:v8"" select=""string(Attribute016/text())"" />
              <xsl:variable name=""var:v9"" select=""userCSharp:StringUpperCase($var:v8)"" />
              <xsl:variable name=""var:v10"" select=""userCSharp:LogicalNe(string($var:v9) , &quot;NONE&quot;)"" />
              <xsl:if test=""string($var:v10)='true'"">
                <xsl:variable name=""var:v11"" select=""Attribute016/text()"" />
                <xsl:variable name=""var:v12"" select=""ScriptNS0:OneTeanmPriorityMap(string($var:v7) , string($var:v11))"" />
                <xsl:value-of select=""$var:v12"" />
              </xsl:if>
            </xsl:if>
          </ns0:INTERNALPRIORITY>
          <ns0:LOCATION>
            <xsl:value-of select=""Attribute002/text()"" />
          </ns0:LOCATION>
          <ns0:MTFMSRCLIENTREF>
            <xsl:value-of select=""RequestRef/text()"" />
          </ns0:MTFMSRCLIENTREF>
          <ns0:ORGID>
            <xsl:value-of select=""Attribute004/text()"" />
          </ns0:ORGID>
          <ns0:PRJUST>
            <xsl:if test=""string($var:v15)='true'"">
              <xsl:variable name=""var:v16"" select=""Attribute018/text()"" />
              <xsl:variable name=""var:v17"" select=""userCSharp:StringLeft(string($var:v16) , &quot;50&quot;)"" />
              <xsl:value-of select=""$var:v17"" />
            </xsl:if>
          </ns0:PRJUST>
          <ns0:REPORTEDBY>
            <xsl:value-of select=""Attribute010/text()"" />
          </ns0:REPORTEDBY>
          <ns0:REPORTEDEMAIL>
            <xsl:value-of select=""Attribute019/text()"" />
          </ns0:REPORTEDEMAIL>
          <ns0:REPORTEDPHONE>
            <xsl:value-of select=""$var:v18"" />
          </ns0:REPORTEDPHONE>
          <xsl:for-each select=""ext01"">
            <ns0:RRBUSTYPE>
              <xsl:value-of select=""ext01attr00/text()"" />
            </ns0:RRBUSTYPE>
          </xsl:for-each>
          <xsl:for-each select=""ext01"">
            <ns0:RRCHARGEDEPT>
              <ns0:VALUE>
                <xsl:value-of select=""ext01attr01/text()"" />
              </ns0:VALUE>
            </ns0:RRCHARGEDEPT>
          </xsl:for-each>
          <xsl:for-each select=""ext01"">
            <ns0:SCHEMENUM>
              <xsl:value-of select=""ext01attr02/text()"" />
            </ns0:SCHEMENUM>
          </xsl:for-each>
          <ns0:SITEID>
            <xsl:value-of select=""Attribute003/text()"" />
          </ns0:SITEID>
          <ns0:SOURCE>
            <xsl:value-of select=""$var:v19"" />
          </ns0:SOURCE>
          <ns0:STATUS>
            <xsl:value-of select=""$var:v20"" />
          </ns0:STATUS>
        </ns0:SR>
      </ns0:RRMISRSet>
    </ns0:CreateRRMISR>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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


public string StringConcat(string param0)
{
   return param0;
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


public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
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
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Colleague.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=42852ac7e24bf0e7"" ClassName=""MFM.Colleague.Helper.MiRequestOneTeamClient"" />
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"" AssemblyName=""MFM.Colleague.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=42852ac7e24bf0e7"" ClassName=""MFM.Colleague.Helper.DataAccess"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskLoader+TaskLoadRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskLoader.TaskLoadRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+CreateRRMISR";
        
        private const global::MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo.CreateRRMISR _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.TaskLoader+TaskLoadRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MTFM._1TEAM.Services.GeneratedItems.RRMISR.RRMISR_www_ibm_com_maximo+CreateRRMISR";
                return _TrgSchemas;
            }
        }
    }
}
