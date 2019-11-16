// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AppointmentClaim
    {
        /// <summary>
        /// Initializes a new instance of the AppointmentClaim class.
        /// </summary>
        public AppointmentClaim()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppointmentClaim class.
        /// </summary>
        /// <param name="referringproviderid">The referring provider ID for
        /// this claim. See /referringproviders. This is not the same as the ID
        /// from the /providers call.</param>
        /// <param name="primaryinsurancepayer">The status and notes of a
        /// responsible payer. This payer is the primary insurace.</param>
        /// <param name="secondaryinsurancepayer">The status and notes of a
        /// responsible payer. This payer is the secondary insurace.</param>
        /// <param name="diagnoses">message</param>
        /// <param name="claimcreateddate">The date the claim was
        /// created.</param>
        /// <param name="procedures">Procedures is an array of all procedures.
        /// /ccda is a better clinical representation. These fields are:
        /// </param>
        /// <param name="billedservicedate">The billed date of service.</param>
        /// <param name="billedproviderid">The provider ID of the billing
        /// provider for this claim.</param>
        /// <param name="appointmentid">The appointment ID associated with this
        /// claim.</param>
        /// <param name="chargeamount">The total amount billed for all services
        /// from this claim.</param>
        /// <param name="transactionid">A unique ID for the primary transaction
        /// this claim represents. May be useful for debugging.</param>
        /// <param name="claimid">athenaNet's internal ID for this claim,
        /// specific to the practice.</param>
        public AppointmentClaim(int? referringproviderid = default(int?), AppointmentInsurancePayer primaryinsurancepayer = default(AppointmentInsurancePayer), AppointmentInsurancePayer secondaryinsurancepayer = default(AppointmentInsurancePayer), IList<AppointmentDiagnosis> diagnoses = default(IList<AppointmentDiagnosis>), string claimcreateddate = default(string), IList<AppointmentProcedure> procedures = default(IList<AppointmentProcedure>), string billedservicedate = default(string), int? billedproviderid = default(int?), int? appointmentid = default(int?), string chargeamount = default(string), int? transactionid = default(int?), int? claimid = default(int?))
        {
            Referringproviderid = referringproviderid;
            Primaryinsurancepayer = primaryinsurancepayer;
            Secondaryinsurancepayer = secondaryinsurancepayer;
            Diagnoses = diagnoses;
            Claimcreateddate = claimcreateddate;
            Procedures = procedures;
            Billedservicedate = billedservicedate;
            Billedproviderid = billedproviderid;
            Appointmentid = appointmentid;
            Chargeamount = chargeamount;
            Transactionid = transactionid;
            Claimid = claimid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the referring provider ID for this claim. See
        /// /referringproviders. This is not the same as the ID from the
        /// /providers call.
        /// </summary>
        [JsonProperty(PropertyName = "referringproviderid")]
        public int? Referringproviderid { get; set; }

        /// <summary>
        /// Gets or sets the status and notes of a responsible payer. This
        /// payer is the primary insurace.
        /// </summary>
        [JsonProperty(PropertyName = "primaryinsurancepayer")]
        public AppointmentInsurancePayer Primaryinsurancepayer { get; set; }

        /// <summary>
        /// Gets or sets the status and notes of a responsible payer. This
        /// payer is the secondary insurace.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryinsurancepayer")]
        public AppointmentInsurancePayer Secondaryinsurancepayer { get; set; }

        /// <summary>
        /// Gets or sets message
        /// </summary>
        [JsonProperty(PropertyName = "diagnoses")]
        public IList<AppointmentDiagnosis> Diagnoses { get; set; }

        /// <summary>
        /// Gets or sets the date the claim was created.
        /// </summary>
        [JsonProperty(PropertyName = "claimcreateddate")]
        public string Claimcreateddate { get; set; }

        /// <summary>
        /// Gets or sets procedures is an array of all procedures. /ccda is a
        /// better clinical representation. These fields are:
        ///
        /// </summary>
        [JsonProperty(PropertyName = "procedures")]
        public IList<AppointmentProcedure> Procedures { get; set; }

        /// <summary>
        /// Gets or sets the billed date of service.
        /// </summary>
        [JsonProperty(PropertyName = "billedservicedate")]
        public string Billedservicedate { get; set; }

        /// <summary>
        /// Gets or sets the provider ID of the billing provider for this
        /// claim.
        /// </summary>
        [JsonProperty(PropertyName = "billedproviderid")]
        public int? Billedproviderid { get; set; }

        /// <summary>
        /// Gets or sets the appointment ID associated with this claim.
        /// </summary>
        [JsonProperty(PropertyName = "appointmentid")]
        public int? Appointmentid { get; set; }

        /// <summary>
        /// Gets or sets the total amount billed for all services from this
        /// claim.
        /// </summary>
        [JsonProperty(PropertyName = "chargeamount")]
        public string Chargeamount { get; set; }

        /// <summary>
        /// Gets or sets a unique ID for the primary transaction this claim
        /// represents. May be useful for debugging.
        /// </summary>
        [JsonProperty(PropertyName = "transactionid")]
        public int? Transactionid { get; set; }

        /// <summary>
        /// Gets or sets athenaNet's internal ID for this claim, specific to
        /// the practice.
        /// </summary>
        [JsonProperty(PropertyName = "claimid")]
        public int? Claimid { get; set; }

    }
}
