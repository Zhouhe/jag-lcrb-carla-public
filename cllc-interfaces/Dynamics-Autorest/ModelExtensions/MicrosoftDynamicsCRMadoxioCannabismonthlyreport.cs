namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;

    public partial class MicrosoftDynamicsCRMadoxioCannabismonthlyreport
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_csvexportid")]
        public int AdoxioCsvexportid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishmentnametext")]
        public string AdoxioEstablishmentnametext { get; set; }
    }
}
