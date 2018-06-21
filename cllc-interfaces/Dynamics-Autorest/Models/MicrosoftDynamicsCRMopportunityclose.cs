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

    public partial class MicrosoftDynamicsCRMopportunityclose : MicrosoftDynamicsCRMactivitypointer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunityclose class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunityclose()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunityclose class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunityclose(IList<MicrosoftDynamicsCRMasyncoperation> activityPointerAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> activityPointerBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMcampaignactivityitem> activityPointerCampaignActivityItems = default(IList<MicrosoftDynamicsCRMcampaignactivityitem>), IList<MicrosoftDynamicsCRMqueueitem> activityPointerQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMbulkoperationlog> createdActivityBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string _regardingobjectidValue = default(string), string _sendermailboxidValue = default(string), string _serviceidValue = default(string), string _slaidValue = default(string), string _slainvokedidValue = default(string), string _transactioncurrencyidValue = default(string), IList<MicrosoftDynamicsCRMcampaignresponse> activityCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMbulkoperation> activityPointerBulkOperation = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMbulkoperationlog> activityPointerBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), IList<MicrosoftDynamicsCRMactivitymimeattachment> activityPointerActivityMimeAttachment = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), IList<MicrosoftDynamicsCRMappointment> activityPointerAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMcampaignactivity> activityPointerCampaignactivity = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMcampaignresponse> activityPointerCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMemail> activityPointerEmail = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> activityPointerFax = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMincidentresolution> activityPointerIncidentResolution = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMletter> activityPointerLetter = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMopportunityclose> activityPointerOpportunityClose = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> activityPointerOrderClose = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMphonecall> activityPointerPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMquoteclose> activityPointerQuoteClose = default(IList<MicrosoftDynamicsCRMquoteclose>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> activityPointerRecurringappointmentmaster = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMserviceappointment> activityPointerServiceAppointment = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMsocialactivity> activityPointerSocialactivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMtask> activityPointerTask = default(IList<MicrosoftDynamicsCRMtask>), string activityadditionalparams = default(string), string activityid = default(string), IList<MicrosoftDynamicsCRMactivityparty> activitypointerActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), string activitytypecode = default(string), int? actualdurationminutes = default(int?), System.DateTimeOffset? actualend = default(System.DateTimeOffset?), System.DateTimeOffset? actualstart = default(System.DateTimeOffset?), int? community = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? deliverylastattemptedon = default(System.DateTimeOffset?), int? deliveryprioritycode = default(int?), string description = default(string), string exchangeitemid = default(string), double? exchangerate = default(double?), string exchangeweblink = default(string), int? instancetypecode = default(int?), bool? isbilled = default(bool?), bool? ismapiprivate = default(bool?), bool? isregularactivity = default(bool?), bool? isworkflowcreated = default(bool?), System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), bool? leftvoicemail = default(bool?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), int? onholdtime = default(int?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? postponeactivityprocessinguntil = default(System.DateTimeOffset?), int? prioritycode = default(int?), string processid = default(string), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMadoxioAgencycommunication regardingobjectidAdoxioAgencycommunication = default(MicrosoftDynamicsCRMadoxioAgencycommunication), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaint = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigation = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioInvestigationstakeholder regardingobjectidAdoxioInvestigationstakeholder = default(MicrosoftDynamicsCRMadoxioInvestigationstakeholder), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicences = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebooking = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheader = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperation = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaign regardingobjectidCampaign = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMcontract regardingobjectidContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlement = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplate = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMincident regardingobjectidIncident = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMinvoice regardingobjectidInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecord = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemail = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMquote regardingobjectidQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorder = default(MicrosoftDynamicsCRMsalesorder), int? scheduleddurationminutes = default(int?), System.DateTimeOffset? scheduledend = default(System.DateTimeOffset?), System.DateTimeOffset? scheduledstart = default(System.DateTimeOffset?), MicrosoftDynamicsCRMmailbox sendermailboxid = default(MicrosoftDynamicsCRMmailbox), System.DateTimeOffset? senton = default(System.DateTimeOffset?), string seriesid = default(string), MicrosoftDynamicsCRMservice serviceid = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMsla slaActivitypointerSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceActivitypointer = default(IList<MicrosoftDynamicsCRMslakpiinstance>), System.DateTimeOffset? sortdate = default(System.DateTimeOffset?), string stageid = default(string), int? statecode = default(int?), int? statuscode = default(int?), string subject = default(string), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), string traversedpath = default(string), int? utcconversiontimezonecode = default(int?), object versionnumber = default(object), IList<MicrosoftDynamicsCRMannotation> opportunityCloseAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> opportunityCloseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> opportunityCloseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> opportunityCloseSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _competitoridValue = default(string), string _opportunityidValue = default(string), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), double? actualrevenue = default(double?), double? actualrevenueBase = default(double?), string category = default(string), MicrosoftDynamicsCRMcompetitor competitorid = default(MicrosoftDynamicsCRMcompetitor), MicrosoftDynamicsCRMsystemuser createdbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser modifiedbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivityparty> opportunitycloseActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMbusinessunit owningbusinessunitOpportunityclose = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteamOpportunityclose = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguserOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMservice serviceidOpportunityclose = default(MicrosoftDynamicsCRMservice), string subcategory = default(string), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidOpportunityclose = default(MicrosoftDynamicsCRMtransactioncurrency))
            : base(activityPointerAsyncOperations, activityPointerBulkDeleteFailures, activityPointerCampaignActivityItems, activityPointerQueueItem, createdActivityBulkOperationLogs, _createdbyValue, _createdonbehalfbyValue, _modifiedbyValue, _modifiedonbehalfbyValue, _owneridValue, _owningbusinessunitValue, _owningteamValue, _owninguserValue, _regardingobjectidValue, _sendermailboxidValue, _serviceidValue, _slaidValue, _slainvokedidValue, _transactioncurrencyidValue, activityCampaignresponse, activityPointerBulkOperation, activityPointerBulkOperationLogs, activityPointerActivityMimeAttachment, activityPointerAppointment, activityPointerCampaignactivity, activityPointerCampaignresponse, activityPointerEmail, activityPointerFax, activityPointerIncidentResolution, activityPointerLetter, activityPointerOpportunityClose, activityPointerOrderClose, activityPointerPhonecall, activityPointerQuoteClose, activityPointerRecurringappointmentmaster, activityPointerServiceAppointment, activityPointerSocialactivity, activityPointerTask, activityadditionalparams, activityid, activitypointerActivityParties, activitypointerConnections1, activitypointerConnections2, activitytypecode, actualdurationminutes, actualend, actualstart, community, createdby, createdon, createdonbehalfby, deliverylastattemptedon, deliveryprioritycode, description, exchangeitemid, exchangerate, exchangeweblink, instancetypecode, isbilled, ismapiprivate, isregularactivity, isworkflowcreated, lastonholdtime, leftvoicemail, modifiedby, modifiedon, modifiedonbehalfby, onholdtime, ownerid, owningbusinessunit, owningteam, owninguser, postponeactivityprocessinguntil, prioritycode, processid, regardingobjectidAccount, regardingobjectidAdoxioAgencycommunication, regardingobjectidAdoxioApplication, regardingobjectidAdoxioComplaint, regardingobjectidAdoxioInvestigation, regardingobjectidAdoxioInvestigationstakeholder, regardingobjectidAdoxioLicences, regardingobjectidBookableresourcebooking, regardingobjectidBookableresourcebookingheader, regardingobjectidBulkoperation, regardingobjectidCampaign, regardingobjectidCampaignactivity, regardingobjectidContact, regardingobjectidContract, regardingobjectidEntitlement, regardingobjectidEntitlementtemplate, regardingobjectidIncident, regardingobjectidInvoice, regardingobjectidKnowledgearticle, regardingobjectidKnowledgebaserecord, regardingobjectidLead, regardingobjectidNewInteractionforemail, regardingobjectidOpportunity, regardingobjectidQuote, regardingobjectidSalesorder, scheduleddurationminutes, scheduledend, scheduledstart, sendermailboxid, senton, seriesid, serviceid, slaActivitypointerSla, slainvokedidActivitypointerSla, slakpiinstanceActivitypointer, sortdate, stageid, statecode, statuscode, subject, timezoneruleversionnumber, transactioncurrencyid, traversedpath, utcconversiontimezonecode, versionnumber)
        {
            OpportunityCloseAnnotation = opportunityCloseAnnotation;
            OpportunityCloseAsyncOperations = opportunityCloseAsyncOperations;
            OpportunityCloseBulkDeleteFailures = opportunityCloseBulkDeleteFailures;
            OpportunityCloseSyncErrors = opportunityCloseSyncErrors;
            this._competitoridValue = _competitoridValue;
            this._opportunityidValue = _opportunityidValue;
            ActivityidActivitypointer = activityidActivitypointer;
            Actualrevenue = actualrevenue;
            ActualrevenueBase = actualrevenueBase;
            Category = category;
            Competitorid = competitorid;
            CreatedbyOpportunityclose = createdbyOpportunityclose;
            CreatedonbehalfbyOpportunityclose = createdonbehalfbyOpportunityclose;
            Importsequencenumber = importsequencenumber;
            ModifiedbyOpportunityclose = modifiedbyOpportunityclose;
            ModifiedonbehalfbyOpportunityclose = modifiedonbehalfbyOpportunityclose;
            OpportunitycloseActivityParties = opportunitycloseActivityParties;
            Opportunityid = opportunityid;
            Overriddencreatedon = overriddencreatedon;
            OwningbusinessunitOpportunityclose = owningbusinessunitOpportunityclose;
            OwningteamOpportunityclose = owningteamOpportunityclose;
            OwninguserOpportunityclose = owninguserOpportunityclose;
            ServiceidOpportunityclose = serviceidOpportunityclose;
            Subcategory = subcategory;
            TransactioncurrencyidOpportunityclose = transactioncurrencyidOpportunityclose;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> OpportunityCloseAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> OpportunityCloseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> OpportunityCloseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> OpportunityCloseSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_competitorid_value")]
        public string _competitoridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualrevenue")]
        public double? Actualrevenue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualrevenue_base")]
        public double? ActualrevenueBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorid")]
        public MicrosoftDynamicsCRMcompetitor Competitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityclose_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> OpportunitycloseActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_opportunityclose")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_opportunityclose")]
        public MicrosoftDynamicsCRMteam OwningteamOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser OwninguserOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_opportunityclose")]
        public MicrosoftDynamicsCRMservice ServiceidOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_opportunityclose")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidOpportunityclose { get; set; }

    }
}
