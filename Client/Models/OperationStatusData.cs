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

    public partial class OperationStatusData
    {
        /// <summary>
        /// Initializes a new instance of the OperationStatusData class.
        /// </summary>
        public OperationStatusData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationStatusData class.
        /// </summary>
        /// <param name="status">The status of this appointment after the
        /// operation (generally "x").</param>
        public OperationStatusData(string status)
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status of this appointment after the operation
        /// (generally "x").
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
        }
    }
}
