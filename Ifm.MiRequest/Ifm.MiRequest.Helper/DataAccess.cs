using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net;

namespace Ifm.MiRequest.Helper
{
    [Serializable]
    public class PortalClient
    {
        public static Boolean PushStatusUpdate(XmlDocument xml)
        {

            return true;
        }

        /// <summary>
        /// Return true to persist logs as entries in the portal database
        /// Return false to skip.  Portal to use real-time lookup of portal notes
        /// </summary>
        /// <returns></returns>
        public static Boolean PersistPortalLogsInPortal()
        {
            return false;
        }

        public static String XmlEscapePlainTxt(string txt)
        {
            txt = System.Security.SecurityElement.Escape(txt);
            return txt;
        }

        public static String RemoveScriptFromPlainText(string txt)
        {
            const string pattern = "<[^>]*>";
            return Regex.Replace(txt, pattern, string.Empty);
        }

        public static String RemoveCommonRichText(string txt)
        {
            return txt.Replace("EN-GB", "").Replace("X-NONE", "").Replace("MicrosoftInternetExplorer4", "");
        }

        public static String RemoveScriptFromConcatText(string txt)
        {
            const string pattern = "<[^>]*>";
            txt = Regex.Replace(System.Net.WebUtility.HtmlDecode(txt), pattern, string.Empty);
            txt = txt.Replace("<br>", Environment.NewLine)
                                  .Replace("<div>", Environment.NewLine)
                                  .Replace("<p>", Environment.NewLine)
                                  .Replace("<span>", Environment.NewLine)
                                  .Replace("<tr>", Environment.NewLine)
                                  .Replace("]]>", "")
                                  .Replace("<![CDATA[", "")
                                  .Replace("&lt;", "")
                                  .Replace("&gt;", "")
                                  .Replace("EN-GB", "")
                                  .Replace("X-NONE", "")
                                  .Replace("MicrosoftInternetExplorer4", "");

            return txt;
        }

