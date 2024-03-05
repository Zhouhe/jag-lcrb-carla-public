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
    /// Microsoft.Dynamics.CRM.bookableresourcecategory
    /// </summary>
    public partial class MicrosoftDynamicsCRMbookableresourcecategory
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresourcecategory class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresourcecategory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresourcecategory class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresourcecategory(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owneridValue = default(string), int? statuscode = default(int?), string bookableresourcecategoryid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningteamValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string versionnumber = default(string), string _transactioncurrencyidValue = default(string), int? importsequencenumber = default(int?), string _owningbusinessunitValue = default(string), string _owninguserValue = default(string), string _modifiedbyValue = default(string), int? statecode = default(int?), decimal? exchangerate = default(decimal?), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), string description = default(string), string name = default(string), string _modifiedonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourcecategoryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourcecategoryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> bookableresourcecategoryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMprocesssession> bookableresourcecategoryProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bookableresourcecategoryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> bookableresourcecategoryPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMbookableresourcecategoryassn> bookableresourcecategoryBookableresourcecategoryassnResourceCategory = default(IList<MicrosoftDynamicsCRMbookableresourcecategoryassn>), IList<MicrosoftDynamicsCRMteam> bookableresourcecategoryTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> bookableresourcecategoryMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMsyncerror> bookableResourceCategorySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            Overriddencreatedon = overriddencreatedon;
            this._owneridValue = _owneridValue;
            Statuscode = statuscode;
            Bookableresourcecategoryid = bookableresourcecategoryid;
            Createdon = createdon;
            this._owningteamValue = _owningteamValue;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Importsequencenumber = importsequencenumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owninguserValue = _owninguserValue;
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            Exchangerate = exchangerate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Description = description;
            Name = name;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BookableresourcecategoryDuplicateMatchingRecord = bookableresourcecategoryDuplicateMatchingRecord;
            BookableresourcecategoryDuplicateBaseRecord = bookableresourcecategoryDuplicateBaseRecord;
            BookableresourcecategoryAsyncOperations = bookableresourcecategoryAsyncOperations;
            BookableresourcecategoryProcessSession = bookableresourcecategoryProcessSession;
            BookableresourcecategoryBulkDeleteFailures = bookableresourcecategoryBulkDeleteFailures;
            BookableresourcecategoryPrincipalObjectAttributeAccesses = bookableresourcecategoryPrincipalObjectAttributeAccesses;
            BookableresourcecategoryBookableresourcecategoryassnResourceCategory = bookableresourcecategoryBookableresourcecategoryassnResourceCategory;
            BookableresourcecategoryTeams = bookableresourcecategoryTeams;
            BookableresourcecategoryMailboxTrackingFolders = bookableresourcecategoryMailboxTrackingFolders;
            BookableResourceCategorySyncErrors = bookableResourceCategorySyncErrors;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecategoryid")]
        public string Bookableresourcecategoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

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
        [JsonProperty(PropertyName = "bookableresourcecategory_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourcecategoryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecategory_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourcecategoryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecategory_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BookableresourcecategoryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecategory_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> BookableresourcecategoryProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecategory_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BookableresourcecategoryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecategory_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> BookableresourcecategoryPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory")]
        public IList<MicrosoftDynamicsCRMbookableresourcecategoryassn> BookableresourcecategoryBookableresourcecategoryassnResourceCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecategory_Teams")]
        public IList<MicrosoftDynamicsCRMteam> BookableresourcecategoryTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecategory_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> BookableresourcecategoryMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BookableResourceCategory_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BookableResourceCategorySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
