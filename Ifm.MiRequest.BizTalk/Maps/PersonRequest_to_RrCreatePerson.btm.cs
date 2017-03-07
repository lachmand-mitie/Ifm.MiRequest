namespace Ifm.MiRequest.BizTalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest+PersonRequest", typeof(global::Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest.PersonRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM._1TEAM.Services.GeneratedItems.RRMIPERSON.RRMIPERSON_www_ibm_com_maximo+CreateRRMIPERSON", typeof(global::MTFM._1TEAM.Services.GeneratedItems.RRMIPERSON.RRMIPERSON_www_ibm_com_maximo.CreateRRMIPERSON))]
    public sealed class PersonRequest_to_RrCreatePerson : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://IFM.MiRequest.NewPersonRequest"" xmlns:ns0=""http://www.ibm.com/maximo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PersonRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:PersonRequest"">
    <ns0:CreateRRMIPERSON>
      <ns0:RRMIPERSONSet>
        <ns0:PERSON>
          <ns0:FIRSTNAME>
            <xsl:value-of select=""FirstName/text()"" />
          </ns0:FIRSTNAME>
          <ns0:LASTNAME>
            <xsl:value-of select=""Surname/text()"" />
          </ns0:LASTNAME>
          <ns0:PERSONID>
            <xsl:value-of select=""PersonIdentifer/text()"" />
          </ns0:PERSONID>
          <ns0:PRIMARYEMAIL>
            <xsl:value-of select=""Email/text()"" />
          </ns0:PRIMARYEMAIL>
          <ns0:PRIMARYPHONE>
            <xsl:value-of select=""Phone/text()"" />
          </ns0:PRIMARYPHONE>
        </ns0:PERSON>
      </ns0:RRMIPERSONSet>
    </ns0:CreateRRMIPERSON>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest+PersonRequest";
        
        private const global::Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest.PersonRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM._1TEAM.Services.GeneratedItems.RRMIPERSON.RRMIPERSON_www_ibm_com_maximo+CreateRRMIPERSON";
        
        private const global::MTFM._1TEAM.Services.GeneratedItems.RRMIPERSON.RRMIPERSON_www_ibm_com_maximo.CreateRRMIPERSON _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Ifm.MiRequest.BizTalk.Schemas.NewPersonRequest+PersonRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MTFM._1TEAM.Services.GeneratedItems.RRMIPERSON.RRMIPERSON_www_ibm_com_maximo+CreateRRMIPERSON";
                return _TrgSchemas;
            }
        }
    }
}
