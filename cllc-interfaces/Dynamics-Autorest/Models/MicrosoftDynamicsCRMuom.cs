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
    /// Microsoft.Dynamics.CRM.uom
    /// </summary>
    public partial class MicrosoftDynamicsCRMuom
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuom class.
        /// </summary>
        public MicrosoftDynamicsCRMuom()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuom class.
        /// </summary>
        public MicrosoftDynamicsCRMuom(bool? isschedulebaseuom = default(bool?), string organizationid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), decimal? quantity = default(decimal?), string _createdbyexternalpartyValue = default(string), string _uomscheduleidValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _baseuomValue = default(string), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), string versionnumber = default(string), string name = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string uomid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedbyexternalpartyValue = default(string), string _createdbyValue = default(string), IList<MicrosoftDynamicsCRMteam> uomTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> uomMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> uomPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMproductpricelevel> unitOfMeasurementProductPriceLevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>), MicrosoftDynamicsCRMuomschedule uomscheduleid = default(MicrosoftDynamicsCRMuomschedule), IList<MicrosoftDynamicsCRMproduct> unitOfMeasurementProducts = default(IList<MicrosoftDynamicsCRMproduct>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMuom baseuom = default(MicrosoftDynamicsCRMuom), IList<MicrosoftDynamicsCRMuom> unitOfMeasurementBaseUnit = default(IList<MicrosoftDynamicsCRMuom>), IList<MicrosoftDynamicsCRMproductassociation> unitOfMeasurementProductassociation = default(IList<MicrosoftDynamicsCRMproductassociation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> uoMBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> uoMSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> uoMAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMcontractdetail> unitOfMeasurementContractLineItems = default(IList<MicrosoftDynamicsCRMcontractdetail>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMinvoicedetail> unitOfMeasurementInvoiceDetails = default(IList<MicrosoftDynamicsCRMinvoicedetail>), IList<MicrosoftDynamicsCRMquotedetail> unitOfMeasurementQuoteDetails = default(IList<MicrosoftDynamicsCRMquotedetail>), IList<MicrosoftDynamicsCRMsalesorderdetail> unitOfMeasurementOrderDetails = default(IList<MicrosoftDynamicsCRMsalesorderdetail>), IList<MicrosoftDynamicsCRMopportunityproduct> unitOfMeasurementOpportunityProducts = default(IList<MicrosoftDynamicsCRMopportunityproduct>))
        {
            Isschedulebaseuom = isschedulebaseuom;
            Organizationid = organizationid;
            Createdon = createdon;
            Quantity = quantity;
            this._createdbyexternalpartyValue = _createdbyexternalpartyValue;
            this._uomscheduleidValue = _uomscheduleidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._baseuomValue = _baseuomValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Versionnumber = versionnumber;
            Name = name;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            Uomid = uomid;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedbyexternalpartyValue = _modifiedbyexternalpartyValue;
            this._createdbyValue = _createdbyValue;
            UomTeams = uomTeams;
            UomMailboxTrackingFolders = uomMailboxTrackingFolders;
            UomPrincipalObjectAttributeAccesses = uomPrincipalObjectAttributeAccesses;
            UnitOfMeasurementProductPriceLevels = unitOfMeasurementProductPriceLevels;
            Uomscheduleid = uomscheduleid;
            UnitOfMeasurementProducts = unitOfMeasurementProducts;
            Createdonbehalfby = createdonbehalfby;
            Baseuom = baseuom;
            UnitOfMeasurementBaseUnit = unitOfMeasurementBaseUnit;
            UnitOfMeasurementProductassociation = unitOfMeasurementProductassociation;
            Modifiedonbehalfby = modifiedonbehalfby;
            UoMBulkDeleteFailures = uoMBulkDeleteFailures;
            UoMSyncErrors = uoMSyncErrors;
            UoMAsyncOperations = uoMAsyncOperations;
            Createdby = createdby;
            UnitOfMeasurementContractLineItems = unitOfMeasurementContractLineItems;
            Modifiedby = modifiedby;
            UnitOfMeasurementInvoiceDetails = unitOfMeasurementInvoiceDetails;
            UnitOfMeasurementQuoteDetails = unitOfMeasurementQuoteDetails;
            UnitOfMeasurementOrderDetails = unitOfMeasurementOrderDetails;
            UnitOfMeasurementOpportunityProducts = unitOfMeasurementOpportunityProducts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isschedulebaseuom")]
        public bool? Isschedulebaseuom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdbyexternalparty_value")]
        public string _createdbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomscheduleid_value")]
        public string _uomscheduleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_baseuom_value")]
        public string _baseuomValue { get; set; }

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
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
        [JsonProperty(PropertyName = "uomid")]
        public string Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedbyexternalparty_value")]
        public string _modifiedbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uom_Teams")]
        public IList<MicrosoftDynamicsCRMteam> UomTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uom_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> UomMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uom_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> UomPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_product_price_levels")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> UnitOfMeasurementProductPriceLevels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomscheduleid")]
        public MicrosoftDynamicsCRMuomschedule Uomscheduleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_products")]
        public IList<MicrosoftDynamicsCRMproduct> UnitOfMeasurementProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseuom")]
        public MicrosoftDynamicsCRMuom Baseuom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_base_unit")]
        public IList<MicrosoftDynamicsCRMuom> UnitOfMeasurementBaseUnit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_productassociation")]
        public IList<MicrosoftDynamicsCRMproductassociation> UnitOfMeasurementProductassociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UoM_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> UoMBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UoM_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> UoMSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UoM_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> UoMAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_contract_line_items")]
        public IList<MicrosoftDynamicsCRMcontractdetail> UnitOfMeasurementContractLineItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_invoice_details")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> UnitOfMeasurementInvoiceDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_quote_details")]
        public IList<MicrosoftDynamicsCRMquotedetail> UnitOfMeasurementQuoteDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_order_details")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> UnitOfMeasurementOrderDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_opportunity_products")]
        public IList<MicrosoftDynamicsCRMopportunityproduct> UnitOfMeasurementOpportunityProducts { get; set; }

    }
}
