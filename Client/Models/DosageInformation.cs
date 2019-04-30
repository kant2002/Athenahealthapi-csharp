// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.AuthenaHealth.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DosageInformation
    {
        /// <summary>
        /// Initializes a new instance of the DosageInformation class.
        /// </summary>
        public DosageInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DosageInformation class.
        /// </summary>
        /// <param name="dosageaction">How the medication is taken. Examples
        /// are Chew, Take, Inhale, etc.</param>
        /// <param name="dosagequantityvalue">How many of this med is
        /// taken.</param>
        /// <param name="dosagequantityunit">The unit of the quantity. Example:
        /// tablets, sprays, etc.
        /// </param>
        /// <param name="dosagefrequencyvalue">How many times (in the given
        /// time unit) this should be taken.</param>
        /// <param name="dosagefrequencyunit">The unit of the frequency.
        /// Example: per day, per week.
        /// </param>
        /// <param name="dosagefrequencydescription">A standardized
        /// patient-friendly frequency. Example: 6 per day becomes "every 4
        /// hours".
        /// </param>
        /// <param name="dosageroute">How this medication is taken. Example:
        /// oral, inhalation, intranasal, etc.
        /// </param>
        /// <param name="dosageadditionalinstructions">Additional instructions.
        /// Example: with meals
        /// </param>
        /// <param name="dosagedurationvalue">How many duration time units this
        /// medication should be taken for.</param>
        /// <param name="dosagedurationunit">The unit of the duration. Example:
        /// days. So take this for days.
        /// </param>
        public DosageInformation(string dosageaction, int dosagequantityvalue, string dosagequantityunit, int? dosagefrequencyvalue = default(int?), string dosagefrequencyunit = default(string), string dosagefrequencydescription = default(string), string dosageroute = default(string), string dosageadditionalinstructions = default(string), int? dosagedurationvalue = default(int?), string dosagedurationunit = default(string))
        {
            Dosageaction = dosageaction;
            Dosagequantityvalue = dosagequantityvalue;
            Dosagequantityunit = dosagequantityunit;
            Dosagefrequencyvalue = dosagefrequencyvalue;
            Dosagefrequencyunit = dosagefrequencyunit;
            Dosagefrequencydescription = dosagefrequencydescription;
            Dosageroute = dosageroute;
            Dosageadditionalinstructions = dosageadditionalinstructions;
            Dosagedurationvalue = dosagedurationvalue;
            Dosagedurationunit = dosagedurationunit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets how the medication is taken. Examples are Chew, Take,
        /// Inhale, etc.
        /// </summary>
        [JsonProperty(PropertyName = "dosageaction")]
        public string Dosageaction { get; set; }

        /// <summary>
        /// Gets or sets how many of this med is taken.
        /// </summary>
        [JsonProperty(PropertyName = "dosagequantityvalue")]
        public int Dosagequantityvalue { get; set; }

        /// <summary>
        /// Gets or sets the unit of the quantity. Example: tablets, sprays,
        /// etc.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "dosagequantityunit")]
        public string Dosagequantityunit { get; set; }

        /// <summary>
        /// Gets or sets how many times (in the given time unit) this should be
        /// taken.
        /// </summary>
        [JsonProperty(PropertyName = "dosagefrequencyvalue")]
        public int? Dosagefrequencyvalue { get; set; }

        /// <summary>
        /// Gets or sets the unit of the frequency. Example: per day, per week.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "dosagefrequencyunit")]
        public string Dosagefrequencyunit { get; set; }

        /// <summary>
        /// Gets or sets a standardized patient-friendly frequency. Example: 6
        /// per day becomes "every 4 hours".
        ///
        /// </summary>
        [JsonProperty(PropertyName = "dosagefrequencydescription")]
        public string Dosagefrequencydescription { get; set; }

        /// <summary>
        /// Gets or sets how this medication is taken. Example: oral,
        /// inhalation, intranasal, etc.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "dosageroute")]
        public string Dosageroute { get; set; }

        /// <summary>
        /// Gets or sets additional instructions. Example: with meals
        ///
        /// </summary>
        [JsonProperty(PropertyName = "dosageadditionalinstructions")]
        public string Dosageadditionalinstructions { get; set; }

        /// <summary>
        /// Gets or sets how many duration time units this medication should be
        /// taken for.
        /// </summary>
        [JsonProperty(PropertyName = "dosagedurationvalue")]
        public int? Dosagedurationvalue { get; set; }

        /// <summary>
        /// Gets or sets the unit of the duration. Example: days. So take this
        /// for days.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "dosagedurationunit")]
        public string Dosagedurationunit { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Dosageaction == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dosageaction");
            }
            if (Dosagequantityunit == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dosagequantityunit");
            }
        }
    }
}