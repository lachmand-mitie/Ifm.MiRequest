namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.TaskLoader+TaskLoadRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.TaskLoader.TaskLoadRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo+SyncMTFMCONCEPTWOIN", typeof(global::MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo.SyncMTFMCONCEPTWOIN))]
    public sealed class TaskRequest_To_MiamiCreateOrder : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:s0=""https://IFM.MiRequest.TaskLoader"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TaskLoadRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:TaskLoadRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;CreateOrder&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;tony.arrighi@mitie.com;robert.thompson@mitie.com;sarah.nunn@mitie.com;Luqman.Hussain@mitie.com&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;VISIONFM&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringLeft(string(Attribute008/text()) , &quot;100&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;MIWORLDCOLLEAGUE&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;MIREQUEST&quot;)"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;WAPPR&quot;)"" />
    <ns0:SyncMTFMCONCEPTWOIN>
      <xsl:attribute name=""baseLanguage"">
        <xsl:value-of select=""$var:v1"" />
      </xsl:attribute>
      <xsl:attribute name=""transLanguage"">
        <xsl:value-of select=""$var:v2"" />
      </xsl:attribute>
      <ns0:MTFMCONCEPTWOINSet>
        <ns0:WORKORDER>
          <ns0:COMMODITY>
            <xsl:variable name=""var:v4"" select=""ScriptNS0:MxoCommodityMap(string(Attribute006/text()) , string($var:v3))"" />
            <xsl:value-of select=""$var:v4"" />
          </ns0:COMMODITY>
          <ns0:COMMODITYGROUP>
            <xsl:value-of select=""$var:v3"" />
          </ns0:COMMODITYGROUP>
          <ns0:DESCRIPTION>
            <xsl:value-of select=""$var:v5"" />
          </ns0:DESCRIPTION>
          <ns0:DESCRIPTION_LONGDESCRIPTION>
            <xsl:value-of select=""Attribute009/text()"" />
          </ns0:DESCRIPTION_LONGDESCRIPTION>
          <ns0:LOCATION>
            <xsl:value-of select=""Attribute002/text()"" />
          </ns0:LOCATION>
          <xsl:for-each select=""ext01"">
            <ns0:MTFMCLIENTPO>
              <xsl:value-of select=""ext01attr01/text()"" />
            </ns0:MTFMCLIENTPO>
          </xsl:for-each>
          <ns0:MTFMCLIENTREF>
            <xsl:value-of select=""RequestRef/text()"" />
          </ns0:MTFMCLIENTREF>
          <ns0:MTFMCLIENTSYS>
            <xsl:value-of select=""$var:v6"" />
          </ns0:MTFMCLIENTSYS>
          <ns0:MTFMWOLO2>
            <xsl:value-of select=""$var:v7"" />
          </ns0:MTFMWOLO2>
          <ns0:ONBEHALFOF>
            <xsl:value-of select=""Attribute010/text()"" />
          </ns0:ONBEHALFOF>
          <ns0:ORGID>
            <xsl:value-of select=""Attribute004/text()"" />
          </ns0:ORGID>
          <ns0:PHONE>
            <xsl:value-of select=""Attribute011/text()"" />
          </ns0:PHONE>
          <ns0:REPORTDATE>
            <xsl:value-of select=""$var:v8"" />
          </ns0:REPORTDATE>
          <ns0:REPORTEDBY>
            <xsl:value-of select=""$var:v6"" />
          </ns0:REPORTEDBY>
          <ns0:SITEID>
            <xsl:value-of select=""Attribute003/text()"" />
          </ns0:SITEID>
          <ns0:SOURCESYSID>
            <xsl:value-of select=""$var:v3"" />
          </ns0:SOURCESYSID>
          <ns0:STATUS>
            <xsl:value-of select=""$var:v9"" />
          </ns0:STATUS>
          <ns0:WOLO2>
            <xsl:value-of select=""$var:v7"" />
          </ns0:WOLO2>
          <ns0:WOPRIORITY>
            <xsl:variable name=""var:v10"" select=""ScriptNS0:MxoPriorityMap(string(Contract/text()) , string(Attribute016/text()))"" />
            <xsl:value-of select=""$var:v10"" />
          </ns0:WOPRIORITY>
          <ns0:WORKTYPE>
            <xsl:value-of select=""Attribute001/text()"" />
          </ns0:WORKTYPE>
        </ns0:WORKORDER>
      </ns0:MTFMCONCEPTWOINSet>
    </ns0:SyncMTFMCONCEPTWOIN>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
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
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Colleague.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=42852ac7e24bf0e7"" ClassName=""MFM.Colleague.Helper.MiRequestMaximoClient"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.TaskLoader+TaskLoadRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.TaskLoader.TaskLoadRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo+SyncMTFMCONCEPTWOIN";
        
        private const global::MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo.SyncMTFMCONCEPTWOIN _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MTFM.MiAMI.Services.GeneratedItems.MTFMCONCEPTWOIN_www_ibm_com_maximo+SyncMTFMCONCEPTWOIN";
                return _TrgSchemas;
            }
        }
    }
}
