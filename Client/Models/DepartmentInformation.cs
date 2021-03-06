// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AthenaHealth.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DepartmentInformation
    {
        /// <summary>
        /// Initializes a new instance of the DepartmentInformation class.
        /// </summary>
        public DepartmentInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DepartmentInformation class.
        /// </summary>
        public DepartmentInformation(IList<string> creditcardtypes, int timezoneoffset, string singleappointmentcontractmax = default(string), string state = default(string), bool? placeofservicefacility = default(bool?), string latitude = default(string), int? departmentid = default(int?), string address = default(string), string placeofservicetypeid = default(string), string longitude = default(string), string clinicals = default(string), int? timezone = default(int?), string name = default(string), string patientdepartmentname = default(string), string chartsharinggroupid = default(string), string placeofservicetypename = default(string), string zip = default(string), string timezonename = default(string), string communicatorbrandid = default(string), bool? medicationhistoryconsent = default(bool?), bool? ishospitaldepartment = default(bool?), string providergroupid = default(string), string portalurl = default(string), string city = default(string), bool? servicedepartment = default(bool?), string oneyearcontractmax = default(string), string fax = default(string), string providergroupname = default(string), string doesnotobservedst = default(string), string phone = default(string), IList<string> ecommercecreditcardtypes = default(IList<string>))
        {
            Creditcardtypes = creditcardtypes;
            Timezoneoffset = timezoneoffset;
            Singleappointmentcontractmax = singleappointmentcontractmax;
            State = state;
            Placeofservicefacility = placeofservicefacility;
            Latitude = latitude;
            Departmentid = departmentid;
            Address = address;
            Placeofservicetypeid = placeofservicetypeid;
            Longitude = longitude;
            Clinicals = clinicals;
            Timezone = timezone;
            Name = name;
            Patientdepartmentname = patientdepartmentname;
            Chartsharinggroupid = chartsharinggroupid;
            Placeofservicetypename = placeofservicetypename;
            Zip = zip;
            Timezonename = timezonename;
            Communicatorbrandid = communicatorbrandid;
            Medicationhistoryconsent = medicationhistoryconsent;
            Ishospitaldepartment = ishospitaldepartment;
            Providergroupid = providergroupid;
            Portalurl = portalurl;
            City = city;
            Servicedepartment = servicedepartment;
            Oneyearcontractmax = oneyearcontractmax;
            Fax = fax;
            Providergroupname = providergroupname;
            Doesnotobservedst = doesnotobservedst;
            Phone = phone;
            Ecommercecreditcardtypes = ecommercecreditcardtypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "creditcardtypes")]
        public IList<string> Creditcardtypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneoffset")]
        public int Timezoneoffset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "singleappointmentcontractmax")]
        public string Singleappointmentcontractmax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "placeofservicefacility")]
        public bool? Placeofservicefacility { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int? Departmentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "placeofservicetypeid")]
        public string Placeofservicetypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clinicals")]
        public string Clinicals { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public int? Timezone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patientdepartmentname")]
        public string Patientdepartmentname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "chartsharinggroupid")]
        public string Chartsharinggroupid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "placeofservicetypename")]
        public string Placeofservicetypename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezonename")]
        public string Timezonename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "communicatorbrandid")]
        public string Communicatorbrandid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "medicationhistoryconsent")]
        public bool? Medicationhistoryconsent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ishospitaldepartment")]
        public bool? Ishospitaldepartment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providergroupid")]
        public string Providergroupid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "portalurl")]
        public string Portalurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicedepartment")]
        public bool? Servicedepartment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oneyearcontractmax")]
        public string Oneyearcontractmax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providergroupname")]
        public string Providergroupname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "doesnotobservedst")]
        public string Doesnotobservedst { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ecommercecreditcardtypes")]
        public IList<string> Ecommercecreditcardtypes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Creditcardtypes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Creditcardtypes");
            }
        }
    }
}
