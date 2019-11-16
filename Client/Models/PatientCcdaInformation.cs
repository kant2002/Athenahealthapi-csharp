// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PatientCcdaInformation
    {
        /// <summary>
        /// Initializes a new instance of the PatientCcdaInformation class.
        /// </summary>
        public PatientCcdaInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatientCcdaInformation class.
        /// </summary>
        /// <param name="ccda">Content of CCDA record for the patient.</param>
        public PatientCcdaInformation(string ccda = default(string))
        {
            Ccda = ccda;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets content of CCDA record for the patient.
        /// </summary>
        [JsonProperty(PropertyName = "ccda")]
        public string Ccda { get; set; }

    }
}
