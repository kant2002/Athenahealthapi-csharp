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

    public partial class PatientLabResultDocumentList
    {
        /// <summary>
        /// Initializes a new instance of the PatientLabResultDocumentList
        /// class.
        /// </summary>
        public PatientLabResultDocumentList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatientLabResultDocumentList
        /// class.
        /// </summary>
        /// <param name="labresults">List of lab result documents</param>
        public PatientLabResultDocumentList(int totalCount, IList<PatientLabResultDocument> labresults)
        {
            TotalCount = totalCount;
            Labresults = labresults;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalcount")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets list of lab result documents
        /// </summary>
        [JsonProperty(PropertyName = "labresults")]
        public IList<PatientLabResultDocument> Labresults { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Labresults == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Labresults");
            }
        }
    }
}