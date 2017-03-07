using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFM.MiRequest.RestComponent.TransmitRest
{
    using System;
    using System.IO;
    using System.Text;
    using System.Drawing;
    using System.Resources;
    using System.Reflection;
    using System.Diagnostics;
    using System.Collections;
    using System.ComponentModel;
    using System.Xml;
    using Microsoft.BizTalk.Message.Interop;
    using Microsoft.BizTalk.Component.Interop;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Messaging;


    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [System.Runtime.InteropServices.Guid("E853A10A-170F-42F2-938B-8BFED4C77B4D")]
    [ComponentCategory(CategoryTypes.CATID_Decoder)]
    public class GetLocationsList : Microsoft.BizTalk.Component.Interop.IComponent,
        IBaseComponent,
        IComponentUI
    {
        //private System.Resources.ResourceManager resourceManager = new System.Resources.ResourceManager("BizTalkArchive.BizTalk.PipelineComponents.BizTalkArchive", Assembly.GetExecutingAssembly());

        #region IBaseComponent members

        public string Description
        {
            get
            {
                return "TransmitRest";
            }
        }

        public string Name
        {
            get
            {
                return "Restful method handler";
            }
        }

        public string Version
        {
            get
            {
                return "1.0.0.0";
            }

        }

        #endregion

        #region IComponent Members

        public IBaseMessage Execute(IPipelineContext pContext, IBaseMessage pInMsg)
        {
            Boolean debug = true;
            IBaseMessagePart bodyPart = pInMsg.BodyPart;
            string systemPropertiesNamespace = @"http://schemas.microsoft.com/BizTalk/2003/system-properties";
            string messageType = string.Empty;
            Stream originalStream = bodyPart.GetOriginalDataStream();
            IBaseMessageContext context = pInMsg.Context;
            var cxtOperation = context.Read("Operation", systemPropertiesNamespace);
            var cxtInboundHttpMethod = context.Read("InboundHttpMethod", systemPropertiesNamespace);

            if (cxtOperation.ToString() == "GetLocationsList")
            {
                if (debug) { EventLog.WriteEntry("IFM.MiRequest","Operation GetLocationsList",EventLogEntryType.Information);}
                XmlDocument xdoc = new XmlDocument();
                messageType = "https://IFM.MiRequest.LocationQuery#LocationRequest";
                var cxtContract = context.Read("Contract", "https://IFM.MiRequest.LocationsQuery_Prop");
                var cxtProvider = context.Read("Provider", "https://IFM.MiRequest.LocationsQuery_Prop");
                var cxtQuert = context.Read("Match", "https://IFM.MiRequest.LocationsQuery_Prop");
                string newtemplate = GetlocationListXmlString(cxtContract.ToString(), cxtProvider.ToString(), cxtQuert.ToString());
                if (debug) { EventLog.WriteEntry("IFM.MiRequest", newtemplate, EventLogEntryType.Information); }
                xdoc.LoadXml(newtemplate);
                MemoryStream memStream = GetMsgMemStream(xdoc);
                bodyPart.Data = memStream;
                pContext.ResourceTracker.AddResource(memStream);
                pInMsg.Context.Promote("MessageType", systemPropertiesNamespace, messageType);
            }

            if (cxtOperation.ToString() == "GetTaskEnquiry")
            {
                if (debug) { EventLog.WriteEntry("IFM.MiRequest","Operation GetTaskEnquiry",EventLogEntryType.Information);}
                XmlDocument xdoc = new XmlDocument();
                messageType = "https://IFM.MiRequest.TaskEnquiry#TaskEnquiryRequest";
                var cxtProvider = context.Read("Enq_Provider", "https://IFM.MiRequest.TaskEnquiry_Prop");
                var cxtPortalRef = context.Read("Enq_PortalRef", "https://IFM.MiRequest.TaskEnquiry_Prop");
                var cxtProviderRef = context.Read("Enq_ProviderRef", "https://IFM.MiRequest.TaskEnquiry_Prop");
                string newtemplate = GetTaskEnquiryXmlString(cxtProvider.ToString(), cxtProviderRef.ToString(), cxtPortalRef.ToString());
                if (debug) { EventLog.WriteEntry("IFM.MiRequest", newtemplate, EventLogEntryType.Information); }
                xdoc.LoadXml(newtemplate);
                MemoryStream memStream = GetMsgMemStream(xdoc);
                bodyPart.Data = memStream;
                pContext.ResourceTracker.AddResource(memStream);
                pInMsg.Context.Promote("MessageType", systemPropertiesNamespace, messageType);
            }

            if (cxtOperation.ToString() == "GetTasksList")
            {
                if (debug) { EventLog.WriteEntry("IFM.MiRequest", "Operation GetTasksList", EventLogEntryType.Information); }
                XmlDocument xdoc = new XmlDocument();
                messageType = "https://IFM.MiRequest.TaskListQuery#TaskListRequest";
                //https://IFM.MiRequest.TaskListQuery_Prop
                //https://IFM.MiRequest.TaskListQuery_Prop
                var cxtUser = context.Read("Lst_User", "https://IFM.MiRequest.TaskListQuery_Prop");
                var cxtStart = context.Read("Lst_Start", "https://IFM.MiRequest.TaskListQuery_Prop");
                string newtemplate = GetTaskListXmlString(cxtUser.ToString(), cxtStart.ToString());
                if (debug) { EventLog.WriteEntry("IFM.MiRequest", newtemplate, EventLogEntryType.Information); }
                xdoc.LoadXml(newtemplate);
                MemoryStream memStream = GetMsgMemStream(xdoc);
                bodyPart.Data = memStream;
                pContext.ResourceTracker.AddResource(memStream);
                pInMsg.Context.Promote("MessageType", systemPropertiesNamespace, messageType);
            }
            return pInMsg;
        }

        /// <summary>
        /// Returns memory stream of XML Document
        /// </summary>
        /// <param name="xdoc"></param>
        /// <returns></returns>
        private static MemoryStream GetMsgMemStream(XmlDocument xdoc)
        {
            byte[] outBytes = System.Text.Encoding.ASCII.GetBytes(xdoc.OuterXml.ToString());
            MemoryStream memStream = new MemoryStream();
            memStream.Write(outBytes, 0, outBytes.Length);
            memStream.Position = 0;
            return memStream;
        }

        /// <summary>
        /// Return an Xml String for the GetLocationsList restful call to pas to BizTalk
        /// </summary>
        /// <param name="cxtContract"></param>
        /// <param name="cxtProvider"></param>
        /// <param name="cxtQuert"></param>
        /// <returns></returns>
        private static string GetlocationListXmlString(string cxtContract, string cxtProvider, string cxtQuert)
        {
            string newtemplate = string.Format(@"<ns0:LocationRequest xmlns:ns0=""https://IFM.MiRequest.LocationQuery"">
<Contract>{0}</Contract>
<Provider>{1}</Provider>
<Match>{2}</Match>
</ns0:LocationRequest>", cxtContract, cxtProvider, cxtQuert);
            return newtemplate;
        }

        private static string GetTaskEnquiryXmlString(string provider, string providerref, string portalref)
        {
            string newtemplate = string.Format(@"<ns0:TaskEnquiryRequest xmlns:ns0=""https://IFM.MiRequest.TaskEnquiry"">
  <PortalRef>{2}</PortalRef>
  <Provider>{0}</Provider>
  <ProviderRef>{1}</ProviderRef>
</ns0:TaskEnquiryRequest>", provider, providerref, portalref);
            return newtemplate;
        }

        private static string GetTaskListXmlString(string user, string start)
        {
            string newtemplate = string.Format(@"<ns0:TaskListRequest xmlns:ns0=""https://IFM.MiRequest.TaskListQuery"">
  <user>{0}</user>
  <start>{1}</start>
</ns0:TaskListRequest>", user, start);
            return newtemplate;
        }

        #endregion

        #region IComponentUI members
        /// <summary>
        /// Component icon to use in BizTalk Editor
        /// </summary>
        [Browsable(false)]
        public IntPtr Icon
        {
            get
            {
                return new System.IntPtr();
                //return ((System.Drawing.Bitmap)(this.resourceManager.GetObject("COMPONENTICON", System.Globalization.CultureInfo.InvariantCulture))).GetHicon();
            }
        }

        /// <summary>
        /// The Validate method is called by the BizTalk Editor during the build 
        /// of a BizTalk project.
        /// </summary>
        /// <param name="obj">An Object containing the configuration properties.</param>
        /// <returns>The IEnumerator enables the caller to enumerate through a collection of strings containing error messages. These error messages appear as compiler error messages. To report successful property validation, the method should return an empty enumerator.</returns>
        public System.Collections.IEnumerator Validate(object obj)
        {
            // example implementation:
            // ArrayList errorList = new ArrayList();
            // errorList.Add("This is a compiler error");
            // return errorList.GetEnumerator();
            return null;
        }
        #endregion
    }
}
