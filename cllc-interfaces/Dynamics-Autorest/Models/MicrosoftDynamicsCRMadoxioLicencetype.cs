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
    /// Microsoft.Dynamics.CRM.adoxio_licencetype
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioLicencetype
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencetype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencetype()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencetype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencetype(int? utcconversiontimezonecode = default(int?), string _owningteamValue = default(string), string _createdbyValue = default(string), string adoxioDefaultbpfid = default(string), string adoxioName = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string _owneridValue = default(string), string adoxioCode = default(string), string _adoxioApplicationfeeproductValue = default(string), bool? adoxioShowlicenseerepresentativetab = default(bool?), string _owningbusinessunitValue = default(string), int? timezoneruleversionnumber = default(int?), string _modifiedonbehalfbyValue = default(string), string _owninguserValue = default(string), int? statuscode = default(int?), string _adoxioLicencefeeproductValue = default(string), int? adoxioCategory = default(int?), string _createdonbehalfbyValue = default(string), int? adoxioOnestopprogramaccounttype = default(int?), bool? adoxioUsepmuarea = default(bool?), int? statecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioRequirements = default(string), int? adoxioDisplayorder = default(int?), string adoxioLicencetypeid = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioLicencetypeSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLicencetypeDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLicencetypeDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioLicencetypeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioLicencetypeMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioLicencetypeProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioLicencetypeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioLicencetypePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMknowledgebaserecord> adoxioLicencetypeKnowledgebaserecord = default(IList<MicrosoftDynamicsCRMknowledgebaserecord>), IList<MicrosoftDynamicsCRMknowledgearticle> msdynAdoxioLicencetypeKnowledgearticle = default(IList<MicrosoftDynamicsCRMknowledgearticle>), IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> adoxioAdoxioLicencetypeAdoxioApplicationtermsconditionslimitationLicenceType = default(IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation>), IList<MicrosoftDynamicsCRMadoxioInvestigation> adoxioAdoxioLicencetypeAdoxioInvestigation = default(IList<MicrosoftDynamicsCRMadoxioInvestigation>), IList<MicrosoftDynamicsCRMadoxioLicences> adoxioAdoxioLicencetypeAdoxioLicencesLicenceType = default(IList<MicrosoftDynamicsCRMadoxioLicences>), IList<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset> adoxioAdoxioLicencetypeAdoxioTermsconditionslimitationspresetLicenceType = default(IList<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset>), IList<MicrosoftDynamicsCRMincident> adoxioIncidentAdoxioLicencetype = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioLicencetypeAdoxioApplicationLicenceType = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioEstablishment> adoxioLicencetypeEstablishment = default(IList<MicrosoftDynamicsCRMadoxioEstablishment>), MicrosoftDynamicsCRMproduct adoxioApplicationFeeProduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMproduct adoxioLicenceFeeProduct = default(MicrosoftDynamicsCRMproduct), IList<MicrosoftDynamicsCRMadoxioApplicationtype> adoxioLicencetypesApplicationtypes = default(IList<MicrosoftDynamicsCRMadoxioApplicationtype>), IList<MicrosoftDynamicsCRMadoxioApplicationtype> adoxioLicencetypeAdoxioApplicationtypeLicenceType = default(IList<MicrosoftDynamicsCRMadoxioApplicationtype>), IList<MicrosoftDynamicsCRMadoxioInspectorcommentsrollup> adoxioLicencetypeAdoxioInspectorcommentsrollupLicenceType = default(IList<MicrosoftDynamicsCRMadoxioInspectorcommentsrollup>), IList<MicrosoftDynamicsCRMincident> adoxioLicencetypeInspections = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMadoxioRmreview> adoxioLicencetypeAdoxioRmreviewLicenceType = default(IList<MicrosoftDynamicsCRMadoxioRmreview>), IList<MicrosoftDynamicsCRMadoxioEnforcementaction> adoxioLicencetypeEnforcementactions = default(IList<MicrosoftDynamicsCRMadoxioEnforcementaction>), IList<MicrosoftDynamicsCRMadoxioLicencesubcategory> adoxioLicencetypeAdoxioLicencesubcategoryLicenceType = default(IList<MicrosoftDynamicsCRMadoxioLicencesubcategory>), IList<MicrosoftDynamicsCRMadoxioInspectionformconfiguration> adoxioLicencetypeAdoxioInspectionformconfigurationLicenceType = default(IList<MicrosoftDynamicsCRMadoxioInspectionformconfiguration>))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owningteamValue = _owningteamValue;
            this._createdbyValue = _createdbyValue;
            AdoxioDefaultbpfid = adoxioDefaultbpfid;
            AdoxioName = adoxioName;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            Versionnumber = versionnumber;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            this._owneridValue = _owneridValue;
            AdoxioCode = adoxioCode;
            this._adoxioApplicationfeeproductValue = _adoxioApplicationfeeproductValue;
            AdoxioShowlicenseerepresentativetab = adoxioShowlicenseerepresentativetab;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owninguserValue = _owninguserValue;
            Statuscode = statuscode;
            this._adoxioLicencefeeproductValue = _adoxioLicencefeeproductValue;
            AdoxioCategory = adoxioCategory;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioOnestopprogramaccounttype = adoxioOnestopprogramaccounttype;
            AdoxioUsepmuarea = adoxioUsepmuarea;
            Statecode = statecode;
            Overriddencreatedon = overriddencreatedon;
            AdoxioRequirements = adoxioRequirements;
            AdoxioDisplayorder = adoxioDisplayorder;
            AdoxioLicencetypeid = adoxioLicencetypeid;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioLicencetypeSyncErrors = adoxioLicencetypeSyncErrors;
            AdoxioLicencetypeDuplicateMatchingRecord = adoxioLicencetypeDuplicateMatchingRecord;
            AdoxioLicencetypeDuplicateBaseRecord = adoxioLicencetypeDuplicateBaseRecord;
            AdoxioLicencetypeAsyncOperations = adoxioLicencetypeAsyncOperations;
            AdoxioLicencetypeMailboxTrackingFolders = adoxioLicencetypeMailboxTrackingFolders;
            AdoxioLicencetypeProcessSession = adoxioLicencetypeProcessSession;
            AdoxioLicencetypeBulkDeleteFailures = adoxioLicencetypeBulkDeleteFailures;
            AdoxioLicencetypePrincipalObjectAttributeAccesses = adoxioLicencetypePrincipalObjectAttributeAccesses;
            AdoxioLicencetypeKnowledgebaserecord = adoxioLicencetypeKnowledgebaserecord;
            MsdynAdoxioLicencetypeKnowledgearticle = msdynAdoxioLicencetypeKnowledgearticle;
            AdoxioAdoxioLicencetypeAdoxioApplicationtermsconditionslimitationLicenceType = adoxioAdoxioLicencetypeAdoxioApplicationtermsconditionslimitationLicenceType;
            AdoxioAdoxioLicencetypeAdoxioInvestigation = adoxioAdoxioLicencetypeAdoxioInvestigation;
            AdoxioAdoxioLicencetypeAdoxioLicencesLicenceType = adoxioAdoxioLicencetypeAdoxioLicencesLicenceType;
            AdoxioAdoxioLicencetypeAdoxioTermsconditionslimitationspresetLicenceType = adoxioAdoxioLicencetypeAdoxioTermsconditionslimitationspresetLicenceType;
            AdoxioIncidentAdoxioLicencetype = adoxioIncidentAdoxioLicencetype;
            AdoxioLicencetypeAdoxioApplicationLicenceType = adoxioLicencetypeAdoxioApplicationLicenceType;
            AdoxioLicencetypeEstablishment = adoxioLicencetypeEstablishment;
            AdoxioApplicationFeeProduct = adoxioApplicationFeeProduct;
            AdoxioLicenceFeeProduct = adoxioLicenceFeeProduct;
            AdoxioLicencetypesApplicationtypes = adoxioLicencetypesApplicationtypes;
            AdoxioLicencetypeAdoxioApplicationtypeLicenceType = adoxioLicencetypeAdoxioApplicationtypeLicenceType;
            AdoxioLicencetypeAdoxioInspectorcommentsrollupLicenceType = adoxioLicencetypeAdoxioInspectorcommentsrollupLicenceType;
            AdoxioLicencetypeInspections = adoxioLicencetypeInspections;
            AdoxioLicencetypeAdoxioRmreviewLicenceType = adoxioLicencetypeAdoxioRmreviewLicenceType;
            AdoxioLicencetypeEnforcementactions = adoxioLicencetypeEnforcementactions;
            AdoxioLicencetypeAdoxioLicencesubcategoryLicenceType = adoxioLicencetypeAdoxioLicencesubcategoryLicenceType;
            AdoxioLicencetypeAdoxioInspectionformconfigurationLicenceType = adoxioLicencetypeAdoxioInspectionformconfigurationLicenceType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_defaultbpfid")]
        public string AdoxioDefaultbpfid { get; set; }

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
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_code")]
        public string AdoxioCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationfeeproduct_value")]
        public string _adoxioApplicationfeeproductValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_showlicenseerepresentativetab")]
        public bool? AdoxioShowlicenseerepresentativetab { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "_adoxio_licencefeeproduct_value")]
        public string _adoxioLicencefeeproductValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_category")]
        public int? AdoxioCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_onestopprogramaccounttype")]
        public int? AdoxioOnestopprogramaccounttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_usepmuarea")]
        public bool? AdoxioUsepmuarea { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_requirements")]
        public string AdoxioRequirements { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_displayorder")]
        public int? AdoxioDisplayorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypeid")]
        public string AdoxioLicencetypeid { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_licencetype_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioLicencetypeSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLicencetypeDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLicencetypeDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioLicencetypeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioLicencetypeMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioLicencetypeProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioLicencetypeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioLicencetypePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_knowledgebaserecord")]
        public IList<MicrosoftDynamicsCRMknowledgebaserecord> AdoxioLicencetypeKnowledgebaserecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_adoxio_licencetype_knowledgearticle")]
        public IList<MicrosoftDynamicsCRMknowledgearticle> MsdynAdoxioLicencetypeKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_licencetype_adoxio_applicationtermsconditionslimitation_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> AdoxioAdoxioLicencetypeAdoxioApplicationtermsconditionslimitationLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_licencetype_adoxio_investigation")]
        public IList<MicrosoftDynamicsCRMadoxioInvestigation> AdoxioAdoxioLicencetypeAdoxioInvestigation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_licencetype_adoxio_licences_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> AdoxioAdoxioLicencetypeAdoxioLicencesLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_licencetype_adoxio_termsconditionslimitationspreset_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset> AdoxioAdoxioLicencetypeAdoxioTermsconditionslimitationspresetLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_incident_adoxio_licencetype")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioIncidentAdoxioLicencetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_adoxio_application_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioLicencetypeAdoxioApplicationLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_establishment")]
        public IList<MicrosoftDynamicsCRMadoxioEstablishment> AdoxioLicencetypeEstablishment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ApplicationFeeProduct")]
        public MicrosoftDynamicsCRMproduct AdoxioApplicationFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceFeeProduct")]
        public MicrosoftDynamicsCRMproduct AdoxioLicenceFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypes_applicationtypes")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtype> AdoxioLicencetypesApplicationtypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_adoxio_applicationtype_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtype> AdoxioLicencetypeAdoxioApplicationtypeLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_adoxio_inspectorcommentsrollup_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioInspectorcommentsrollup> AdoxioLicencetypeAdoxioInspectorcommentsrollupLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_inspections")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioLicencetypeInspections { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_adoxio_rmreview_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioRmreview> AdoxioLicencetypeAdoxioRmreviewLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_enforcementactions")]
        public IList<MicrosoftDynamicsCRMadoxioEnforcementaction> AdoxioLicencetypeEnforcementactions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_adoxio_licencesubcategory_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioLicencesubcategory> AdoxioLicencetypeAdoxioLicencesubcategoryLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_adoxio_inspectionformconfiguration_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioInspectionformconfiguration> AdoxioLicencetypeAdoxioInspectionformconfigurationLicenceType { get; set; }

    }
}
