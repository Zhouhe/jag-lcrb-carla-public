// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.competitoraddress
    /// </summary>
    public partial class MicrosoftDynamicsCRMcompetitoraddress
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcompetitoraddress class.
        /// </summary>
        public MicrosoftDynamicsCRMcompetitoraddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcompetitoraddress class.
        /// </summary>
        public MicrosoftDynamicsCRMcompetitoraddress(string stateorprovince = default(string), string telephone2 = default(string), int? utcoffset = default(int?), string composite = default(string), string upszone = default(string), int? addresstypecode = default(int?), string _modifiedonbehalfbyValue = default(string), string line1 = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string postalcode = default(string), decimal? latitude = default(decimal?), string versionnumber = default(string), string telephone1 = default(string), string name = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string county = default(string), int? addressnumber = default(int?), string city = default(string), string telephone3 = default(string), int? importsequencenumber = default(int?), decimal? longitude = default(decimal?), string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), string fax = default(string), string _parentidValue = default(string), string line3 = default(string), string line2 = default(string), string _createdonbehalfbyValue = default(string), string country = default(string), string competitoraddressid = default(string), string _modifiedbyValue = default(string), int? shippingmethodcode = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string postofficebox = default(string), IList<MicrosoftDynamicsCRMteam> competitoraddressTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMasyncoperation> competitoraddressAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> competitoraddressMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> competitoraddressBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> competitoraddressPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> competitorAddressSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcompetitor parentid = default(MicrosoftDynamicsCRMcompetitor), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Stateorprovince = stateorprovince;
            Telephone2 = telephone2;
            Utcoffset = utcoffset;
            Composite = composite;
            Upszone = upszone;
            Addresstypecode = addresstypecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Line1 = line1;
            Modifiedon = modifiedon;
            Postalcode = postalcode;
            Latitude = latitude;
            Versionnumber = versionnumber;
            Telephone1 = telephone1;
            Name = name;
            Createdon = createdon;
            County = county;
            Addressnumber = addressnumber;
            City = city;
            Telephone3 = telephone3;
            Importsequencenumber = importsequencenumber;
            Longitude = longitude;
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Fax = fax;
            this._parentidValue = _parentidValue;
            Line3 = line3;
            Line2 = line2;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Country = country;
            Competitoraddressid = competitoraddressid;
            this._modifiedbyValue = _modifiedbyValue;
            Shippingmethodcode = shippingmethodcode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Overriddencreatedon = overriddencreatedon;
            Postofficebox = postofficebox;
            CompetitoraddressTeams = competitoraddressTeams;
            CompetitoraddressAsyncOperations = competitoraddressAsyncOperations;
            CompetitoraddressMailboxTrackingFolders = competitoraddressMailboxTrackingFolders;
            CompetitoraddressBulkDeleteFailures = competitoraddressBulkDeleteFailures;
            CompetitoraddressPrincipalObjectAttributeAccesses = competitoraddressPrincipalObjectAttributeAccesses;
            Createdby = createdby;
            Modifiedby = modifiedby;
            CompetitorAddressSyncErrors = competitorAddressSyncErrors;
            Createdonbehalfby = createdonbehalfby;
            Parentid = parentid;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stateorprovince")]
        public string Stateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone2")]
        public string Telephone2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcoffset")]
        public int? Utcoffset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "composite")]
        public string Composite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "upszone")]
        public string Upszone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addresstypecode")]
        public int? Addresstypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postalcode")]
        public string Postalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone1")]
        public string Telephone1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "county")]
        public string County { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressnumber")]
        public int? Addressnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone3")]
        public string Telephone3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentid_value")]
        public string _parentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line3")]
        public string Line3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitoraddressid")]
        public string Competitoraddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postofficebox")]
        public string Postofficebox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitoraddress_Teams")]
        public IList<MicrosoftDynamicsCRMteam> CompetitoraddressTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitoraddress_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CompetitoraddressAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitoraddress_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CompetitoraddressMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitoraddress_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CompetitoraddressBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitoraddress_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CompetitoraddressPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CompetitorAddress_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CompetitorAddressSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentid")]
        public MicrosoftDynamicsCRMcompetitor Parentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
