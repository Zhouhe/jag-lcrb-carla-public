// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMcontactorders
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactorders
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactorders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactorders
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactorders(string contactid = default(string), string contactorderid = default(string), string salesorderid = default(string), object versionnumber = default(object))
        {
            Contactid = contactid;
            Contactorderid = contactorderid;
            Salesorderid = salesorderid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactid")]
        public string Contactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactorderid")]
        public string Contactorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public string Salesorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
