// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.AuthenaHealth.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PatientProblem
    {
        /// <summary>
        /// Initializes a new instance of the PatientProblem class.
        /// </summary>
        public PatientProblem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatientProblem class.
        /// </summary>
        /// <param name="events">List of start and stop events for this
        /// problem, which can occur multiple times.</param>
        /// <param name="deactivateddate">Date of problem deactivation.</param>
        /// <param name="deactivateduser">The name of the user who deactivated
        /// the problem.</param>
        /// <param name="problemid">Athena ID for this problem</param>
        /// <param name="name">Problem name</param>
        /// <param name="code">Problem code</param>
        /// <param name="codeset">Problem codeset (SNOMED, ICD9, ICD10,
        /// etc)</param>
        /// <param name="bestmatchicd10code">If this was added from the chart
        /// or from an encounter without a selected ICD10 code, and if the
        /// primary codeset is SNOMED,  then this contains the best matching
        /// ICD10 code mapped. Because SNOMED to ICD10 is a many to many map,
        /// this will tend to give  the most generic diagnosis.
        /// </param>
        /// <param name="mostrecentdiagnosisnote">The most recent diagnosis
        /// note</param>
        /// <param name="lastmodifieddatetime">The date the problem was last
        /// modified. Currently only date precision.</param>
        /// <param name="lastmodifiedby">The username of the user who last
        /// modified this problem.</param>
        public PatientProblem(IList<PatientProblemEvent> events, string deactivateddate = default(string), string deactivateduser = default(string), int? problemid = default(int?), string name = default(string), string code = default(string), string codeset = default(string), string bestmatchicd10code = default(string), string mostrecentdiagnosisnote = default(string), string lastmodifieddatetime = default(string), string lastmodifiedby = default(string))
        {
            Events = events;
            Deactivateddate = deactivateddate;
            Deactivateduser = deactivateduser;
            Problemid = problemid;
            Name = name;
            Code = code;
            Codeset = codeset;
            Bestmatchicd10code = bestmatchicd10code;
            Mostrecentdiagnosisnote = mostrecentdiagnosisnote;
            Lastmodifieddatetime = lastmodifieddatetime;
            Lastmodifiedby = lastmodifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of start and stop events for this problem, which
        /// can occur multiple times.
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<PatientProblemEvent> Events { get; set; }

        /// <summary>
        /// Gets or sets date of problem deactivation.
        /// </summary>
        [JsonProperty(PropertyName = "deactivateddate")]
        public string Deactivateddate { get; set; }

        /// <summary>
        /// Gets or sets the name of the user who deactivated the problem.
        /// </summary>
        [JsonProperty(PropertyName = "deactivateduser")]
        public string Deactivateduser { get; set; }

        /// <summary>
        /// Gets or sets athena ID for this problem
        /// </summary>
        [JsonProperty(PropertyName = "problemid")]
        public int? Problemid { get; set; }

        /// <summary>
        /// Gets or sets problem name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets problem code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets problem codeset (SNOMED, ICD9, ICD10, etc)
        /// </summary>
        [JsonProperty(PropertyName = "codeset")]
        public string Codeset { get; set; }

        /// <summary>
        /// Gets or sets if this was added from the chart or from an encounter
        /// without a selected ICD10 code, and if the primary codeset is
        /// SNOMED,  then this contains the best matching ICD10 code mapped.
        /// Because SNOMED to ICD10 is a many to many map, this will tend to
        /// give  the most generic diagnosis.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "bestmatchicd10code")]
        public string Bestmatchicd10code { get; set; }

        /// <summary>
        /// Gets or sets the most recent diagnosis note
        /// </summary>
        [JsonProperty(PropertyName = "mostrecentdiagnosisnote")]
        public string Mostrecentdiagnosisnote { get; set; }

        /// <summary>
        /// Gets or sets the date the problem was last modified. Currently only
        /// date precision.
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifieddatetime")]
        public string Lastmodifieddatetime { get; set; }

        /// <summary>
        /// Gets or sets the username of the user who last modified this
        /// problem.
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifiedby")]
        public string Lastmodifiedby { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Events == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Events");
            }
        }
    }
}