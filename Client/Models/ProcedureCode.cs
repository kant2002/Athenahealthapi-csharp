// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.AuthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProcedureCode
    {
        /// <summary>
        /// Initializes a new instance of the ProcedureCode class.
        /// </summary>
        public ProcedureCode()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProcedureCode class.
        /// </summary>
        /// <param name="procedurecode">The ID of the code.</param>
        /// <param name="procedurecodedescription">The description of the
        /// code.</param>
        public ProcedureCode(string procedurecode = default(string), string procedurecodedescription = default(string))
        {
            Procedurecode = procedurecode;
            Procedurecodedescription = procedurecodedescription;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the code.
        /// </summary>
        [JsonProperty(PropertyName = "procedurecode")]
        public string Procedurecode { get; set; }

        /// <summary>
        /// Gets or sets the description of the code.
        /// </summary>
        [JsonProperty(PropertyName = "procedurecodedescription")]
        public string Procedurecodedescription { get; set; }

    }
}
