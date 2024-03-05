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
    /// Microsoft.Dynamics.CRM.pricelevel
    /// </summary>
    public partial class MicrosoftDynamicsCRMpricelevel
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpricelevel
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpricelevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpricelevel
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpricelevel(int? statecode = default(int?), int? shippingmethodcode = default(int?), decimal? exchangerate = default(decimal?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? begindate = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string _organizationidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? enddate = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), int? paymentmethodcode = default(int?), string versionnumber = default(string), int? freighttermscode = default(int?), string name = default(string), int? statuscode = default(int?), string description = default(string), string _modifiedonbehalfbyValue = default(string), string pricelevelid = default(string), IList<MicrosoftDynamicsCRMcampaign> priceListCampaigns = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMteam> pricelevelTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> pricelevelMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> pricelevelConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMproduct> priceLevelProducts = default(IList<MicrosoftDynamicsCRMproduct>), IList<MicrosoftDynamicsCRMproductpricelevel> priceLevelProductPriceLevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> priceLevelSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> pricelevelPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMbulkdeletefailure> priceLevelBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMaccount> priceLevelAccounts = default(IList<MicrosoftDynamicsCRMaccount>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMcontact> priceLevelContacts = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMprocesssession> priceLevelProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMasyncoperation> priceLevelAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMconnection> pricelevelConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMquote> priceLevelQuotes = default(IList<MicrosoftDynamicsCRMquote>), IList<MicrosoftDynamicsCRMsalesorder> priceLevelOrders = default(IList<MicrosoftDynamicsCRMsalesorder>), IList<MicrosoftDynamicsCRMopportunity> priceLevelOpportunties = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMinvoice> priceLevelInvoices = default(IList<MicrosoftDynamicsCRMinvoice>))
        {
            Statecode = statecode;
            Shippingmethodcode = shippingmethodcode;
            Exchangerate = exchangerate;
            Modifiedon = modifiedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Begindate = begindate;
            Importsequencenumber = importsequencenumber;
            this._organizationidValue = _organizationidValue;
            Overriddencreatedon = overriddencreatedon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Enddate = enddate;
            this._createdbyValue = _createdbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdon = createdon;
            this._modifiedbyValue = _modifiedbyValue;
            Paymentmethodcode = paymentmethodcode;
            Versionnumber = versionnumber;
            Freighttermscode = freighttermscode;
            Name = name;
            Statuscode = statuscode;
            Description = description;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Pricelevelid = pricelevelid;
            PriceListCampaigns = priceListCampaigns;
            PricelevelTeams = pricelevelTeams;
            PricelevelMailboxTrackingFolders = pricelevelMailboxTrackingFolders;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            PricelevelConnections2 = pricelevelConnections2;
            PriceLevelProducts = priceLevelProducts;
            PriceLevelProductPriceLevels = priceLevelProductPriceLevels;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Transactioncurrencyid = transactioncurrencyid;
            PriceLevelSyncErrors = priceLevelSyncErrors;
            PricelevelPrincipalobjectattributeaccess = pricelevelPrincipalobjectattributeaccess;
            PriceLevelBulkDeleteFailures = priceLevelBulkDeleteFailures;
            PriceLevelAccounts = priceLevelAccounts;
            Organizationid = organizationid;
            PriceLevelContacts = priceLevelContacts;
            PriceLevelProcessSessions = priceLevelProcessSessions;
            PriceLevelAsyncOperations = priceLevelAsyncOperations;
            PricelevelConnections1 = pricelevelConnections1;
            PriceLevelQuotes = priceLevelQuotes;
            PriceLevelOrders = priceLevelOrders;
            PriceLevelOpportunties = priceLevelOpportunties;
            PriceLevelInvoices = priceLevelInvoices;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "begindate")]
        public System.DateTimeOffset? Begindate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enddate")]
        public System.DateTimeOffset? Enddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymentmethodcode")]
        public int? Paymentmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freighttermscode")]
        public int? Freighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public string Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceList_Campaigns")]
        public IList<MicrosoftDynamicsCRMcampaign> PriceListCampaigns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevel_Teams")]
        public IList<MicrosoftDynamicsCRMteam> PricelevelTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevel_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> PricelevelMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevel_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> PricelevelConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_products")]
        public IList<MicrosoftDynamicsCRMproduct> PriceLevelProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_product_price_levels")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> PriceLevelProductPriceLevels { get; set; }

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
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceLevel_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> PriceLevelSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevel_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PricelevelPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceLevel_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> PriceLevelBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_accounts")]
        public IList<MicrosoftDynamicsCRMaccount> PriceLevelAccounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_contacts")]
        public IList<MicrosoftDynamicsCRMcontact> PriceLevelContacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceLevel_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> PriceLevelProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceLevel_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> PriceLevelAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevel_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> PricelevelConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_quotes")]
        public IList<MicrosoftDynamicsCRMquote> PriceLevelQuotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_orders")]
        public IList<MicrosoftDynamicsCRMsalesorder> PriceLevelOrders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_opportunties")]
        public IList<MicrosoftDynamicsCRMopportunity> PriceLevelOpportunties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_invoices")]
        public IList<MicrosoftDynamicsCRMinvoice> PriceLevelInvoices { get; set; }

    }
}
