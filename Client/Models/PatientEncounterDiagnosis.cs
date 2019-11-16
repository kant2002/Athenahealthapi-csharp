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

    public partial class PatientEncounterDiagnosis
    {
        /// <summary>
        /// Initializes a new instance of the PatientEncounterDiagnosis class.
        /// </summary>
        public PatientEncounterDiagnosis()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatientEncounterDiagnosis class.
        /// </summary>
        /// <param name="diagnosisid">Athena ID for this diagnosis</param>
        /// <param name="icdcodes">message</param>
        /// <param name="snomedcode">SNOMED Code for this diagnosis</param>
        /// <param name="note">The note entered for this diagnosis.</param>
        /// <param name="description">Brief description for this SNOMED
        /// Code</param>
        public PatientEncounterDiagnosis(int diagnosisid, IList<CodeInformation> icdcodes = default(IList<CodeInformation>), int? snomedcode = default(int?), string note = default(string), string description = default(string))
        {
            Diagnosisid = diagnosisid;
            Icdcodes = icdcodes;
            Snomedcode = snomedcode;
            Note = note;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets athena ID for this diagnosis
        /// </summary>
        [JsonProperty(PropertyName = "diagnosisid")]
        public int Diagnosisid { get; set; }

        /// <summary>
        /// Gets or sets message
        /// </summary>
        [JsonProperty(PropertyName = "icdcodes")]
        public IList<CodeInformation> Icdcodes { get; set; }

        /// <summary>
        /// Gets or sets SNOMED Code for this diagnosis
        /// </summary>
        [JsonProperty(PropertyName = "snomedcode")]
        public int? Snomedcode { get; set; }

        /// <summary>
        /// Gets or sets the note entered for this diagnosis.
        /// </summary>
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets brief description for this SNOMED Code
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Icdcodes != null)
            {
                foreach (var element in Icdcodes)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
