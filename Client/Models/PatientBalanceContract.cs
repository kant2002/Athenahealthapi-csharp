// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PatientBalanceContract
    {
        /// <summary>
        /// Initializes a new instance of the PatientBalanceContract class.
        /// </summary>
        public PatientBalanceContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatientBalanceContract class.
        /// </summary>
        /// <param name="availablebalance">The available balance on this
        /// contract.</param>
        /// <param name="contractclass">The type of contract. For example,
        /// "ONEYEAR,"</param>
        /// <param name="maxamount">The maximum allowed amount for this
        /// contract.</param>
        public PatientBalanceContract(string availablebalance = default(string), string contractclass = default(string), string maxamount = default(string))
        {
            Availablebalance = availablebalance;
            Contractclass = contractclass;
            Maxamount = maxamount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the available balance on this contract.
        /// </summary>
        [JsonProperty(PropertyName = "availablebalance")]
        public string Availablebalance { get; set; }

        /// <summary>
        /// Gets or sets the type of contract. For example, "ONEYEAR,"
        /// </summary>
        [JsonProperty(PropertyName = "contractclass")]
        public string Contractclass { get; set; }

        /// <summary>
        /// Gets or sets the maximum allowed amount for this contract.
        /// </summary>
        [JsonProperty(PropertyName = "maxamount")]
        public string Maxamount { get; set; }

    }
}
