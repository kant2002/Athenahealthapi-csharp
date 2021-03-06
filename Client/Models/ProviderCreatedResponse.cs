// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProviderCreatedResponse
    {
        /// <summary>
        /// Initializes a new instance of the ProviderCreatedResponse class.
        /// </summary>
        public ProviderCreatedResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderCreatedResponse class.
        /// </summary>
        /// <param name="providerId">The ID to be used for this provider. Note
        /// that in athenaNet, an individual provider (as defined by a unique
        /// NPI) may have multiple provider IDs. For the API, we have collapsed
        /// these to a single canonical ID. For updates and deletes, this will
        /// be either 1 or -1 depending on success or failure.
        /// </param>
        /// <param name="errorreason">Error message if the operation did not
        /// work.</param>
        /// <param name="alertmessage">Alert message if the operation did not
        /// work.</param>
        public ProviderCreatedResponse(int providerId, string errorreason = default(string), string alertmessage = default(string))
        {
            ProviderId = providerId;
            Errorreason = errorreason;
            Alertmessage = alertmessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID to be used for this provider. Note that in
        /// athenaNet, an individual provider (as defined by a unique NPI) may
        /// have multiple provider IDs. For the API, we have collapsed these to
        /// a single canonical ID. For updates and deletes, this will be either
        /// 1 or -1 depending on success or failure.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "providerid")]
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or sets error message if the operation did not work.
        /// </summary>
        [JsonProperty(PropertyName = "errorreason")]
        public string Errorreason { get; set; }

        /// <summary>
        /// Gets or sets alert message if the operation did not work.
        /// </summary>
        [JsonProperty(PropertyName = "alertmessage")]
        public string Alertmessage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
