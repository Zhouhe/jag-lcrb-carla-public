// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.goal
    /// </summary>
    public partial class MicrosoftDynamicsCRMgoal
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMgoal class.
        /// </summary>
        public MicrosoftDynamicsCRMgoal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMgoal class.
        /// </summary>
        public MicrosoftDynamicsCRMgoal(decimal? computedtargetasoftodaypercentageachieved = default(decimal?), string stretchtargetstring = default(string), int? amountdatatype = default(int?), string _owningbusinessunitValue = default(string), string _rollupquerycustomintegeridValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _rollupqueryinprogressintegeridValue = default(string), string _createdbyValue = default(string), int? inprogressinteger = default(int?), string entityimageUrl = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _rollupqueryactualintegeridValue = default(string), int? fiscalperiod = default(int?), string _modifiedbyValue = default(string), bool? isoverridden = default(bool?), string title = default(string), System.DateTimeOffset? goalenddate = default(System.DateTimeOffset?), string _owningteamValue = default(string), string _rollupqueryactualdecimalidValue = default(string), string _rollupqueryactualmoneyidValue = default(string), decimal? exchangerate = default(decimal?), decimal? inprogressdecimal = default(decimal?), bool? consideronlygoalownersrecords = default(bool?), int? computedtargetasoftodayinteger = default(int?), string goalid = default(string), string entityimageid = default(string), decimal? targetdecimal = default(decimal?), decimal? computedtargetasoftodaymoney = default(decimal?), bool? isamount = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), byte[] entityimage = default(byte[]), int? actualinteger = default(int?), decimal? customrollupfieldmoney = default(decimal?), string versionnumber = default(string), long? entityimageTimestamp = default(long?), string _owneridValue = default(string), decimal? percentage = default(decimal?), string actualstring = default(string), decimal? customrollupfieldmoneyBase = default(decimal?), int? stretchtargetinteger = default(int?), System.DateTimeOffset? lastrolledupdate = default(System.DateTimeOffset?), int? statuscode = default(int?), decimal? computedtargetasoftodaymoneyBase = default(decimal?), string _modifiedonbehalfbyValue = default(string), int? targetinteger = default(int?), decimal? actualmoney = default(decimal?), string inprogressstring = default(string), System.DateTimeOffset? goalstartdate = default(System.DateTimeOffset?), decimal? inprogressmoneyBase = default(decimal?), string targetstring = default(string), int? timezoneruleversionnumber = default(int?), bool? isoverride = default(bool?), string _goalowneridValue = default(string), string _rollupquerycustommoneyidValue = default(string), string _owninguserValue = default(string), decimal? targetmoney = default(decimal?), string _transactioncurrencyidValue = default(string), string _rollupqueryinprogressdecimalidValue = default(string), int? statecode = default(int?), decimal? stretchtargetmoney = default(decimal?), int? importsequencenumber = default(int?), string treeid = default(string), string _goalwitherroridValue = default(string), decimal? actualmoneyBase = default(decimal?), bool? rolluponlyfromchildgoals = default(bool?), bool? isfiscalperiodgoal = default(bool?), decimal? actualdecimal = default(decimal?), string customrollupfieldstring = default(string), string _rollupqueryinprogressmoneyidValue = default(string), string _rollupquerycustomdecimalidValue = default(string), int? utcconversiontimezonecode = default(int?), decimal? stretchtargetmoneyBase = default(decimal?), string _metricidValue = default(string), decimal? computedtargetasoftodaydecimal = default(decimal?), string _createdonbehalfbyValue = default(string), decimal? customrollupfielddecimal = default(decimal?), int? fiscalyear = default(int?), decimal? stretchtargetdecimal = default(decimal?), decimal? targetmoneyBase = default(decimal?), decimal? inprogressmoney = default(decimal?), int? depth = default(int?), int? rolluperrorcode = default(int?), string _parentgoalidValue = default(string), int? customrollupfieldinteger = default(int?), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMgoalrollupquery rollupqueryactualintegerid = default(MicrosoftDynamicsCRMgoalrollupquery), MicrosoftDynamicsCRMgoalrollupquery rollupqueryactualmoneyid = default(MicrosoftDynamicsCRMgoalrollupquery), MicrosoftDynamicsCRMgoalrollupquery rollupqueryactualdecimalid = default(MicrosoftDynamicsCRMgoalrollupquery), MicrosoftDynamicsCRMgoalrollupquery rollupquerycustomintegerid = default(MicrosoftDynamicsCRMgoalrollupquery), MicrosoftDynamicsCRMgoalrollupquery rollupquerycustommoneyid = default(MicrosoftDynamicsCRMgoalrollupquery), MicrosoftDynamicsCRMgoalrollupquery rollupquerycustomdecimalid = default(MicrosoftDynamicsCRMgoalrollupquery), MicrosoftDynamicsCRMgoalrollupquery rollupqueryinprogressintegerid = default(MicrosoftDynamicsCRMgoalrollupquery), MicrosoftDynamicsCRMgoalrollupquery rollupqueryinprogressmoneyid = default(MicrosoftDynamicsCRMgoalrollupquery), MicrosoftDynamicsCRMgoalrollupquery rollupqueryinprogressdecimalid = default(MicrosoftDynamicsCRMgoalrollupquery), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser goalowneridSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMgoal parentgoalid = default(MicrosoftDynamicsCRMgoal), IList<MicrosoftDynamicsCRMgoal> goalParentGoal = default(IList<MicrosoftDynamicsCRMgoal>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMmetric metricid = default(MicrosoftDynamicsCRMmetric), IList<MicrosoftDynamicsCRMduplicaterecord> goalDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMgoal goalwitherrorid = default(MicrosoftDynamicsCRMgoal), IList<MicrosoftDynamicsCRMgoal> goalRollupErrorGoal = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMconnection> goalConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMsyncerror> goalSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMannotation> goalAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMconnection> goalConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMasyncoperation> goalAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMduplicaterecord> goalDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMprocesssession> goalProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> goalPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMteam goalowneridTeam = default(MicrosoftDynamicsCRMteam))
        {
            Computedtargetasoftodaypercentageachieved = computedtargetasoftodaypercentageachieved;
            Stretchtargetstring = stretchtargetstring;
            Amountdatatype = amountdatatype;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._rollupquerycustomintegeridValue = _rollupquerycustomintegeridValue;
            Createdon = createdon;
            this._rollupqueryinprogressintegeridValue = _rollupqueryinprogressintegeridValue;
            this._createdbyValue = _createdbyValue;
            Inprogressinteger = inprogressinteger;
            EntityimageUrl = entityimageUrl;
            Overriddencreatedon = overriddencreatedon;
            this._rollupqueryactualintegeridValue = _rollupqueryactualintegeridValue;
            Fiscalperiod = fiscalperiod;
            this._modifiedbyValue = _modifiedbyValue;
            Isoverridden = isoverridden;
            Title = title;
            Goalenddate = goalenddate;
            this._owningteamValue = _owningteamValue;
            this._rollupqueryactualdecimalidValue = _rollupqueryactualdecimalidValue;
            this._rollupqueryactualmoneyidValue = _rollupqueryactualmoneyidValue;
            Exchangerate = exchangerate;
            Inprogressdecimal = inprogressdecimal;
            Consideronlygoalownersrecords = consideronlygoalownersrecords;
            Computedtargetasoftodayinteger = computedtargetasoftodayinteger;
            Goalid = goalid;
            Entityimageid = entityimageid;
            Targetdecimal = targetdecimal;
            Computedtargetasoftodaymoney = computedtargetasoftodaymoney;
            Isamount = isamount;
            Modifiedon = modifiedon;
            Entityimage = entityimage;
            Actualinteger = actualinteger;
            Customrollupfieldmoney = customrollupfieldmoney;
            Versionnumber = versionnumber;
            EntityimageTimestamp = entityimageTimestamp;
            this._owneridValue = _owneridValue;
            Percentage = percentage;
            Actualstring = actualstring;
            CustomrollupfieldmoneyBase = customrollupfieldmoneyBase;
            Stretchtargetinteger = stretchtargetinteger;
            Lastrolledupdate = lastrolledupdate;
            Statuscode = statuscode;
            ComputedtargetasoftodaymoneyBase = computedtargetasoftodaymoneyBase;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Targetinteger = targetinteger;
            Actualmoney = actualmoney;
            Inprogressstring = inprogressstring;
            Goalstartdate = goalstartdate;
            InprogressmoneyBase = inprogressmoneyBase;
            Targetstring = targetstring;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Isoverride = isoverride;
            this._goalowneridValue = _goalowneridValue;
            this._rollupquerycustommoneyidValue = _rollupquerycustommoneyidValue;
            this._owninguserValue = _owninguserValue;
            Targetmoney = targetmoney;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._rollupqueryinprogressdecimalidValue = _rollupqueryinprogressdecimalidValue;
            Statecode = statecode;
            Stretchtargetmoney = stretchtargetmoney;
            Importsequencenumber = importsequencenumber;
            Treeid = treeid;
            this._goalwitherroridValue = _goalwitherroridValue;
            ActualmoneyBase = actualmoneyBase;
            Rolluponlyfromchildgoals = rolluponlyfromchildgoals;
            Isfiscalperiodgoal = isfiscalperiodgoal;
            Actualdecimal = actualdecimal;
            Customrollupfieldstring = customrollupfieldstring;
            this._rollupqueryinprogressmoneyidValue = _rollupqueryinprogressmoneyidValue;
            this._rollupquerycustomdecimalidValue = _rollupquerycustomdecimalidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            StretchtargetmoneyBase = stretchtargetmoneyBase;
            this._metricidValue = _metricidValue;
            Computedtargetasoftodaydecimal = computedtargetasoftodaydecimal;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Customrollupfielddecimal = customrollupfielddecimal;
            Fiscalyear = fiscalyear;
            Stretchtargetdecimal = stretchtargetdecimal;
            TargetmoneyBase = targetmoneyBase;
            Inprogressmoney = inprogressmoney;
            Depth = depth;
            Rolluperrorcode = rolluperrorcode;
            this._parentgoalidValue = _parentgoalidValue;
            Customrollupfieldinteger = customrollupfieldinteger;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Rollupqueryactualintegerid = rollupqueryactualintegerid;
            Rollupqueryactualmoneyid = rollupqueryactualmoneyid;
            Rollupqueryactualdecimalid = rollupqueryactualdecimalid;
            Rollupquerycustomintegerid = rollupquerycustomintegerid;
            Rollupquerycustommoneyid = rollupquerycustommoneyid;
            Rollupquerycustomdecimalid = rollupquerycustomdecimalid;
            Rollupqueryinprogressintegerid = rollupqueryinprogressintegerid;
            Rollupqueryinprogressmoneyid = rollupqueryinprogressmoneyid;
            Rollupqueryinprogressdecimalid = rollupqueryinprogressdecimalid;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningbusinessunit = owningbusinessunit;
            GoalowneridSystemuser = goalowneridSystemuser;
            Parentgoalid = parentgoalid;
            GoalParentGoal = goalParentGoal;
            Transactioncurrencyid = transactioncurrencyid;
            Metricid = metricid;
            GoalDuplicateMatchingRecord = goalDuplicateMatchingRecord;
            Goalwitherrorid = goalwitherrorid;
            GoalRollupErrorGoal = goalRollupErrorGoal;
            GoalConnections2 = goalConnections2;
            GoalSyncErrors = goalSyncErrors;
            GoalAnnotation = goalAnnotation;
            GoalConnections1 = goalConnections1;
            GoalAsyncOperations = goalAsyncOperations;
            GoalDuplicateBaseRecord = goalDuplicateBaseRecord;
            GoalProcessSessions = goalProcessSessions;
            GoalPrincipalobjectattributeaccess = goalPrincipalobjectattributeaccess;
            GoalowneridTeam = goalowneridTeam;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "computedtargetasoftodaypercentageachieved")]
        public decimal? Computedtargetasoftodaypercentageachieved { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stretchtargetstring")]
        public string Stretchtargetstring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amountdatatype")]
        public int? Amountdatatype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rollupquerycustomintegerid_value")]
        public string _rollupquerycustomintegeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rollupqueryinprogressintegerid_value")]
        public string _rollupqueryinprogressintegeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inprogressinteger")]
        public int? Inprogressinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rollupqueryactualintegerid_value")]
        public string _rollupqueryactualintegeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fiscalperiod")]
        public int? Fiscalperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isoverridden")]
        public bool? Isoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalenddate")]
        public System.DateTimeOffset? Goalenddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rollupqueryactualdecimalid_value")]
        public string _rollupqueryactualdecimalidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rollupqueryactualmoneyid_value")]
        public string _rollupqueryactualmoneyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inprogressdecimal")]
        public decimal? Inprogressdecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "consideronlygoalownersrecords")]
        public bool? Consideronlygoalownersrecords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "computedtargetasoftodayinteger")]
        public int? Computedtargetasoftodayinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalid")]
        public string Goalid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetdecimal")]
        public decimal? Targetdecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "computedtargetasoftodaymoney")]
        public decimal? Computedtargetasoftodaymoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isamount")]
        public bool? Isamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualinteger")]
        public int? Actualinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customrollupfieldmoney")]
        public decimal? Customrollupfieldmoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "percentage")]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualstring")]
        public string Actualstring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customrollupfieldmoney_base")]
        public decimal? CustomrollupfieldmoneyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stretchtargetinteger")]
        public int? Stretchtargetinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastrolledupdate")]
        public System.DateTimeOffset? Lastrolledupdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "computedtargetasoftodaymoney_base")]
        public decimal? ComputedtargetasoftodaymoneyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetinteger")]
        public int? Targetinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualmoney")]
        public decimal? Actualmoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inprogressstring")]
        public string Inprogressstring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalstartdate")]
        public System.DateTimeOffset? Goalstartdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inprogressmoney_base")]
        public decimal? InprogressmoneyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetstring")]
        public string Targetstring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isoverride")]
        public bool? Isoverride { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_goalownerid_value")]
        public string _goalowneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rollupquerycustommoneyid_value")]
        public string _rollupquerycustommoneyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetmoney")]
        public decimal? Targetmoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rollupqueryinprogressdecimalid_value")]
        public string _rollupqueryinprogressdecimalidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stretchtargetmoney")]
        public decimal? Stretchtargetmoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "treeid")]
        public string Treeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_goalwitherrorid_value")]
        public string _goalwitherroridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualmoney_base")]
        public decimal? ActualmoneyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rolluponlyfromchildgoals")]
        public bool? Rolluponlyfromchildgoals { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isfiscalperiodgoal")]
        public bool? Isfiscalperiodgoal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualdecimal")]
        public decimal? Actualdecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customrollupfieldstring")]
        public string Customrollupfieldstring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rollupqueryinprogressmoneyid_value")]
        public string _rollupqueryinprogressmoneyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rollupquerycustomdecimalid_value")]
        public string _rollupquerycustomdecimalidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stretchtargetmoney_base")]
        public decimal? StretchtargetmoneyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_metricid_value")]
        public string _metricidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "computedtargetasoftodaydecimal")]
        public decimal? Computedtargetasoftodaydecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customrollupfielddecimal")]
        public decimal? Customrollupfielddecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fiscalyear")]
        public int? Fiscalyear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stretchtargetdecimal")]
        public decimal? Stretchtargetdecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetmoney_base")]
        public decimal? TargetmoneyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inprogressmoney")]
        public decimal? Inprogressmoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rolluperrorcode")]
        public int? Rolluperrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentgoalid_value")]
        public string _parentgoalidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customrollupfieldinteger")]
        public int? Customrollupfieldinteger { get; set; }

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
        [JsonProperty(PropertyName = "rollupqueryactualintegerid")]
        public MicrosoftDynamicsCRMgoalrollupquery Rollupqueryactualintegerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rollupqueryactualmoneyid")]
        public MicrosoftDynamicsCRMgoalrollupquery Rollupqueryactualmoneyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rollupqueryactualdecimalid")]
        public MicrosoftDynamicsCRMgoalrollupquery Rollupqueryactualdecimalid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rollupquerycustomintegerid")]
        public MicrosoftDynamicsCRMgoalrollupquery Rollupquerycustomintegerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rollupquerycustommoneyid")]
        public MicrosoftDynamicsCRMgoalrollupquery Rollupquerycustommoneyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rollupquerycustomdecimalid")]
        public MicrosoftDynamicsCRMgoalrollupquery Rollupquerycustomdecimalid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rollupqueryinprogressintegerid")]
        public MicrosoftDynamicsCRMgoalrollupquery Rollupqueryinprogressintegerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rollupqueryinprogressmoneyid")]
        public MicrosoftDynamicsCRMgoalrollupquery Rollupqueryinprogressmoneyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rollupqueryinprogressdecimalid")]
        public MicrosoftDynamicsCRMgoalrollupquery Rollupqueryinprogressdecimalid { get; set; }

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
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalownerid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser GoalowneridSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentgoalid")]
        public MicrosoftDynamicsCRMgoal Parentgoalid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_parent_goal")]
        public IList<MicrosoftDynamicsCRMgoal> GoalParentGoal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metricid")]
        public MicrosoftDynamicsCRMmetric Metricid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Goal_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> GoalDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalwitherrorid")]
        public MicrosoftDynamicsCRMgoal Goalwitherrorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Goal_RollupError_Goal")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupErrorGoal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> GoalConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Goal_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> GoalSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Goal_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> GoalAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> GoalConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Goal_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> GoalAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Goal_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> GoalDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Goal_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> GoalProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> GoalPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalownerid_team")]
        public MicrosoftDynamicsCRMteam GoalowneridTeam { get; set; }

    }
}
