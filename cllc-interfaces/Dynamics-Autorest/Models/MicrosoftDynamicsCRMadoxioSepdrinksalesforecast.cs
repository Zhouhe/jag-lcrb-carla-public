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
    /// Microsoft.Dynamics.CRM.adoxio_sepdrinksalesforecast
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioSepdrinksalesforecast
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioSepdrinksalesforecast class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioSepdrinksalesforecast()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioSepdrinksalesforecast class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioSepdrinksalesforecast(decimal? adoxioEstimatedrevenue = default(decimal?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statecode = default(int?), int? statuscode = default(int?), bool? adoxioIscharging = default(bool?), string adoxioName = default(string), int? utcconversiontimezonecode = default(int?), string _owningbusinessunitValue = default(string), string _owneridValue = default(string), string _modifiedonbehalfbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? adoxioEstimatedservings = default(int?), string _owninguserValue = default(string), decimal? adoxioPriceperserving = default(decimal?), int? importsequencenumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _adoxioTypeValue = default(string), string adoxioSepdrinksalesforecastid = default(string), decimal? adoxioEstimatedcost = default(decimal?), string _adoxioSpecialeventValue = default(string), string versionnumber = default(string), string _owningteamValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioSepdrinksalesforecastSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioSepdrinksalesforecastDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioSepdrinksalesforecastDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioSepdrinksalesforecastAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioSepdrinksalesforecastMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioSepdrinksalesforecastProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioSepdrinksalesforecastBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioSepdrinksalesforecastPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioSepdrinktype adoxioType = default(MicrosoftDynamicsCRMadoxioSepdrinktype), MicrosoftDynamicsCRMadoxioSpecialevent adoxioSpecialEvent = default(MicrosoftDynamicsCRMadoxioSpecialevent))
        {
            AdoxioEstimatedrevenue = adoxioEstimatedrevenue;
            Modifiedon = modifiedon;
            Statecode = statecode;
            Statuscode = statuscode;
            AdoxioIscharging = adoxioIscharging;
            AdoxioName = adoxioName;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owneridValue = _owneridValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Overriddencreatedon = overriddencreatedon;
            AdoxioEstimatedservings = adoxioEstimatedservings;
            this._owninguserValue = _owninguserValue;
            AdoxioPriceperserving = adoxioPriceperserving;
            Importsequencenumber = importsequencenumber;
            Createdon = createdon;
            this._adoxioTypeValue = _adoxioTypeValue;
            AdoxioSepdrinksalesforecastid = adoxioSepdrinksalesforecastid;
            AdoxioEstimatedcost = adoxioEstimatedcost;
            this._adoxioSpecialeventValue = _adoxioSpecialeventValue;
            Versionnumber = versionnumber;
            this._owningteamValue = _owningteamValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioSepdrinksalesforecastSyncErrors = adoxioSepdrinksalesforecastSyncErrors;
            AdoxioSepdrinksalesforecastDuplicateMatchingRecord = adoxioSepdrinksalesforecastDuplicateMatchingRecord;
            AdoxioSepdrinksalesforecastDuplicateBaseRecord = adoxioSepdrinksalesforecastDuplicateBaseRecord;
            AdoxioSepdrinksalesforecastAsyncOperations = adoxioSepdrinksalesforecastAsyncOperations;
            AdoxioSepdrinksalesforecastMailboxTrackingFolders = adoxioSepdrinksalesforecastMailboxTrackingFolders;
            AdoxioSepdrinksalesforecastProcessSession = adoxioSepdrinksalesforecastProcessSession;
            AdoxioSepdrinksalesforecastBulkDeleteFailures = adoxioSepdrinksalesforecastBulkDeleteFailures;
            AdoxioSepdrinksalesforecastPrincipalObjectAttributeAccesses = adoxioSepdrinksalesforecastPrincipalObjectAttributeAccesses;
            AdoxioType = adoxioType;
            AdoxioSpecialEvent = adoxioSpecialEvent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_estimatedrevenue")]
        public decimal? AdoxioEstimatedrevenue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ischarging")]
        public bool? AdoxioIscharging { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

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
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_estimatedservings")]
        public int? AdoxioEstimatedservings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_priceperserving")]
        public decimal? AdoxioPriceperserving { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_type_value")]
        public string _adoxioTypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sepdrinksalesforecastid")]
        public string AdoxioSepdrinksalesforecastid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_estimatedcost")]
        public decimal? AdoxioEstimatedcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_specialevent_value")]
        public string _adoxioSpecialeventValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sepdrinksalesforecast_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioSepdrinksalesforecastSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sepdrinksalesforecast_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioSepdrinksalesforecastDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sepdrinksalesforecast_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioSepdrinksalesforecastDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sepdrinksalesforecast_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioSepdrinksalesforecastAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sepdrinksalesforecast_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioSepdrinksalesforecastMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sepdrinksalesforecast_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioSepdrinksalesforecastProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sepdrinksalesforecast_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioSepdrinksalesforecastBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sepdrinksalesforecast_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioSepdrinksalesforecastPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Type")]
        public MicrosoftDynamicsCRMadoxioSepdrinktype AdoxioType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_SpecialEvent")]
        public MicrosoftDynamicsCRMadoxioSpecialevent AdoxioSpecialEvent { get; set; }

    }
}
