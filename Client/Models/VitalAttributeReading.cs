// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class VitalAttributeReading
    {
        /// <summary>
        /// Initializes a new instance of the VitalAttributeReading class.
        /// </summary>
        public VitalAttributeReading()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VitalAttributeReading class.
        /// </summary>
        /// <param name="vitalid">Unique ID for this vital attribute reading.
        /// Used to update/delete this reading.</param>
        /// <param name="clinicalelementid">Key used to identify this
        /// particular vital attribute</param>
        /// <param name="source">The source of this reading.</param>
        /// <param name="sourceid">External key to source.</param>
        /// <param name="readingid">Numeric key used to tie related and
        /// distinguish separate readings. So the diastolic and systolic blood
        /// pressure should have the same readingid.
        /// </param>
        /// <param name="readingtaken">Date that the reading was taken.</param>
        /// <param name="unit">Unit that describes this vital's value.</param>
        /// <param name="value">The value of this reading. NOTE: for numeric
        /// values, the units are always in the 'native' units per the
        /// configuration.
        /// </param>
        /// <param name="code">Code indentifier for the reading.</param>
        /// <param name="codeset">Codeset of the code.</param>
        /// <param name="codedescription">Description of the code
        /// identifier.</param>
        /// <param name="createdby">The athenaNet username of the person who
        /// entered the vital.</param>
        /// <param name="createddate">The date this vital was entered into the
        /// chart. Returned in mm/dd/yyyy hh24:mi:ss format.
        /// </param>
        /// <param name="isgraphable">Flag indicating if this vital is
        /// graphable.</param>
        public VitalAttributeReading(int vitalid, PercentileSpec percentilespec = default(PercentileSpec), string clinicalelementid = default(string), string source = default(string), int? sourceid = default(int?), int? readingid = default(int?), string readingtaken = default(string), string unit = default(string), string value = default(string), string code = default(string), string codeset = default(string), string codedescription = default(string), string createdby = default(string), string createddate = default(string), bool? isgraphable = default(bool?))
        {
            Percentilespec = percentilespec;
            Vitalid = vitalid;
            Clinicalelementid = clinicalelementid;
            Source = source;
            Sourceid = sourceid;
            Readingid = readingid;
            Readingtaken = readingtaken;
            Unit = unit;
            Value = value;
            Code = code;
            Codeset = codeset;
            Codedescription = codedescription;
            Createdby = createdby;
            Createddate = createddate;
            Isgraphable = isgraphable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "percentilespec")]
        public PercentileSpec Percentilespec { get; set; }

        /// <summary>
        /// Gets or sets unique ID for this vital attribute reading. Used to
        /// update/delete this reading.
        /// </summary>
        [JsonProperty(PropertyName = "vitalid")]
        public int Vitalid { get; set; }

        /// <summary>
        /// Gets or sets key used to identify this particular vital attribute
        /// </summary>
        [JsonProperty(PropertyName = "clinicalelementid")]
        public string Clinicalelementid { get; set; }

        /// <summary>
        /// Gets or sets the source of this reading.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets external key to source.
        /// </summary>
        [JsonProperty(PropertyName = "sourceid")]
        public int? Sourceid { get; set; }

        /// <summary>
        /// Gets or sets numeric key used to tie related and distinguish
        /// separate readings. So the diastolic and systolic blood pressure
        /// should have the same readingid.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "readingid")]
        public int? Readingid { get; set; }

        /// <summary>
        /// Gets or sets date that the reading was taken.
        /// </summary>
        [JsonProperty(PropertyName = "readingtaken")]
        public string Readingtaken { get; set; }

        /// <summary>
        /// Gets or sets unit that describes this vital's value.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the value of this reading. NOTE: for numeric values,
        /// the units are always in the 'native' units per the configuration.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets code indentifier for the reading.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets codeset of the code.
        /// </summary>
        [JsonProperty(PropertyName = "codeset")]
        public string Codeset { get; set; }

        /// <summary>
        /// Gets or sets description of the code identifier.
        /// </summary>
        [JsonProperty(PropertyName = "codedescription")]
        public string Codedescription { get; set; }

        /// <summary>
        /// Gets or sets the athenaNet username of the person who entered the
        /// vital.
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public string Createdby { get; set; }

        /// <summary>
        /// Gets or sets the date this vital was entered into the chart.
        /// Returned in mm/dd/yyyy hh24:mi:ss format.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "createddate")]
        public string Createddate { get; set; }

        /// <summary>
        /// Gets or sets flag indicating if this vital is graphable.
        /// </summary>
        [JsonProperty(PropertyName = "isgraphable")]
        public bool? Isgraphable { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
