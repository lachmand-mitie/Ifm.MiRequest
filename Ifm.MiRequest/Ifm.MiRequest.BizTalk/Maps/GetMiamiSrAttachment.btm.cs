namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.AddDocument+AddDocumentRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.AddDocument.AddDocumentRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.MiAMI.Services.GeneratedItems.MTFMSERVICEREQ.MTFMSERVICEREQ_www_ibm_com_maximo+UpdateMTFMSERVICEREQ", typeof(global::MTFM.MiAMI.Services.GeneratedItems.MTFMSERVICEREQ.MTFMSERVICEREQ_www_ibm_com_maximo.UpdateMTFMSERVICEREQ))]
    public sealed class GetMiamiSrAttachment : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://IFM.MiRequest.AddDocument"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AddDocumentRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:AddDocumentRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;Change&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;SR&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;Add&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;Attachments&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(string(DocRequest/FileName/text()) , &quot;.&quot; , string(DocRequest/FileType/text()))"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;FILE&quot;)"" />
    <ns0:UpdateMTFMSERVICEREQ>
      <ns0:MTFMSERVICEREQSet>
        <ns0:SR>
          <xsl:attribute name=""action"">
            <xsl:value-of select=""$var:v1"" />
          </xsl:attribute>
          <ns0:CLASS>
            <xsl:value-of select=""$var:v2"" />
          </ns0:CLASS>
          <ns0:TICKETID>
            <xsl:value-of select=""ProviderRef/text()"" />
          </ns0:TICKETID>
          <ns0:DOCLINKS>
            <xsl:attribute name=""action"">
              <xsl:value-of select=""$var:v3"" />
            </xsl:attribute>
            <ns0:ADDINFO>
              <xsl:value-of select=""$var:v4"" />
            </ns0:ADDINFO>
            <ns0:DESCRIPTION>
              <xsl:value-of select=""DocRequest/FileDescription/text()"" />
            </ns0:DESCRIPTION>
            <ns0:DOCTYPE>
              <xsl:value-of select=""$var:v5"" />
            </ns0:DOCTYPE>
            <ns0:DOCUMENTDATA>
              <xsl:value-of select=""DocRequest/FileContent/text()"" />
            </ns0:DOCUMENTDATA>
            <ns0:URLNAME>
              <xsl:value-of select=""$var:v6"" />
            </ns0:URLNAME>
            <ns0:URLTYPE>
              <xsl:value-of select=""$var:v7"" />
            </ns0:URLTYPE>
            <xsl:value-of select=""DocRequest/text()"" />
          </ns0:DOCLINKS>
        </ns0:SR>
      </ns0:MTFMSERVICEREQSet>
    </ns0:UpdateMTFMSERVICEREQ>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.AddDocument+AddDocumentRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.AddDocument.AddDocumentRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM.MiAMI.Services.GeneratedItems.MTFMSERVICEREQ.MTFMSERVICEREQ_www_ibm_com_maximo+UpdateMTFMSERVICEREQ";
        
        private const global::MTFM.MiAMI.Services.GeneratedItems.MTFMSERVICEREQ.MTFMSERVICEREQ_www_ibm_com_maximo.UpdateMTFMSERVICEREQ _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.AddDocument+AddDocumentRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MTFM.MiAMI.Services.GeneratedItems.MTFMSERVICEREQ.MTFMSERVICEREQ_www_ibm_com_maximo+UpdateMTFMSERVICEREQ";
                return _TrgSchemas;
            }
        }
    }
}
