// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PathsapivariantPracticeidAppointmentsOpenpostresponses200contentapplicationJsonschema
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PathsapivariantPracticeidAppointmentsOpenpostresponses200contentapplicationJsonschema
        /// class.
        /// </summary>
        public PathsapivariantPracticeidAppointmentsOpenpostresponses200contentapplicationJsonschema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PathsapivariantPracticeidAppointmentsOpenpostresponses200contentapplicationJsonschema
        /// class.
        /// </summary>
        public PathsapivariantPracticeidAppointmentsOpenpostresponses200contentapplicationJsonschema(IDictionary<string, string> appointmentids = default(IDictionary<string, string>))
        {
            Appointmentids = appointmentids;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointmentids")]
        public IDictionary<string, string> Appointmentids { get; set; }

    }
}
