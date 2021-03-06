// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProviderInformation
    {
        /// <summary>
        /// Initializes a new instance of the ProviderInformation class.
        /// </summary>
        public ProviderInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderInformation class.
        /// </summary>
        /// <param name="providerid">The ID to be used for this provider. Note
        /// that in athenaNet, an individual provider (as defined by a unique
        /// NPI) may have multiple provider IDs. For the API, we have collapsed
        /// these to a single canonical ID.
        /// </param>
        /// <param name="billable">Indicates if this is a billable
        /// provider.</param>
        /// <param name="ansispecialtycode">This is the ANSI code for this
        /// provider's specialty.</param>
        /// <param name="firstname">The provider's first name.</param>
        /// <param name="entitytype">Either "Person" or "Non-Person" (e.g.
        /// X-Ray machines)</param>
        /// <param name="otherprovideridlist">When showallproviderids is set to
        /// true, a list of all other athenaNet providers IDs that may refer to
        /// this same provider. If not present with showallproviderids, there
        /// are no other IDs other than the primary ID.
        /// </param>
        /// <param name="ansinamecode">This is the ANSI name with ANSI code for
        /// this provider's specialty.</param>
        /// <param name="displayname">The preferred name to use when displaying
        /// this provider.</param>
        /// <param name="homedepartment">For certain purposes, this can be
        /// considered to be the "home" or default department for a
        /// provider.</param>
        /// <param name="providertypeid">This is just the ID (a text string)
        /// such as "NP" or "NP S" for the provider type.</param>
        /// <param name="providerusername">The username of the
        /// provider.</param>
        /// <param name="supervisingproviderid">The ID of the supervising
        /// provider.</param>
        /// <param name="providertype">There is a long potential list of
        /// provider type in the form "full name (id)",  but "MD", "NP" or "NP
        /// S" (Nurse Practitioner (Supervising)), "RES" (resident), "EQUIP",
        /// "DO", "PA" or "PASUP" (Physician's Assistant (Supervising)),
        /// "TECH", "RN", LPT", "CRNA" or "CRNASUP" (Certified Registered Nurse
        /// Anesthesiologist (Supervising)), and MA (Medical Assistant) are
        /// among the most common.
        /// </param>
        /// <param name="createencounterprovideridlist">A list of provider IDs
        /// for this provider NPI that will create an encounter when the
        /// appointment is checked in  for encounter supported appointment
        /// types. Only populated if 'showallproviderids' is set.
        /// </param>
        /// <param name="schedulingname">The scheduling name for this provider
        /// (as used in athenaNet).</param>
        /// <param name="usualdepartmentid">The "usual" department for this
        /// provider, if SHOWUSUALDEPARTMENTGUESSTHRESHOLD is set.</param>
        /// <param name="createencounteroncheckinyn">If true, appointments
        /// scheduled with this provider will create an encounter when the
        /// appointment is checked infor encounter supported appointment types.
        /// Only applies to the primary providerid. If the provider has other
        /// IDs with the same API, please use 'showallproviderids' to see which
        /// IDs create encounters.
        /// </param>
        /// <param name="specialty">A friendly name for this provider's
        /// specialty.</param>
        /// <param name="hideinportalyn">If set, this provider does not appear
        /// in athenaCommunicator's web portal.
        /// </param>
        /// <param name="lastname">The provider's last name.</param>
        /// <param name="npi">The NPI for this provider, if available.</param>
        /// <param name="providergrouplist">When showallproviderids is set to
        /// true, a list of all provider groups that this provider is
        /// registered in. Data is only relevant if a practice is using
        /// Provider-Group-Based Data Permissions in their practice.
        /// </param>
        /// <param name="federalidnumber">The federal ID number for provider,
        /// if SHOWFEDERALIDNUMBER is set.</param>
        /// <param name="supervisingproviderusername">The username of the
        /// supervising provider.</param>
        public ProviderInformation(int providerid, bool? billable = default(bool?), string ansispecialtycode = default(string), string firstname = default(string), string entitytype = default(string), string otherprovideridlist = default(string), string ansinamecode = default(string), string displayname = default(string), string homedepartment = default(string), string providertypeid = default(string), string providerusername = default(string), int? supervisingproviderid = default(int?), string providertype = default(string), string createencounterprovideridlist = default(string), string schedulingname = default(string), string usualdepartmentid = default(string), bool? createencounteroncheckinyn = default(bool?), string specialty = default(string), bool? hideinportalyn = default(bool?), string lastname = default(string), long? npi = default(long?), string providergrouplist = default(string), string federalidnumber = default(string), string supervisingproviderusername = default(string))
        {
            Billable = billable;
            Ansispecialtycode = ansispecialtycode;
            Firstname = firstname;
            Entitytype = entitytype;
            Otherprovideridlist = otherprovideridlist;
            Ansinamecode = ansinamecode;
            Displayname = displayname;
            Homedepartment = homedepartment;
            Providerid = providerid;
            Providertypeid = providertypeid;
            Providerusername = providerusername;
            Supervisingproviderid = supervisingproviderid;
            Providertype = providertype;
            Createencounterprovideridlist = createencounterprovideridlist;
            Schedulingname = schedulingname;
            Usualdepartmentid = usualdepartmentid;
            Createencounteroncheckinyn = createencounteroncheckinyn;
            Specialty = specialty;
            Hideinportalyn = hideinportalyn;
            Lastname = lastname;
            Npi = npi;
            Providergrouplist = providergrouplist;
            Federalidnumber = federalidnumber;
            Supervisingproviderusername = supervisingproviderusername;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates if this is a billable provider.
        /// </summary>
        [JsonProperty(PropertyName = "billable")]
        public bool? Billable { get; set; }

        /// <summary>
        /// Gets or sets this is the ANSI code for this provider's specialty.
        /// </summary>
        [JsonProperty(PropertyName = "ansispecialtycode")]
        public string Ansispecialtycode { get; set; }

        /// <summary>
        /// Gets or sets the provider's first name.
        /// </summary>
        [JsonProperty(PropertyName = "firstname")]
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or sets either "Person" or "Non-Person" (e.g. X-Ray machines)
        /// </summary>
        [JsonProperty(PropertyName = "entitytype")]
        public string Entitytype { get; set; }

        /// <summary>
        /// Gets or sets when showallproviderids is set to true, a list of all
        /// other athenaNet providers IDs that may refer to this same provider.
        /// If not present with showallproviderids, there are no other IDs
        /// other than the primary ID.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "otherprovideridlist")]
        public string Otherprovideridlist { get; set; }

        /// <summary>
        /// Gets or sets this is the ANSI name with ANSI code for this
        /// provider's specialty.
        /// </summary>
        [JsonProperty(PropertyName = "ansinamecode")]
        public string Ansinamecode { get; set; }

        /// <summary>
        /// Gets or sets the preferred name to use when displaying this
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "displayname")]
        public string Displayname { get; set; }

        /// <summary>
        /// Gets or sets for certain purposes, this can be considered to be the
        /// "home" or default department for a provider.
        /// </summary>
        [JsonProperty(PropertyName = "homedepartment")]
        public string Homedepartment { get; set; }

        /// <summary>
        /// Gets or sets the ID to be used for this provider. Note that in
        /// athenaNet, an individual provider (as defined by a unique NPI) may
        /// have multiple provider IDs. For the API, we have collapsed these to
        /// a single canonical ID.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "providerid")]
        public int Providerid { get; set; }

        /// <summary>
        /// Gets or sets this is just the ID (a text string) such as "NP" or
        /// "NP S" for the provider type.
        /// </summary>
        [JsonProperty(PropertyName = "providertypeid")]
        public string Providertypeid { get; set; }

        /// <summary>
        /// Gets or sets the username of the provider.
        /// </summary>
        [JsonProperty(PropertyName = "providerusername")]
        public string Providerusername { get; set; }

        /// <summary>
        /// Gets or sets the ID of the supervising provider.
        /// </summary>
        [JsonProperty(PropertyName = "supervisingproviderid")]
        public int? Supervisingproviderid { get; set; }

        /// <summary>
        /// Gets or sets there is a long potential list of provider type in the
        /// form "full name (id)",  but "MD", "NP" or "NP S" (Nurse
        /// Practitioner (Supervising)), "RES" (resident), "EQUIP", "DO", "PA"
        /// or "PASUP" (Physician's Assistant (Supervising)), "TECH", "RN",
        /// LPT", "CRNA" or "CRNASUP" (Certified Registered Nurse
        /// Anesthesiologist (Supervising)), and MA (Medical Assistant) are
        /// among the most common.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "providertype")]
        public string Providertype { get; set; }

        /// <summary>
        /// Gets or sets a list of provider IDs for this provider NPI that will
        /// create an encounter when the appointment is checked in  for
        /// encounter supported appointment types. Only populated if
        /// 'showallproviderids' is set.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "createencounterprovideridlist")]
        public string Createencounterprovideridlist { get; set; }

        /// <summary>
        /// Gets or sets the scheduling name for this provider (as used in
        /// athenaNet).
        /// </summary>
        [JsonProperty(PropertyName = "schedulingname")]
        public string Schedulingname { get; set; }

        /// <summary>
        /// Gets or sets the "usual" department for this provider, if
        /// SHOWUSUALDEPARTMENTGUESSTHRESHOLD is set.
        /// </summary>
        [JsonProperty(PropertyName = "usualdepartmentid")]
        public string Usualdepartmentid { get; set; }

        /// <summary>
        /// Gets or sets if true, appointments scheduled with this provider
        /// will create an encounter when the appointment is checked infor
        /// encounter supported appointment types. Only applies to the primary
        /// providerid. If the provider has other IDs with the same API, please
        /// use 'showallproviderids' to see which IDs create encounters.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "createencounteroncheckinyn")]
        public bool? Createencounteroncheckinyn { get; set; }

        /// <summary>
        /// Gets or sets a friendly name for this provider's specialty.
        /// </summary>
        [JsonProperty(PropertyName = "specialty")]
        public string Specialty { get; set; }

        /// <summary>
        /// Gets or sets if set, this provider does not appear in
        /// athenaCommunicator's web portal.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "hideinportalyn")]
        public bool? Hideinportalyn { get; set; }

        /// <summary>
        /// Gets or sets the provider's last name.
        /// </summary>
        [JsonProperty(PropertyName = "lastname")]
        public string Lastname { get; set; }

        /// <summary>
        /// Gets or sets the NPI for this provider, if available.
        /// </summary>
        [JsonProperty(PropertyName = "npi")]
        public long? Npi { get; set; }

        /// <summary>
        /// Gets or sets when showallproviderids is set to true, a list of all
        /// provider groups that this provider is registered in. Data is only
        /// relevant if a practice is using Provider-Group-Based Data
        /// Permissions in their practice.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "providergrouplist")]
        public string Providergrouplist { get; set; }

        /// <summary>
        /// Gets or sets the federal ID number for provider, if
        /// SHOWFEDERALIDNUMBER is set.
        /// </summary>
        [JsonProperty(PropertyName = "federalidnumber")]
        public string Federalidnumber { get; set; }

        /// <summary>
        /// Gets or sets the username of the supervising provider.
        /// </summary>
        [JsonProperty(PropertyName = "supervisingproviderusername")]
        public string Supervisingproviderusername { get; set; }

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
