// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AthenaHealth.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EncounterAssesmentText
    {
        /// <summary>
        /// Initializes a new instance of the EncounterAssesmentText class.
        /// </summary>
        public EncounterAssesmentText()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncounterAssesmentText class.
        /// </summary>
        /// <param name="lastmodifieddatetime">The datetime that this text was
        /// last updated.</param>
        /// <param name="assessmenttext">The text of the Assessment / Plan
        /// section. Not all practices use this. Some use it extensively with
        /// HTML templates.
        /// </param>
        /// <param name="lastmodifiedby">The username of the user who last
        /// updated this text.</param>
        public EncounterAssesmentText(string lastmodifieddatetime, string assessmenttext, string lastmodifiedby)
        {
            Lastmodifieddatetime = lastmodifieddatetime;
            Assessmenttext = assessmenttext;
            Lastmodifiedby = lastmodifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the datetime that this text was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifieddatetime")]
        public string Lastmodifieddatetime { get; set; }

        /// <summary>
        /// Gets or sets the text of the Assessment / Plan section. Not all
        /// practices use this. Some use it extensively with HTML templates.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "assessmenttext")]
        public string Assessmenttext { get; set; }

        /// <summary>
        /// Gets or sets the username of the user who last updated this text.
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
            if (Lastmodifieddatetime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Lastmodifieddatetime");
            }
            if (Assessmenttext == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Assessmenttext");
            }
            if (Lastmodifiedby == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Lastmodifiedby");
            }
        }
    }
}
