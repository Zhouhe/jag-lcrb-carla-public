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
    /// Microsoft.Dynamics.CRM.privilege
    /// </summary>
    public partial class MicrosoftDynamicsCRMprivilege
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMprivilege
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMprivilege()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMprivilege
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMprivilege(string privilegerowid = default(string), bool? canbebasic = default(bool?), int? accessright = default(int?), string privilegeid = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? componentstate = default(int?), string solutionid = default(string), bool? canbeentityreference = default(bool?), bool? canbeglobal = default(bool?), bool? canbedeep = default(bool?), string name = default(string), bool? canbeparententityreference = default(bool?), bool? ismanaged = default(bool?), string versionnumber = default(string), string introducedversion = default(string), bool? canbelocal = default(bool?), IList<MicrosoftDynamicsCRMroletemplate> roletemplateprivilegesAssociation = default(IList<MicrosoftDynamicsCRMroletemplate>), IList<MicrosoftDynamicsCRMrole> roleprivilegesAssociation = default(IList<MicrosoftDynamicsCRMrole>), IList<MicrosoftDynamicsCRMasyncoperation> privilegeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> privilegeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsolution solutionPrivilege = default(MicrosoftDynamicsCRMsolution))
        {
            Privilegerowid = privilegerowid;
            Canbebasic = canbebasic;
            Accessright = accessright;
            Privilegeid = privilegeid;
            Overwritetime = overwritetime;
            Componentstate = componentstate;
            Solutionid = solutionid;
            Canbeentityreference = canbeentityreference;
            Canbeglobal = canbeglobal;
            Canbedeep = canbedeep;
            Name = name;
            Canbeparententityreference = canbeparententityreference;
            Ismanaged = ismanaged;
            Versionnumber = versionnumber;
            Introducedversion = introducedversion;
            Canbelocal = canbelocal;
            RoletemplateprivilegesAssociation = roletemplateprivilegesAssociation;
            RoleprivilegesAssociation = roleprivilegesAssociation;
            PrivilegeAsyncOperations = privilegeAsyncOperations;
            PrivilegeBulkDeleteFailures = privilegeBulkDeleteFailures;
            SolutionPrivilege = solutionPrivilege;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "privilegerowid")]
        public string Privilegerowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbebasic")]
        public bool? Canbebasic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accessright")]
        public int? Accessright { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "privilegeid")]
        public string Privilegeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbeentityreference")]
        public bool? Canbeentityreference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbeglobal")]
        public bool? Canbeglobal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbedeep")]
        public bool? Canbedeep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbeparententityreference")]
        public bool? Canbeparententityreference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbelocal")]
        public bool? Canbelocal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roletemplateprivileges_association")]
        public IList<MicrosoftDynamicsCRMroletemplate> RoletemplateprivilegesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleprivileges_association")]
        public IList<MicrosoftDynamicsCRMrole> RoleprivilegesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Privilege_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> PrivilegeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Privilege_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> PrivilegeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solution_privilege")]
        public MicrosoftDynamicsCRMsolution SolutionPrivilege { get; set; }

    }
}
