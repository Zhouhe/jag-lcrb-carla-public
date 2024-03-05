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
    /// Microsoft.Dynamics.CRM.adoxio_citydistrict
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioCitydistrict
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCitydistrict class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioCitydistrict()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCitydistrict class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioCitydistrict(string adoxioOfficephone = default(string), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), string _adoxioOfficeidValue = default(string), string _createdonbehalfbyValue = default(string), string _owningteamValue = default(string), string _owneridValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _adoxioRegionidValue = default(string), int? importsequencenumber = default(int?), string _createdbyValue = default(string), string adoxioCitydistrictid = default(string), string versionnumber = default(string), string _adoxioInspectoridValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioCell = default(string), string _adoxioAreaidValue = default(string), string _owninguserValue = default(string), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), string adoxioName = default(string), string _modifiedbyValue = default(string), int? statecode = default(int?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioCitydistrictSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioCitydistrictDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioCitydistrictDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioCitydistrictAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioCitydistrictMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioCitydistrictProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioCitydistrictBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioCitydistrictPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioArea adoxioAreaId = default(MicrosoftDynamicsCRMadoxioArea), MicrosoftDynamicsCRMadoxioRegion adoxioRegionId = default(MicrosoftDynamicsCRMadoxioRegion), MicrosoftDynamicsCRMsystemuser adoxioInspectorId = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMadoxioTerritory adoxioOfficeId = default(MicrosoftDynamicsCRMadoxioTerritory), IList<MicrosoftDynamicsCRMadoxioComplaint> adoxioCitydistrictComplaints = default(IList<MicrosoftDynamicsCRMadoxioComplaint>), IList<MicrosoftDynamicsCRMadoxioComplaint> adoxioEstablishmentcitydistrictComplaints = default(IList<MicrosoftDynamicsCRMadoxioComplaint>), IList<MicrosoftDynamicsCRMadoxioSepcity> adoxioCitydistrictSepcities = default(IList<MicrosoftDynamicsCRMadoxioSepcity>), IList<MicrosoftDynamicsCRMadoxioEstablishment> adoxioCitydistrictAdoxioEstablishment = default(IList<MicrosoftDynamicsCRMadoxioEstablishment>), IList<MicrosoftDynamicsCRMadoxioLicences> adoxioCitydistrictAdoxioLicences = default(IList<MicrosoftDynamicsCRMadoxioLicences>))
        {
            AdoxioOfficephone = adoxioOfficephone;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._adoxioOfficeidValue = _adoxioOfficeidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            this._owneridValue = _owneridValue;
            Createdon = createdon;
            this._adoxioRegionidValue = _adoxioRegionidValue;
            Importsequencenumber = importsequencenumber;
            this._createdbyValue = _createdbyValue;
            AdoxioCitydistrictid = adoxioCitydistrictid;
            Versionnumber = versionnumber;
            this._adoxioInspectoridValue = _adoxioInspectoridValue;
            Modifiedon = modifiedon;
            AdoxioCell = adoxioCell;
            this._adoxioAreaidValue = _adoxioAreaidValue;
            this._owninguserValue = _owninguserValue;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioName = adoxioName;
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overriddencreatedon = overriddencreatedon;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioCitydistrictSyncErrors = adoxioCitydistrictSyncErrors;
            AdoxioCitydistrictDuplicateMatchingRecord = adoxioCitydistrictDuplicateMatchingRecord;
            AdoxioCitydistrictDuplicateBaseRecord = adoxioCitydistrictDuplicateBaseRecord;
            AdoxioCitydistrictAsyncOperations = adoxioCitydistrictAsyncOperations;
            AdoxioCitydistrictMailboxTrackingFolders = adoxioCitydistrictMailboxTrackingFolders;
            AdoxioCitydistrictProcessSession = adoxioCitydistrictProcessSession;
            AdoxioCitydistrictBulkDeleteFailures = adoxioCitydistrictBulkDeleteFailures;
            AdoxioCitydistrictPrincipalObjectAttributeAccesses = adoxioCitydistrictPrincipalObjectAttributeAccesses;
            AdoxioAreaId = adoxioAreaId;
            AdoxioRegionId = adoxioRegionId;
            AdoxioInspectorId = adoxioInspectorId;
            AdoxioOfficeId = adoxioOfficeId;
            AdoxioCitydistrictComplaints = adoxioCitydistrictComplaints;
            AdoxioEstablishmentcitydistrictComplaints = adoxioEstablishmentcitydistrictComplaints;
            AdoxioCitydistrictSepcities = adoxioCitydistrictSepcities;
            AdoxioCitydistrictAdoxioEstablishment = adoxioCitydistrictAdoxioEstablishment;
            AdoxioCitydistrictAdoxioLicences = adoxioCitydistrictAdoxioLicences;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_officephone")]
        public string AdoxioOfficephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_officeid_value")]
        public string _adoxioOfficeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_regionid_value")]
        public string _adoxioRegionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrictid")]
        public string AdoxioCitydistrictid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_inspectorid_value")]
        public string _adoxioInspectoridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cell")]
        public string AdoxioCell { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_areaid_value")]
        public string _adoxioAreaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

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
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_citydistrict_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioCitydistrictSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrict_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioCitydistrictDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrict_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioCitydistrictDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrict_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioCitydistrictAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrict_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioCitydistrictMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrict_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioCitydistrictProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrict_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioCitydistrictBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrict_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioCitydistrictPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AreaId")]
        public MicrosoftDynamicsCRMadoxioArea AdoxioAreaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RegionId")]
        public MicrosoftDynamicsCRMadoxioRegion AdoxioRegionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InspectorId")]
        public MicrosoftDynamicsCRMsystemuser AdoxioInspectorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_OfficeId")]
        public MicrosoftDynamicsCRMadoxioTerritory AdoxioOfficeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrict_complaints")]
        public IList<MicrosoftDynamicsCRMadoxioComplaint> AdoxioCitydistrictComplaints { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishmentcitydistrict_complaints")]
        public IList<MicrosoftDynamicsCRMadoxioComplaint> AdoxioEstablishmentcitydistrictComplaints { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrict_sepcities")]
        public IList<MicrosoftDynamicsCRMadoxioSepcity> AdoxioCitydistrictSepcities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrict_adoxio_establishment")]
        public IList<MicrosoftDynamicsCRMadoxioEstablishment> AdoxioCitydistrictAdoxioEstablishment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_citydistrict_adoxio_licences")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> AdoxioCitydistrictAdoxioLicences { get; set; }

    }
}
