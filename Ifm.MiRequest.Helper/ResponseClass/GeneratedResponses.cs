using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://IFM.MiRequest.LocationQuery")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "https://IFM.MiRequest.LocationQuery", IsNullable = false)]
public partial class LocationResponse
{

    private Result resultField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
    public Result Result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Result
{

    private string resultCodeField;

    private string messageField;

    private Int32 numRecordsField;

    private ResultLocation[] locationsField;

    /// <remarks/>
    public string ResultCode
    {
        get
        {
            return this.resultCodeField;
        }
        set
        {
            this.resultCodeField = value;
        }
    }

    /// <remarks/>
    public string Message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    public Int32 NumRecords
    {
        get
        {
            return this.numRecordsField;
        }
        set
        {
            this.numRecordsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Location", IsNullable = false)]
    public ResultLocation[] Locations
    {
        get
        {
            return this.locationsField;
        }
        set
        {
            this.locationsField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ResultLocation
{

    private string descriptionField;

    private string locationField;

    private string siteIdField;

    private string orgIdField;

    private string addressField;

    /// <remarks/>
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    public string Location
    {
        get
        {
            return this.locationField;
        }
        set
        {
            this.locationField = value;
        }
    }

    /// <remarks/>
    public string SiteId
    {
        get
        {
            return this.siteIdField;
        }
        set
        {
            this.siteIdField = value;
        }
    }

    /// <remarks/>
    public string OrgId
    {
        get
        {
            return this.orgIdField;
        }
        set
        {
            this.orgIdField = value;
        }
    }

    public string Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }

    }
}




