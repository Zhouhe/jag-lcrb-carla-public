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
    /// StringCollection
    /// </summary>
    public partial class MicrosoftDynamicsCRMStringCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMStringCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMStringCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMStringCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMStringCollection(IList<string> items = default(IList<string>))
        {
            Items = items;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Items")]
        public IList<string> Items { get; set; }

    }
}