        public static Boolean IsViewable(Int16 flag)
        {
            if (flag == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static String FilenameFriendly(string input)
        {
            return input;
        }
    }
    
    [Serializable]
    public class DataAccess
    {

        public static Int32 SetPortalProviderRef(string portalRef, string providerRef)
        {
            Boolean SkipAwsSQl = true;

            if (SkipAwsSQl)
            {
                return 1;
            }
            else
            {
                String Conn = string.Empty;
                String Query = string.Empty;
                SqlEnvironmentSet obj = new SqlEnvironmentSet();
                obj = GetPortalSqlEnvironmentObj(GetEnvironment());
                Conn = GetAwsConnString(obj.Server, obj.Database, obj.UserId, obj.Password, "BizTalkPortalClient");
                Query = String.Format("update [dbo].[JobRequests] set [ExternalRef] = '{1}' where [RequestRef] = '{0}'", portalRef, providerRef);
                Int32 rowsAffected = 0;
                try
                {
                    using (SqlConnection conn = new SqlConnection(Conn))
                    {
                        conn.Open();
                        using (SqlCommand command = new SqlCommand(Query, conn))
                        {
                            rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("Ifm.MiRequest.Portal", "Set portal ref in helper (SQLExeception): " + portalRef + "/" + providerRef + "\r\nConn:" + Conn + "\r\n" + ex.Message + "\r\n" + ex.StackTrace, EventLogEntryType.Error);
                    rowsAffected = -2;
                }
                catch (Exception ex2)
                {
                    EventLog.WriteEntry("Ifm.MiRequest.Portal", "Set portal ref in helper: " + portalRef + "/" + providerRef + "\r\n" + ex2.Message + "\r\n" + ex2.StackTrace, EventLogEntryType.Error);
                    rowsAffected = -1;
                }

                return rowsAffected;
            }
           
        }

        public String GetRrLocationGlcode(string location)
        {
            String Conn = string.Empty;
            String Query = string.Empty;
            DataTable locations = new DataTable();
            Int32 NumRows = 0;
            String ResultCode = "-1";
            SqlEnvironmentSet source = new SqlEnvironmentSet();
            source = GetOdsSqlEnvironmentObj(GetEnvironment());
            Conn = GetConnString(source.Server, source.Database, "BizTalPortalClient");
            Query = string.Format(@"
select top(1) [glaccount]
from [RR75].[locations] (nolock)
where disabled = 0
and [LOCATION] = '{0}'", location);
            locations = GetDataTableFromSql(Query, Conn);
            LocationResponse LocationResponse = new LocationResponse();
            Result ResultRecord = new Result();
            string glaccount = string.Empty;
            try
            {
                DataRow row = locations.Rows[0];
                glaccount = (String)row["glaccount"];

            }
            catch (Exception ex)
            {
                glaccount = "";
            }


            return glaccount;
        }

        public static String GetLocationSiteId(string location)
        {
            String Conn = string.Empty;
            String Query = string.Empty;
            DataTable locations = new DataTable();
            Int32 NumRows = 0;
            String ResultCode = "-1";
            SqlEnvironmentSet source = new SqlEnvironmentSet();
            source = GetOdsSqlEnvironmentObj(GetEnvironment());
            Conn = GetConnString(source.Server, source.Database, "BizTalPortalClient");
            Query = string.Format(@"
select top(1) SiteId
from [MTFM].[locations] (nolock)
where disabled = 0
and [LOCATION] = '{0}'
and Type = 'SERVICE'
and Status not in ('Decommisioned','decommissioned','DECOMMISSIONED')", location);

            locations = GetDataTableFromSql(Query, Conn);
            LocationResponse LocationResponse = new LocationResponse();
            Result ResultRecord = new Result();
            string siteid = string.Empty;
            try
            {
            DataRow row = locations.Rows[0];
            siteid = (String)row["SiteId"];
            
            }
            catch (Exception ex)
            {
                siteid = "NOMATCH";

                //Siteid = "DELT"; //hardcode temp fix
            }


            return siteid;

        }
        
        public static String GetLocationList(string contract, string provider,string match)
        {
            EventLog.WriteEntry("Ifm.MiRequest.Portal", "in helper: " + contract + "/" + provider + "/" + match, EventLogEntryType.Information);
            XmlDocument resp = new XmlDocument();
            String Conn = string.Empty;
            String Query = string.Empty;
            DataTable locations = new DataTable();
            Int32 NumRows = 0;
            String ResultCode = "-1";


            if (provider.ToUpper() == "MIAMI")
            {
                SqlEnvironmentSet source = new SqlEnvironmentSet();
                source = GetOdsSqlEnvironmentObj(GetEnvironment());
                Conn = GetConnString(source.Server, source.Database, "BizTalPortalClient");
                Query = string.Format(@"
select Description 
,  Location
, SiteId
, OrgId
, isnull(SERVICEADDRESSCODE,'') as 'SERVICEADDRESSCODE' 

from [MTFM].[locations] (nolock)
where disabled = 0
and [LOCATTRIBUTE6] like '%{0}%'
and Description LIKE '%{1}%'
and Type = 'SERVICE'
and Status not in ('Decommisioned','decommissioned','DECOMMISSIONED')", contract, match);
                
                locations = GetDataTableFromSql(Query, Conn);
                LocationResponse LocationResponse = new LocationResponse();
                Result ResultRecord = new Result();
                
                if (locations.Rows.Count == 0)
                {
                    //No results
                    EventLog.WriteEntry("Ifm.MiRequest.Portal", "no resuls", EventLogEntryType.Information);
            
                    ResultRecord.Message = "No locations found";
                    ResultRecord.ResultCode = "-1";
                    ResultRecord.NumRecords = 0;
                }
                else
                {
                    
                    NumRows = locations.Rows.Count;
                    ResultCode = "0";

                    ResultRecord.Message = "OK";
                    ResultRecord.ResultCode = ResultCode;
                    ResultRecord.NumRecords = NumRows;



                    LocationResponse.Result = ResultRecord;
                    //List<string> LocationList = new List<String>();
                    List<ResultLocation> lrl = new List<ResultLocation>();

                    foreach (DataRow row in locations.Rows)
                    {
                        ResultLocation rl = new ResultLocation();
                        rl.Description = (String)row["Description"];
                        rl.Location = (String)row["Location"];
                        rl.SiteId = (String)row["SiteId"];
                        rl.OrgId = (String)row["OrgId"];
                        rl.Address = (String)row["SERVICEADDRESSCODE"];

                        lrl.Add(rl);

                        //LocationList.Add((String)row["location"]);
                    }
                    ResultRecord.Locations = lrl.ToArray();
                }

                LocationResponse.Result = ResultRecord;
                EventLog.WriteEntry("Ifm.MiRequest.Portal", Query, EventLogEntryType.Information);
                EventLog.WriteEntry("Ifm.MiRequest.Portal", "Locs: " + NumRows.ToString(), EventLogEntryType.Information);

                using (XmlWriter writer = resp.CreateNavigator().AppendChild())
                {
                    new XmlSerializer(LocationResponse.GetType()).Serialize(writer, LocationResponse);
                }


            }

            //EventLog.WriteEntry("Ifm.MiRequest.Portal", resp.OuterXml.Substring(0,50), EventLogEntryType.Information);
            return resp.OuterXml;
        }
  
        public static string GetConnString(string Server, string Database, String ApplicationName)
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.DataSource = Server;
            cs.InitialCatalog = Database;
            cs.IntegratedSecurity = true;
            cs.Pooling = false;
            cs.MultipleActiveResultSets = true;
            cs.ConnectTimeout = 10;
            cs.ApplicationName = ApplicationName;
            return cs.ToString();
        }

        public static string GetAwsConnString(string Server, string Database, string userid, string password, String ApplicationName)
        {
            //Server=tcp:micolleague-dev.ckgtgqhfesox.eu-west-1.rds.amazonaws.com,1433;Database=MGP_BI_MiColleague;User ID=MiClgDevRDS;Password=hq7Bm6pKcmD0pQENhuTj;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;TrustServerCertificate=True
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.DataSource = Server;
            cs.InitialCatalog = Database;
            cs.IntegratedSecurity = false;
            cs.UserID = userid;
            cs.Password = password;
            cs.TrustServerCertificate = true;
            cs.Encrypt = true;
            cs.Pooling = false;
            cs.MultipleActiveResultSets = true;
            cs.ConnectTimeout = 30;
            cs.ApplicationName = ApplicationName;
            return cs.ToString();
        }

        public static DataTable GetDataTableFromSql(string thisCommandText, string thisConnectionString)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(thisConnectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(thisCommandText, conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                        reader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                EventLog.WriteEntry("Ifm.MiRequest.Portal", "Getlocations in helper (SQLExeception): " + thisCommandText + "\r\n" + ex.Message + "\r\n" + ex.StackTrace, EventLogEntryType.Error);
                
            }

            return dt;
        }

        /// <summary>
        /// Get enviornment (dev, uat, prod)
        /// </summary>
        /// <returns>Environment in string</returns>
        public static string GetEnvironment()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            string environment = string.Empty;

            switch (host)
            {
                case "miti-msl-vm-41":
                case "MITI-W-INT-0107":
                case "mitie-com-106":
                case "mitie-com-105":
                    environment = "production";
                    break;
                case "miti-msl-vm-52":
                case "miti-msl-vm-40":
                    environment = "uat";
                    break;
                case "csvmg08-sv":
                case "csvmg07-sv":
                case "d34fvbt1":
                    environment = "dev";
                    break;
            }

            return environment;
        }

        private static SqlEnvironmentSet GetPortalSqlEnvironmentObj(string Env)
        {
            SqlEnvironmentSet obj = new SqlEnvironmentSet();
            switch(Env.ToLower())
            {
                case "dev":
                    obj.Server = "micolleague-dev.ckgtgqhfesox.eu-west-1.rds.amazonaws.com";
                    obj.Database = "MGP_BI_MiColleague";
                    obj.UserId = "MiClgDevRDS";
                    obj.Password = "hq7Bm6pKcmD0pQENhuTj";
                    return obj;
                case "uat":
                    // Server=tcp:micolleague-qa.ckgtgqhfesox.eu-west-1.rds.amazonaws.com,1433;Database=MGP_BI_MiColleague;User ID=MiClgQARDS;Password=QDEkYH9bDbDOXCUmYaF3;
                    obj.Server = "micolleague-qa.ckgtgqhfesox.eu-west-1.rds.amazonaws.com";
                    obj.Database = "MGP_BI_MiColleague";
                    obj.UserId = "MiClgQARDS";
                    obj.Password = "QDEkYH9bDbDOXCUmYaF3";
                    return obj;
                case "production":
                    // Server=tcp:miclgprodrds.ckgtgqhfesox.eu-west-1.rds.amazonaws.com,1433;Database=MGP_BI_MiColleague;User ID=MiClgProdRDS;Password=7ZLjV0abzocPXd70uJri;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;TrustServerCertificate=True
                    obj.Server = "miclgprodrds.ckgtgqhfesox.eu-west-1.rds.amazonaws.com";
                    obj.Database = "MGP_BI_MiColleague";
                    obj.UserId = "MiClgProdRDS";
                    obj.Password = "7ZLjV0abzocPXd70uJri";
                    return obj;
                default:
                    obj.Server = "micolleague-dev.ckgtgqhfesox.eu-west-1.rds.amazonaws.com";
                    obj.Database = "MGP_BI_MiColleague";
                    obj.UserId = "MiClgDevRDS";
                    obj.Password = "hq7Bm6pKcmD0pQENhuTj";
                    return obj;
            }
        }

        private static SqlEnvironmentSet GetOdsSqlEnvironmentObj(string Env)
        {
            SqlEnvironmentSet obj = new SqlEnvironmentSet();
            switch (Env.ToLower())
            {
                case "dev":
                    obj.Server = "mitie-vmware-20";
                    obj.Database = "MGP_BI_Operations";
                    return obj;
                case "uat":
                    obj.Server = "mitie-com-19";
                    obj.Database = "MGP_BI_Operations";
                    return obj;
                case "production":
                    obj.Server = @"MITIE-SQL4-02\MITIE_SQL4_02";
                    obj.Database = "MGP_BI_Operations";
                    return obj;
                default:
                    obj.Server = "mitie-vmware-20";
                    obj.Database = "MGP_BI_Operations";
                    return obj;
            }
        }
    
    }

    [Serializable]
    public class SqlEnvironmentSet
    {
        public string Server;
        public string Database;
        public string UserId;
        public string Password;
    }


    [Serializable]
    public class MiRequestOneTeamClient
    {
        public string OneTeanmPriorityMap(string contract, string portalPriority)
        {
            switch (portalPriority.ToLower())
            {
                case "emergency":
                    return "1";
                case "urgent":
                    return "2";
                default:
                    return portalPriority;
            }
        }

        public string Get1TeamAttachmentsUrl(string filename)
        {
            string environment = DataAccess.GetEnvironment();
            string attachmenturl = string.Empty;

            filename = filename.Replace("/", "");

            switch (environment)
            {
                case "production":
                    attachmenturl = string.Format(@"\\{0}\doclinks\attachments\{1}", "172.17.30.13", filename);
                    break;
                case "uat":
                    attachmenturl = string.Format(@"\\{0}\doclinks\attachments\{1}", "172.17.10.10", filename);
                    break;
                case "dev":
                    attachmenturl = string.Format(@"\\{0}\doclinks\attachments\{1}", "172.17.10.10", filename);
                    break;
            }

            return attachmenturl;

        }

        public string Get1TeamAttachmentsWebUrl(string filename)
        {
            string environment = DataAccess.GetEnvironment();
            string attachmenturl = string.Empty;

            filename = filename.Replace("/", "");

            switch (environment)
            {
                case "production":
                    attachmenturl = string.Format(@"\\{0}\doclinks\attachments\{1}", "172.17.30.13", filename);
                    break;
                case "uat":
                    attachmenturl = string.Format(@"\\{0}\doclinks\attachments\{1}", "172.17.10.10", filename);
                    break;
                case "dev":
                    attachmenturl = string.Format(@"\\{0}\doclinks\attachments\{1}", "172.17.10.10", filename);
                    break;
            }

            return attachmenturl;

        }

        public string OneTeamClassificationMapping(string service)
        {
            String classification = "";
            service = service.ToUpper();
            string env = Ifm.MiRequest.Helper.DataAccess.GetEnvironment();
            if (env == "dev" || env == "uat")
            {
                if (service.ToUpper() == "") { return "0"; }

                if (service.ToUpper() == @"GOOD SPOT \ HSE".ToUpper()) { return "1040"; }
                if (service.ToUpper() == @"GOOD SPOT \ ENVIRONMENT".ToUpper()) { return "1041"; }
                if (service.ToUpper() == @"GOOD SPOT \ HOUSEKEEPING".ToUpper()) { return "1042"; }
                if (service.ToUpper() == @"GOOD SPOT \ OTHER".ToUpper()) { return "1043"; }
                if (service.ToUpper() == @"ORDER \ CLEANING SUPPLIES".ToUpper()) { return "1031"; }
                if (service.ToUpper() == @"ORDER \ FURNITURE".ToUpper()) { return "1032"; }
                if (service.ToUpper() == @"ORDER \ OFFICE SUPPLIES".ToUpper()) { return "1033"; }
                if (service.ToUpper() == @"ORDER \ OTHER".ToUpper()) { return "1034"; }
                if (service.ToUpper() == @"CLEANING \ CLEANING".ToUpper()) { return "1015"; }
                if (service.ToUpper() == @"CLEANING \ CONFIDENTIAL WASTE".ToUpper()) { return "1018"; }
                if (service.ToUpper() == @"CLEANING \ LANDSCAPING".ToUpper()) { return "1016"; }
                if (service.ToUpper() == @"CLEANING \ OTHER".ToUpper()) { return "1020"; }
                if (service.ToUpper() == @"CLEANING \ PEST CONTROL".ToUpper()) { return "1017"; }
                if (service.ToUpper() == @"CLEANING \ WASTE".ToUpper()) { return "1019"; }
                if (service.ToUpper() == @"MAINTENANCE \ APPLIANCES / EQUIPMENT".ToUpper()) { return "1044"; }
                if (service.ToUpper() == @"MAINTENANCE\ BUILDING REPAIR".ToUpper()) { return "1008"; }
                if (service.ToUpper() == @"MAINTENANCE \ HEATING / COOLING".ToUpper()) { return "1009"; }
                if (service.ToUpper() == @"MAINTENANCE \ LIFTS".ToUpper()) { return "1010"; }
                if (service.ToUpper() == @"MAINTENANCE \ OTHER".ToUpper()) { return "1012"; }
                if (service.ToUpper() == @"MAINTENANCE \ PLUMBING".ToUpper()) { return "1011"; }
                if (service.ToUpper() == @"MAINTENANCE \ POWER / LIGHTING".ToUpper()) { return "1006"; }
                if (service.ToUpper() == @"BOOK \ CATERING".ToUpper()) { return "1023"; } //1023
                if (service.ToUpper() == @"BOOK \ GRITTING".ToUpper()) { return "1024"; }
                if (service.ToUpper() == @"BOOK \ MOVES".ToUpper()) { return "1025"; }
                if (service.ToUpper() == @"BOOK \ OTHER".ToUpper()) { return "1028"; }
                if (service.ToUpper() == @"BOOK \ ROOMS".ToUpper()) { return "1026"; }
                if (service.ToUpper() == @"BOOK \ SECURITY".ToUpper()) { return "1027"; }

                //if (service.ToUpper() == @"Process Safety".ToUpper()) { return "1003"; }
                //if (service.ToUpper() == @"Mandatory PM".ToUpper()) { return "1004"; }
                //if (service.ToUpper() == @"Statutory PM".ToUpper()) { return "1005"; }
                //if (service.ToUpper() == @"FIX IT".ToUpper()) { return "1006"; }
                //if (service.ToUpper() == @"BOOK IT".ToUpper()) { return "1007"; }
                //if (service.ToUpper() == @"BOOK IT \ CATERING".ToUpper()) { return "1008"; }
                //if (service.ToUpper() == @"BOOK IT \ GRITTING".ToUpper()) { return "1009"; }
                //if (service.ToUpper() == @"BOOK IT \ MOVES".ToUpper()) { return "1010"; }
                //if (service.ToUpper() == @"BOOK IT \ ROOMS".ToUpper()) { return "1011"; }
                //if (service.ToUpper() == @"BOOK IT \ SECURITY".ToUpper()) { return "1012"; }
                //if (service.ToUpper() == @"BOOK IT \ OTHER".ToUpper()) { return "1013"; }
                //if (service.ToUpper() == @"TIDY IT".ToUpper()) { return "1014"; }
                //if (service.ToUpper() == @"TIDY IT \ CLEANING".ToUpper()) { return "1015"; }
                //if (service.ToUpper() == @"TIDY IT \ LANDSCAPE".ToUpper()) { return "1016"; }
                //if (service.ToUpper() == @"ORDER IT".ToUpper()) { return "1017"; }
                //if (service.ToUpper() == @"HOSPITALITY".ToUpper()) { return "1018"; }
                //if (service.ToUpper() == @"Good Spot".ToUpper()) { return "1019"; }
                //if (service.ToUpper() == @"Thank you".ToUpper()) { return "1020"; }
                //if (service.ToUpper() == @"Brillant Customer Service".ToUpper()) { return "1021"; }
                //if (service.ToUpper() == @"Outstanding Act".ToUpper()) { return "1022"; }
                //if (service.ToUpper() == @"Attention to Health and Safety".ToUpper()) { return "1023"; }
                //if (service.ToUpper() == @"Power / Lighting".ToUpper()) { return "1024"; }
                //if (service.ToUpper() == @"Appliances / Equipment".ToUpper()) { return "1025"; }
                //if (service.ToUpper() == @"Pest Control".ToUpper()) { return "1026"; }
                //if (service.ToUpper() == @"Confidential Waste".ToUpper()) { return "1027"; }
                //if (service.ToUpper() == @"Waste".ToUpper()) { return "1028"; }
                //if (service.ToUpper() == @"Other".ToUpper()) { return "1029"; }
                //if (service.ToUpper() == @"Cleaning Supplies".ToUpper()) { return "1030"; }
                //if (service.ToUpper() == @"Furniture".ToUpper()) { return "1031"; }
                //if (service.ToUpper() == @"Office Supplies".ToUpper()) { return "1032"; }
                //if (service.ToUpper() == @"Other".ToUpper()) { return "1033"; }
                //if (service.ToUpper() == @"Corporate".ToUpper()) { return "1034"; }
                //if (service.ToUpper() == @"VIP".ToUpper()) { return "1035"; }
                //if (service.ToUpper() == @"Building Repairs".ToUpper()) { return "1036"; }
                //if (service.ToUpper() == @"Heating / Cooling".ToUpper()) { return "1037"; }
                //if (service.ToUpper() == @"Lifts".ToUpper()) { return "1038"; }
                //if (service.ToUpper() == @"Plumbing".ToUpper()) { return "1039"; }
                //if (service.ToUpper() == @"Other".ToUpper()) { return "1040"; }
                //if (service.ToUpper() == @"Health & Safety".ToUpper()) { return "1041"; }
                //if (service.ToUpper() == @"Environmental".ToUpper()) { return "1042"; }
                //if (service.ToUpper() == @"Housekeeping".ToUpper()) { return "1043"; }
                //if (service.ToUpper() == @"Other".ToUpper()) { return "1044"; }
                //if (service.ToUpper() == @"Good spots \ HSE".ToUpper()) { return "1044"; }
                //if (service.ToUpper() == @"Good spots \ Environment".ToUpper()) { return "1044"; }
                //if (service.ToUpper() == @"Good spots \ Housekeeping".ToUpper()) { return "1044"; }
                //if (service.ToUpper() == @"Good spots \ Other".ToUpper()) { return "1044"; }

            }

            if (env == "production")
            {
                if (service.ToUpper() == @"GOOD SPOT \ HSE".ToUpper()) { return "1040"; }
                if (service.ToUpper() == @"GOOD SPOT \ ENVIRONMENT".ToUpper()) { return "1041"; }
                if (service.ToUpper() == @"GOOD SPOT \ HOUSEKEEPING".ToUpper()) { return "1042"; }
                if (service.ToUpper() == @"GOOD SPOT \ OTHER".ToUpper()) { return "1043"; }
                if (service.ToUpper() == @"ORDER \ CLEANING SUPPLIES".ToUpper()) { return "1031"; }
                if (service.ToUpper() == @"ORDER \ FURNITURE".ToUpper()) { return "1032"; }
                if (service.ToUpper() == @"ORDER \ OFFICE SUPPLIES".ToUpper()) { return "1033"; }
                if (service.ToUpper() == @"ORDER \ OTHER".ToUpper()) { return "1034"; }
                if (service.ToUpper() == @"CLEANING \ CLEANING".ToUpper()) { return "1015"; }
                if (service.ToUpper() == @"CLEANING \ CONFIDENTIAL WASTE".ToUpper()) { return "1018"; }
                if (service.ToUpper() == @"CLEANING \ LANDSCAPING".ToUpper()) { return "1016"; }
                if (service.ToUpper() == @"CLEANING \ OTHER".ToUpper()) { return "1020"; }
                if (service.ToUpper() == @"CLEANING \ PEST CONTROL".ToUpper()) { return "1017"; }
                if (service.ToUpper() == @"CLEANING \ WASTE".ToUpper()) { return "1019"; }
                if (service.ToUpper() == @"MAINTENANCE \ APPLIANCES / EQUIPMENT".ToUpper()) { return "1044"; }
                if (service.ToUpper() == @"MAINTENANCE\ BUILDING REPAIR".ToUpper()) { return "1008"; }
                if (service.ToUpper() == @"MAINTENANCE \ HEATING / COOLING".ToUpper()) { return "1009"; }
                if (service.ToUpper() == @"MAINTENANCE \ LIFTS".ToUpper()) { return "1010"; }
                if (service.ToUpper() == @"MAINTENANCE \ OTHER".ToUpper()) { return "1012"; }
                if (service.ToUpper() == @"MAINTENANCE \ PLUMBING".ToUpper()) { return "1011"; }
                if (service.ToUpper() == @"MAINTENANCE \ POWER / LIGHTING".ToUpper()) { return "1006"; }
                if (service.ToUpper() == @"BOOK \ CATERING".ToUpper()) { return "1023"; } //1023
                if (service.ToUpper() == @"BOOK \ GRITTING".ToUpper()) { return "1024"; }
                if (service.ToUpper() == @"BOOK \ MOVES".ToUpper()) { return "1025"; }
                if (service.ToUpper() == @"BOOK \ OTHER".ToUpper()) { return "1028"; }
                if (service.ToUpper() == @"BOOK \ ROOMS".ToUpper()) { return "1026"; }
                if (service.ToUpper() == @"BOOK \ SECURITY".ToUpper()) { return "1027"; }

                //Pre-edison rebrand
                //if (service.ToUpper() == @"GOOD SPOT \ HSE".ToUpper()) { return "1040"; }
                //if (service.ToUpper() == @"GOOD SPOT \ ENVIRONMENT".ToUpper()) { return "1041"; }
                //if (service.ToUpper() == @"GOOD SPOT \ HOUSEKEEPING".ToUpper()) { return "1042"; }
                //if (service.ToUpper() == @"GOOD SPOT \ OTHER".ToUpper()) { return "1043"; }
                //if (service.ToUpper() == @"ORDER IT \ CLEANING SUPPLIES".ToUpper()) { return "1031"; }
                //if (service.ToUpper() == @"ORDER IT \ FURNITURE".ToUpper()) { return "1032"; }
                //if (service.ToUpper() == @"ORDER IT \ OFFICE SUPPLIES".ToUpper()) { return "1033"; }
                //if (service.ToUpper() == @"ORDER IT \ OTHER".ToUpper()) { return "1034"; }
                //if (service.ToUpper() == @"TIDY IT \ CLEANING".ToUpper()) { return "1015"; }
                //if (service.ToUpper() == @"TIDY IT \ CONFIDENTIAL WASTE".ToUpper()) { return "1018"; }
                //if (service.ToUpper() == @"TIDY IT \ LANDSCAPING".ToUpper()) { return "1016"; }
                //if (service.ToUpper() == @"TIDY IT \ OTHER".ToUpper()) { return "1020"; }
                //if (service.ToUpper() == @"TIDY IT \ PEST CONTROL".ToUpper()) { return "1017"; }
                //if (service.ToUpper() == @"TIDY IT \ WASTE".ToUpper()) { return "1019"; }
                //if (service.ToUpper() == @"FIX IT \ APPLIANCES / EQUIPMENT".ToUpper()) { return "1044"; }
                //if (service.ToUpper() == @"FIX IT \ BUILDING REPAIR".ToUpper()) { return "1008"; }
                //if (service.ToUpper() == @"FIX IT \ HEATING / COOLING".ToUpper()) { return "1009"; }
                //if (service.ToUpper() == @"FIX IT \ LIFTS".ToUpper()) { return "1010"; }
                //if (service.ToUpper() == @"FIX IT \ OTHER".ToUpper()) { return "1012"; }
                //if (service.ToUpper() == @"FIX IT \ PLUMBING".ToUpper()) { return "1011"; }
                //if (service.ToUpper() == @"FIX IT \ POWER / LIGHTING".ToUpper()) { return "1006"; }
                //if (service.ToUpper() == @"BOOK IT \ CATERING".ToUpper()) { return ""; } //1023
                //if (service.ToUpper() == @"BOOK IT \ GRITTING".ToUpper()) { return "1024"; }
                //if (service.ToUpper() == @"BOOK IT \ MOVES".ToUpper()) { return "1025"; }
                //if (service.ToUpper() == @"BOOK IT \ OTHER".ToUpper()) { return "1028"; }
                //if (service.ToUpper() == @"BOOK IT \ ROOMS".ToUpper()) { return "1026"; }
                //if (service.ToUpper() == @"BOOK IT \ SECURITY".ToUpper()) { return "1027"; }
                
                #region
                //Original go live set
                //if (service.ToUpper() == @"BOOK IT") { return "1022"; }
                //if (service == @"BOOK IT \ CATERING") { return "1023"; }
                //if (service == @"BOOK IT \ GRITTING") { return "1024"; }
                //if (service == @"BOOK IT \ MOVES") { return "1025"; }
                //if (service == @"BOOK IT \ OTHER") { return "1028"; }
                //if (service == @"BOOK IT \ ROOMS") { return "1026"; }
                //if (service == @"BOOK IT \ SECURITY") { return "1027"; }
                //if (service == @"Building Repairs") { return "1008"; }
                //if (service == @"Cleaning Supplies") { return "1031"; }
                //if (service == @"Confidential Waste") { return "1018"; }
                //if (service == @"Corporate") { return "1036"; }
                //if (service == @"Environmental") { return "1041"; }
                //if (service == @"Equipment") { return "1044"; }
                //if (service == @"FIX IT") { return "1005"; }
                //if (service == @"Furniture") { return "1032"; }
                //if (service == @"Good Spot") { return "1039"; }
                //if (service == @"Health & Safety") { return "1040"; }
                //if (service == @"Heating / Cooling") { return "1009"; }
                //if (service == @"HOSPITALITY") { return "1035"; }
                //if (service == @"Housekeeping") { return "1042"; }
                //if (service == @"Lifts") { return "1010"; }
                //if (service == @"Office Supplies") { return "1033"; }
                //if (service == @"ORDER IT") { return "1030"; }
                //if (service == @"Other") { return "1043"; }
                //if (service == @"Other") { return "1034"; }
                //if (service == @"Other") { return "1020"; }
                //if (service == @"Other") { return "1012"; }
                //if (service == @"Pest Control") { return "1017"; }
                //if (service == @"Plumbing") { return "1011"; }
                //if (service == @"Power / Lighting") { return "1006"; }
                //if (service == @"Process Safety") { return "1003"; }
                //if (service == @"TIDY IT") { return "1014"; }
                //if (service == @"TIDY IT \ CLEANING") { return "1015"; }
                //if (service == @"TIDY IT \ LANDSCAPE") { return "1016"; }
                //if (service == @"VIP") { return "1037"; }
                //if (service == @"Waste") { return "1019"; }
                #endregion

            }
            return classification;
        }

        public string OneTeamStatusMapping(string status)
        {
            return status;
        }
    }

    [Serializable]
    public class MiRequestMaximoClient
    {
        public string MxoPriorityMap(string contract, string portalPriority)
        {
            //switch (portalPriority)
            //{
                //case "6":
                //    return "6";
                //default:
                //    return portalPriority;
            //}

            //Robert Thompson requested default mapping of no value
            return "";
        }

        public string MxoCommodityMap(string param1, string param2)
        {
            return "GENERALME";
        }

        public string GetWoQueryWhere(string wonum)
        {
            return string.Format("WONUM='{0}' AND WOCLASS='WORKORDER'", wonum);
        }

        public string GetWoListQueryWhere(string onbehalfof)
        {
            return string.Format("ONBEHALFOF='{0}' AND WOCLASS='WORKORDER'", onbehalfof);
        }
        
        public static MiRequestOrderResponse SubmitNewWorkorder(XmlDocument doc)
        {
            //Namespace:http://MFM.Colleague.Portal.TaskLoader
            
            String xpathBase = "/*[local-name()='TaskLoadRequest' and namespace-uri()='http://MFM.Colleague.Portal.TaskLoader']/*[local-name()='#REPLACE_ME#' and namespace-uri()='']";
            String placeholder = "#REPLACE_ME#";
            
            MiRequestOrderResponse result = new MiRequestOrderResponse();
            result.ProviderRef = @"N\A";
            result.Message = "Submitted";
            result.ResultCode = 0;

            return result;
        }

        public static string GetStatusText(string status, string actstart, string actfinish, string reason1)
        {
            string result = string.Empty;

            if (status == "WAPPR")
            {
                result = "The workorder is waiting approval";
            }

            if (status == "APPR")
            {
                result = "The workorder is approved";
            }

            if (status == "INPRG")
            {
                result = "The workorder is in progress, work started " + actstart;
            }

            if (status == "WMATL")
            {
                result = "The workorder is awaiting materials";
            }

            if (status == "SUSPEND")
            {
                result = "The workorder is suspended";
            }

            if (status == "PRECOMP")
            {
                result = "The workorder is being verified for completion, work complete " + actfinish;
            }

            if (status == "COMP")
            {
                result = "The workorder is completed, work complete " + actfinish;            
            }

            if (status == "REJECT")
            {
                result = "The workorder was rejected";
            }

            if (status == "CAN")
            {
                result = "The workorder was cancelled";
            }
            
            return result;
        }
    }

    [Serializable]
    public class MiRequestOrderResponse
    {
        public Int32 ResultCode;
        public string Message;
        public string ProviderRef;
    }

    public class EmailHelper
    {
        public static string BuildEmailMessage(string Body, string AttachmentName, XmlDocument AttachmentXml, string EmailAddress)
        {
            string EmailXml = string.Empty;

            string ApplicationName = "IFM.MiColleague.Portal";
            string Subject = "Portal request error (" + GetEnvironment() + ")";

            string CreatedTS = DateTime.Now.ToString("o");
            string Retry = "5";
            string BodyType = "Plain";
            string AttachmentCount = "1";
            string AttachmentContent = GetAttachmentBase64(AttachmentXml);

            EmailXml = string.Format("<ns0:MSSNotifyEmail xmlns:ns0='http://MSS.Notification.Service.NotifyEmail/v1'><ApplicationName>{0}</ApplicationName><CreatedTs>{1}</CreatedTs>  <Retry>{2}</Retry><EmailMetaData><To>{3}</To><Subject>{4}</Subject></EmailMetaData><EmailContentData><BodyType>{5}</BodyType><BodyNonRecurring><P1>{6}</P1></BodyNonRecurring></EmailContentData><Attachments><Count>{7}</Count><Attachment><Base64String>{8}</Base64String><AttachmentName>{9}</AttachmentName></Attachment></Attachments><ErrorHandle><SuspendTs>{1}</SuspendTs><EmailDidError>0</EmailDidError></ErrorHandle></ns0:MSSNotifyEmail>", ApplicationName, CreatedTS, Retry, EmailAddress, Subject, BodyType, System.Security.SecurityElement.Escape(Body), AttachmentCount, AttachmentContent, AttachmentName);

            return EmailXml;
        }

        public static string BuildAdhocEmailMessage(string Body, string AttachmentName, XmlDocument AttachmentXml, string EmailAddress)
        {
            string EmailXml = string.Empty;

            string ApplicationName = "IFM.MiColleague.Portal";
            string Subject = "ADHOC Workflow Error - " + AttachmentName.Replace(".xml","") + " (" + GetEnvironment() + ")";

            string CreatedTS = DateTime.Now.ToString("o");
            string Retry = "5";
            string BodyType = "Plain";
            string AttachmentCount = "1";
            string AttachmentContent = GetAttachmentBase64(AttachmentXml);

            EmailXml = string.Format("<ns0:MSSNotifyEmail xmlns:ns0='http://MSS.Notification.Service.NotifyEmail/v1'><ApplicationName>{0}</ApplicationName><CreatedTs>{1}</CreatedTs>  <Retry>{2}</Retry><EmailMetaData><To>{3}</To><Subject>{4}</Subject></EmailMetaData><EmailContentData><BodyType>{5}</BodyType><BodyNonRecurring><P1>{6}</P1></BodyNonRecurring></EmailContentData><Attachments><Count>{7}</Count><Attachment><Base64String>{8}</Base64String><AttachmentName>{9}</AttachmentName></Attachment></Attachments><ErrorHandle><SuspendTs>{1}</SuspendTs><EmailDidError>0</EmailDidError></ErrorHandle></ns0:MSSNotifyEmail>", ApplicationName, CreatedTS, Retry, EmailAddress, Subject, BodyType, System.Security.SecurityElement.Escape(Body), AttachmentCount, AttachmentContent, AttachmentName);

            return EmailXml;
        }

        public static string GetEnvironment()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            string environment = string.Empty;

            switch (host)
            {
                case "miti-msl-vm-41":
                case "MITI-W-INT-0107":
                case "mitie-com-106":
                case "mitie-com-105":
                    environment = "production";
                    break;
                case "miti-msl-vm-52":
                case "miti-msl-vm-40":
                    environment = "uat";
                    break;
                case "csvmg08-sv":
                case "csvmg07-sv":
                    environment = "dev";
                    break;
            }

            return environment;
        }

        public static string GetToEmail() //TODO: Update list for UAT, PROD
        {
            string environment = GetEnvironment();

            switch (environment)
            {
                case "production":
                    return "Andrew.Melvin@mitie.com;Tony.Arrighi@mitie.com";
                case "uat":
                    return "Andrew.Melvin@mitie.com;Tony.Arrighi@mitie.com";
                case "dev":
                    return "Andrew.Melvin@mitie.com;Tony.Arrighi@mitie.com";
                default:
                    return "Andrew.Melvin@mitie.com;Tony.Arrighi@mitie.com";
            }
        }

        public static string GetAdhocToEmail() //TODO: Update list for UAT, PROD
        {
            string environment = GetEnvironment();

            switch (environment)
            {
                case "production":
                    return "1team.apps@mitie.com";
                case "uat":
                    return "Andrew.Melvin@mitie.com;Tony.Arrighi@mitie.com";
                case "dev":
                    return "Andrew.Melvin@mitie.com;Tony.Arrighi@mitie.com";
                default:
                    return "Andrew.Melvin@mitie.com;Tony.Arrighi@mitie.com";
            }
        }

        /// <summary>
        /// Get Base64String from XmlDocument
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public static string GetAttachmentBase64(XmlDocument doc)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                doc.Save(stream);
                stream.Flush();
                stream.Position = 0;

                byte[] bytes = stream.ToArray();

                return Convert.ToBase64String(bytes);
            }
        }
    }

    [Serializable]
    public class AdhocWorkflowClient
    {

        private static string EscapeApostrophe(string value)
        {
            const char backslash = '\\';
            const char apostrophe = '\'';

            var output = new StringBuilder(value.Length);
            foreach (char c in value)
            {
                switch (c)
                {
                    case apostrophe:
                        output.AppendFormat("{0}{1}", backslash, apostrophe);
                        break;
                    default:
                        output.Append(c);
                        break;
                }
            }

            return output.ToString();
        }

        public static bool EnableAdhoc()
        {
            return true;
        }

        public static string CreateWorkflowListItem(string SRNumber, string Name, string Phone, string Email, string Summary, string Details, string WODetailsPersonGroup, string Location, string ChargeDept, string SchemeNo, string Source, string BusinessCase)
        {
            string serviceUrl = GetServiceUrl();
            string response = string.Empty;

            HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(serviceUrl);
            webRequest.Credentials = new System.Net.NetworkCredential("mw-biztalk-rr", "mwbt1", "mitiegrp");
            webRequest.Method = "POST";

            string data = string.Format("'Title':'{0}','ServiceRequest':'{0}','OnBehalfOf':'{1}','Landline':'{2}','Email':'{3}','Summary':'{4}','Details':'{5}','Service':'{6}','Location':'{7}','ChargeDept':'{8}', 'SchemeNo':'{9}', 'Source':'{10}', 'BusinessCaseType':'{11}'",
                EscapeApostrophe(SRNumber), EscapeApostrophe(Name), EscapeApostrophe(Phone), EscapeApostrophe(Email), EscapeApostrophe(Summary), EscapeApostrophe(Details), EscapeApostrophe(WODetailsPersonGroup), EscapeApostrophe(Location), EscapeApostrophe(ChargeDept), EscapeApostrophe(SchemeNo), EscapeApostrophe(Source), EscapeApostrophe(BusinessCase));

            string jsonRequest = "{" + data + "}";

            System.Diagnostics.EventLog.WriteEntry("IFM.MiRequest", "ADHOC Request: " + jsonRequest, System.Diagnostics.EventLogEntryType.Information);

            byte[] byteArray = Encoding.ASCII.GetBytes(jsonRequest);
            webRequest.ContentLength = byteArray.Length;
            webRequest.ContentType = "application/json";
            webRequest.Accept = "application/json";
            using (Stream writer = webRequest.GetRequestStream())
            {
                writer.Write(byteArray, 0, byteArray.Length);
                writer.Flush();
                writer.Close();
            }
            using (HttpWebResponse webresponse = webRequest.GetResponse() as HttpWebResponse)
            {
                using (StreamReader reader = new StreamReader(webresponse.GetResponseStream()))
                {
                    response = reader.ReadToEnd();
                }
            }

            System.Diagnostics.EventLog.WriteEntry("IFM.MiRequest", "ADHOC Response: " + response, System.Diagnostics.EventLogEntryType.Information);

            return response;
        }


        private static string GetServiceUrl()
        {
            string environment = GetEnvironment();
            string serviceUrl = string.Empty;

            switch (environment)
            {
                case "production":
                    serviceUrl = "http://miworld.mitie.com/rr3/workflow/_vti_bin/RRQuotesService.svc/AddAdhocQuote";
                    break;
                case "uat":
                    serviceUrl = "http://miworld-qa.mitie.com/rr3/workflow/_vti_bin/RRQuotesService.svc/AddAdhocQuote";
                    break;
                case "dev":
                    serviceUrl = "http://miworld-qa.mitie.com/rr3/workflow/_vti_bin/RRQuotesService.svc/AddAdhocQuote";
                    break;
            }

            return serviceUrl;
        }

        private static string GetEnvironment()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            string environment = string.Empty;

            switch (host)
            {
                case "miti-msl-vm-41":
                case "MITI-W-INT-0107":
                case "mitie-com-106":
                case "mitie-com-105":
                    environment = "production";
                    break;
                case "miti-msl-vm-52":
                case "miti-msl-vm-40":
                    environment = "uat";
                    break;
                case "csvmg08-sv":
                case "csvmg07-sv":
                    environment = "dev";
                    break;
            }

            return environment;
        }

        public static int GetMaxRetry()
        {
            return 9;
        }

        public static int GetRetryDelayMin()
        {
            return 1;
        }

        public static int GetRetryDelaySecs()
        {
            return 30;
        }
    }
}
