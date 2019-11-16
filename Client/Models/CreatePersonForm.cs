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

    public partial class CreatePersonForm
    {
        /// <summary>
        /// Initializes a new instance of the CreatePersonForm class.
        /// </summary>
        public CreatePersonForm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreatePersonForm class.
        /// </summary>
        /// <param name="dob">Patient's DOB (mm/dd/yyyy)</param>
        /// <param name="address1">Patient's address - 1st line (Max length:
        /// 100)</param>
        /// <param name="address2">Patient's address - 2nd line (Max length:
        /// 100)</param>
        /// <param name="city">Patient's city (Max length: 30)</param>
        /// <param name="departmentid">Primary (registration) department
        /// ID.</param>
        /// <param name="email">Patient's email address. 'declined' can be used
        /// to indicate just that.</param>
        /// <param name="firstname">Patient's first name</param>
        public CreatePersonForm(string dob, string address1 = default(string), string address2 = default(string), string city = default(string), int? departmentid = default(int?), string email = default(string), string firstname = default(string))
        {
            Address1 = address1;
            Address2 = address2;
            City = city;
            Departmentid = departmentid;
            Dob = dob;
            Email = email;
            Firstname = firstname;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets patient's address - 1st line (Max length: 100)
        /// </summary>
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets patient's address - 2nd line (Max length: 100)
        /// </summary>
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets patient's city (Max length: 30)
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets primary (registration) department ID.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int? Departmentid { get; set; }

        /// <summary>
        /// Gets or sets patient's DOB (mm/dd/yyyy)
        /// </summary>
        [JsonProperty(PropertyName = "dob")]
        public string Dob { get; set; }

        /// <summary>
        /// Gets or sets patient's email address. 'declined' can be used to
        /// indicate just that.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets patient's first name
        /// </summary>
        [JsonProperty(PropertyName = "firstname")]
        public string Firstname { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Dob == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dob");
            }
        }
    }
}
