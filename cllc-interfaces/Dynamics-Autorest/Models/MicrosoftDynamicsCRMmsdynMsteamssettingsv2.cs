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
    /// Microsoft.Dynamics.CRM.msdyn_msteamssettingsv2
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynMsteamssettingsv2
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynMsteamssettingsv2 class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynMsteamssettingsv2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynMsteamssettingsv2 class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynMsteamssettingsv2(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), int? statuscode = default(int?), int? timezoneruleversionnumber = default(int?), string versionnumber = default(string), string msdynMsteamssettingsname = default(string), int? utcconversiontimezonecode = default(int?), string _createdbyValue = default(string), string msdynTabserviceurl = default(string), string _modifiedonbehalfbyValue = default(string), string msdynMsteamssettingsv2id = default(string), int? statecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> msdynMsteamssettingsv2SyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> msdynMsteamssettingsv2AsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynMsteamssettingsv2MailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynMsteamssettingsv2ProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynMsteamssettingsv2BulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynMsteamssettingsv2PrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Overriddencreatedon = overriddencreatedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Versionnumber = versionnumber;
            MsdynMsteamssettingsname = msdynMsteamssettingsname;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdbyValue = _createdbyValue;
            MsdynTabserviceurl = msdynTabserviceurl;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            MsdynMsteamssettingsv2id = msdynMsteamssettingsv2id;
            Statecode = statecode;
            Createdon = createdon;
            Modifiedon = modifiedon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Importsequencenumber = importsequencenumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            MsdynMsteamssettingsv2SyncErrors = msdynMsteamssettingsv2SyncErrors;
            MsdynMsteamssettingsv2AsyncOperations = msdynMsteamssettingsv2AsyncOperations;
            MsdynMsteamssettingsv2MailboxTrackingFolders = msdynMsteamssettingsv2MailboxTrackingFolders;
            MsdynMsteamssettingsv2ProcessSession = msdynMsteamssettingsv2ProcessSession;
            MsdynMsteamssettingsv2BulkDeleteFailures = msdynMsteamssettingsv2BulkDeleteFailures;
            MsdynMsteamssettingsv2PrincipalObjectAttributeAccesses = msdynMsteamssettingsv2PrincipalObjectAttributeAccesses;
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
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_msteamssettingsname")]
        public string MsdynMsteamssettingsname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_tabserviceurl")]
        public string MsdynTabserviceurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_msteamssettingsv2id")]
        public string MsdynMsteamssettingsv2id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_msteamssettingsv2_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynMsteamssettingsv2SyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_msteamssettingsv2_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynMsteamssettingsv2AsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_msteamssettingsv2_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynMsteamssettingsv2MailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_msteamssettingsv2_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynMsteamssettingsv2ProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_msteamssettingsv2_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynMsteamssettingsv2BulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_msteamssettingsv2_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynMsteamssettingsv2PrincipalObjectAttributeAccesses { get; set; }

    }
}
