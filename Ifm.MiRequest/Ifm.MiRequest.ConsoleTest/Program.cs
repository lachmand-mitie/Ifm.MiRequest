using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Ifm.MiRequest.Helper;

namespace Ifm.MiRequest.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //string siteid = DataAccess.GetLocationSiteId("DLT6-0003[IFM]");
                //string GetLocationList = DataAccess.GetLocationList("DELOITTES", "MIAMI", "athe");

                //Int32 test = DataAccess.SetPortalProviderRef("MC-3", "FAKE1234");


                //BOOK IT \ CATERING

                MiRequestOneTeamClient MiRequestOneTeamClient = new MiRequestOneTeamClient();

                string portalCategory = @"BOOK IT \ CATERING";
                string classstructureid = MiRequestOneTeamClient.OneTeamClassificationMapping(portalCategory);

                //string siteid = DataAccess.GetLocationSiteId("DLT1-0014");

                //string txt = string.Empty;
                //txt = "!`'£$%^&*(<hello>>>";
                //txt = "This is WORK LOG #1<br /><!-- RICH TEXT -->";
                //string escaped = System.Security.SecurityElement.Escape(txt);
                //string decoded = System.Net.WebUtility.HtmlDecode(txt);
                //string encoded = System.Net.WebUtility.HtmlEncode(txt);
                //string regexed = MFM.Colleague.Helper.PortalClient.RemoveScriptFromPlainText(txt);

            }
            catch (Exception e)
            {

            }
            
        }
    }
}
