namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL", typeof(global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd", typeof(global::Ifm.MiRequest.BizTalk.Schemas.miworldcolleaguerequestupd))]
    public sealed class MiAMI_to_PortalOther : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
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
      <xsl:for-each select=""s0:MTFMWODETAILSet/s0:WORKORDER"">
        <xsl:for-each select=""s0:WOPRIORITY"">
          <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(@changed) , &quot;1&quot;)"" />
          <xsl:if test=""string($var:v1)='true'"">
            <xsl:variable name=""var:v2"" select=""./text()"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;Priority Set: &quot; , string($var:v2))"" />
            <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq(string(../s0:TARGSTARTDATE/@changed) , &quot;1&quot;)"" />
            <xsl:if test=""string($var:v4)='true'"">
              <xsl:variable name=""var:v5"" select=""../s0:TARGSTARTDATE/text()"" />
              <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;Start by set: &quot; , string($var:v5))"" />
              <xsl:variable name=""var:v7"" select=""userCSharp:LogicalEq(string(../s0:TARGCOMPDATE/@changed) , &quot;1&quot;)"" />
              <xsl:if test=""string($var:v7)='true'"">
                <xsl:variable name=""var:v8"" select=""../s0:TARGCOMPDATE/text()"" />
                <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;Complete by set: &quot; , string($var:v8))"" />
                <xsl:variable name=""var:v10"" select=""userCSharp:LogicalEq(string(../s0:ACTSTART/@changed) , &quot;1&quot;)"" />
                <xsl:if test=""string($var:v10)='true'"">
                  <xsl:variable name=""var:v11"" select=""../s0:ACTSTART/text()"" />
                  <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(&quot;Work commenced: &quot; , string($var:v11))"" />
                  <xsl:variable name=""var:v13"" select=""userCSharp:LogicalEq(string(../s0:ACTFINISH/@changed) , &quot;1&quot;)"" />
                  <xsl:if test=""string($var:v13)='true'"">
                    <xsl:variable name=""var:v14"" select=""../s0:ACTFINISH/text()"" />
                    <xsl:variable name=""var:v15"" select=""userCSharp:StringConcat(&quot;Work completed: &quot; , string($var:v14))"" />
                    <xsl:variable name=""var:v16"" select=""userCSharp:StringConcat(string($var:v3) , &quot; &quot; , string($var:v6) , &quot; &quot; , string($var:v9) , string($var:v12) , string($var:v15))"" />
                    <body>
                      <xsl:value-of select=""$var:v16"" />
                    </body>
                  </xsl:if>
                </xsl:if>
              </xsl:if>
            </xsl:if>
          </xsl:if>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUSDATE"">
        <statuschangets>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUSDATE/text()"" />
        </statuschangets>
      </xsl:if>
    </miworldcolleaguerequestupd>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
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


public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6;
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
