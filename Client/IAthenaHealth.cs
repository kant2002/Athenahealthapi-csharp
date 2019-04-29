// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.AuthenaHealth.Client
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IAthenaHealth : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Variant of the API
        /// </summary>
        string Apivariant { get; set; }

        /// <summary>
        /// Id of the practice
        /// </summary>
        int Practiceid { get; set; }

        /// <summary>
        /// Number of entries to return (default 1500, max 5000)
        /// </summary>
        int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Client API version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Get available practice IDs
        /// </summary>
        /// <param name='limit'>
        /// Number of entries to return (default 1500, max 5000)
        /// </param>
        /// <param name='offset'>
        /// Starting point of entries; 0-indexed
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PracticesInformationList>> GetPracticeInfoWithHttpMessagesAsync(int? limit = default(int?), int? offset = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get department IDs
        /// </summary>
        /// <param name='limit'>
        /// Number of entries to return (default 1500, max 5000)
        /// </param>
        /// <param name='offset'>
        /// Starting point of entries; 0-indexed
        /// </param>
        /// <param name='hospitalonly'>
        /// If set to true, return hospital only departments.
        /// </param>
        /// <param name='showalldepartments'>
        /// By default, departments hidden in the portal do not appear. When
        /// this is set to true, that restriction is not applied. Default is
        /// false.
        /// </param>
        /// <param name='providerlist'>
        /// If set to true, list providers who see patients in this department.
        /// Default is false.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<DepartmentInformationList>> GetDepartmentsWithHttpMessagesAsync(int? limit = default(int?), int? offset = default(int?), bool? hospitalonly = default(bool?), bool? showalldepartments = default(bool?), bool? providerlist = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Search for patients
        /// </summary>
        /// <param name='departmentid'>
        /// Primary (registration) department ID.
        /// </param>
        /// <param name='firstname'>
        /// First name of the patient to find.
        /// </param>
        /// <param name='lastname'>
        /// Last name of the patient to find.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PatientInformationList>> GetPatientsWithHttpMessagesAsync(int? departmentid = default(int?), string firstname = default(string), string lastname = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Register new patient
        /// </summary>
        /// <param name='address1'>
        /// Patient's address - 1st line (Max length: 100)
        /// </param>
        /// <param name='address2'>
        /// Patient's address - 2nd line (Max length: 100)
        /// </param>
        /// <param name='city'>
        /// Patient's city (Max length: 30)
        /// </param>
        /// <param name='departmentid'>
        /// Primary (registration) department ID.
        /// </param>
        /// <param name='dob'>
        /// Patient's DOB (mm/dd/yyyy)
        /// </param>
        /// <param name='email'>
        /// Patient's email address. 'declined' can be used to indicate just
        /// that.
        /// </param>
        /// <param name='firstname'>
        /// Patient's first name
        /// </param>
        /// <param name='homephone'>
        /// The patient's home phone number. Invalid numbers in a GET will be
        /// ignored. Patient phone numbers and other data may change, and one
        /// phone number may be associated with multiple patients. You are
        /// responsible for taking additional steps to verify patient identity
        /// and for using this data in accordance with applicable law,
        /// including HIPAA. Only phone numbers that exist in the North
        /// American Naming Plan (NANP) are acceptable for input.
        /// </param>
        /// <param name='lastname'>
        /// Patient's last name
        /// </param>
        /// <param name='mobilephone'>
        /// The patient's mobile phone number. On input, 'declined' can be used
        /// to indicate no number. (Alternatively, hasmobile can also be set to
        /// false. "declined" simply does this for you.) Invalid numbers in a
        /// GET will be ignored. Patient phone numbers and other data may
        /// change, and one phone number may be associated with multiple
        /// patients. You are responsible for taking additional steps to verify
        /// patient identity and for using this data in accordance with
        /// applicable law, including HIPAA. Only phone numbers that exist in
        /// the North American Naming Plan (NANP) are acceptable for input.
        /// </param>
        /// <param name='state'>
        /// Patient's state (2 letter abbreviation)
        /// </param>
        /// <param name='zip'>
        /// Patient's zip. Matching occurs on first 5 characters.
        /// </param>
        /// <param name='sex'>
        /// Patient's sex (M/F)
        /// </param>
        /// <param name='race'>
        /// The patient race, using the 2.16.840.1.113883.5.104 codeset. See
        /// http://www.hl7.org/implement/standards/fhir/terminologies-v3.html
        /// Special case: use "declined" to indicate that the patient declined
        /// to answer. Multiple values or a tab-seperated list of codes is
        /// acceptable for multiple races for input. The first race will be
        /// considered "primary". Note: you must update all values at once if
        /// you update any.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> CreatePatientWithHttpMessagesAsync(string address1 = default(string), string address2 = default(string), string city = default(string), int? departmentid = default(int?), string dob = default(string), string email = default(string), string firstname = default(string), string homephone = default(string), string lastname = default(string), string mobilephone = default(string), string state = default(string), string zip = default(string), string sex = default(string), string race = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get a patients by ID
        /// </summary>
        /// <param name='patientId'>
        /// Id of the patient for which get information
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<PatientInformation>>> GetPatientByIdWithHttpMessagesAsync(int patientId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get a providers
        /// </summary>
        /// <param name='name'>
        /// Id of the patient for which get information
        /// </param>
        /// <param name='providertype'>
        /// The provider type to filter the results on. Valid provider type
        /// values can be found by using GET /reference/providertypes.
        /// </param>
        /// <param name='showallproviderids'>
        /// In athenaNet's internal data structures, a single provider can be
        /// represented by multiple IDs. These IDs are used in certain external
        /// messages (e.g. HL7) and thus these IDs may need to be known by the
        /// API user as well. When set to true, a list of all of these
        /// ancillary IDs will be provided.
        /// </param>
        /// <param name='showusualdepartmentguessthreshold'>
        /// There are situations where determining where a provider "normally"
        /// practices is desired. Unfortuantely, there is no such concept in
        /// athenaNet since providers often practice in multiple locations.
        /// However, we can use some intelligence to determine this by looking
        /// back over the previous few months (90 days) to see actual practice.
        /// To enable this, set this value between 0 and 1; it is highly
        /// recommended to be at least .5. This is the ratio of appointments in
        /// a given department to the total number of appointments for that
        /// provider. A value of .5 means "the provider's appointments are 50%
        /// in the department guessed." Setting this to 1 would only return a
        /// department if ALL of the provider's appointments were in one
        /// department.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ProvidersInformationList>> GetProvidersWithHttpMessagesAsync(string name = default(string), string providertype = default(string), bool? showallproviderids = default(bool?), int? showusualdepartmentguessthreshold = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create new provider
        /// </summary>
        /// <param name='billable'>
        /// This provider is a supervising provider and is credentialed to bill
        /// for services.
        /// </param>
        /// <param name='entitytypeid'>
        /// The entity type of provider. 1 = person, 2 = non-person
        /// </param>
        /// <param name='medicalgroupid'>
        /// The medical group of the provider.
        /// </param>
        /// <param name='providergroupid'>
        /// The provider group of the provider.
        /// </param>
        /// <param name='schedulingname'>
        /// The scheduling name of the provider.
        /// </param>
        /// <param name='signatureonfileflag'>
        /// This provider's signature is on file.
        /// </param>
        /// <param name='alternatephone'>
        /// The phone number of the provider.
        /// </param>
        /// <param name='ansicode'>
        /// The provider taxonomy code of the provider.
        /// </param>
        /// <param name='billednamecase'>
        /// The billing name of the provider.
        /// </param>
        /// <param name='communicatordisplayname'>
        /// The communicator display name for the provider.
        /// </param>
        /// <param name='communicatorhomedepartment'>
        /// The communicator home department for the provider.
        /// </param>
        /// <param name='crdreferring'>
        /// This provider is a Coordinator referring provider.
        /// </param>
        /// <param name='createencounteroncheckin'>
        /// Automatically create encounters at check-in.
        /// </param>
        /// <param name='directaddress'>
        /// The direct email address for the provider.
        /// </param>
        /// <param name='firstname'>
        /// The first name of the provider.
        /// </param>
        /// <param name='hideinportal'>
        /// Hide this provider in the Patient Portal.
        /// </param>
        /// <param name='lastname'>
        /// The last name of the provider.
        /// </param>
        /// <param name='middleinitial'>
        /// The middle name of the provider.
        /// </param>
        /// <param name='namesuffix'>
        /// The suffix of the provider.
        /// </param>
        /// <param name='ndctatnumber'>
        /// The NDC TAT number for this provider.
        /// </param>
        /// <param name='npinumber'>
        /// The NPI of the provider.
        /// </param>
        /// <param name='practiceroleid'>
        /// The practice role ID for the provider.
        /// </param>
        /// <param name='providerprofileid'>
        /// The provider profile of the provider (integer or 'NEW')
        /// </param>
        /// <param name='providertype'>
        /// The abbreviation for the provider type of the provider. (e.g., MD,
        /// NP). See GET /reference/providertypes for a mapping of abbreviation
        /// to provider type.
        /// </param>
        /// <param name='reportingname'>
        /// The reporting name for the provider.
        /// </param>
        /// <param name='scheduleresourcetypeid'>
        /// The scheduling resource type id of the provider.
        /// </param>
        /// <param name='schedulingnote'>
        /// The scheduling note for the provider.
        /// </param>
        /// <param name='sex'>
        /// The sex of the provider (M or F)
        /// </param>
        /// <param name='specialtyid'>
        /// The specialty ID of the provider. See GET
        /// /reference/providerspecialties for a mapping of ID to specialty
        /// name.
        /// </param>
        /// <param name='ssn'>
        /// The SSN of the provider.
        /// </param>
        /// <param name='staffbucket'>
        /// Create a staff bucket for this provider.
        /// </param>
        /// <param name='supervisingproviderid'>
        /// The supervising provider ID for this provider.
        /// </param>
        /// <param name='supervisingprovidertype'>
        /// If set to self,set supervisingprovider to itself.
        /// </param>
        /// <param name='trackmissingslips'>
        /// This provider renders services that should be tracked on the
        /// Missing Slips Worklist.
        /// </param>
        /// <param name='username'>
        /// The username for the provider.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> CreateProviderWithHttpMessagesAsync(bool billable, int entitytypeid, int medicalgroupid, int providergroupid, string schedulingname, bool signatureonfileflag, string alternatephone = default(string), string ansicode = default(string), string billednamecase = default(string), string communicatordisplayname = default(string), int? communicatorhomedepartment = default(int?), bool? crdreferring = default(bool?), bool? createencounteroncheckin = default(bool?), string directaddress = default(string), string firstname = default(string), bool? hideinportal = default(bool?), string lastname = default(string), string middleinitial = default(string), string namesuffix = default(string), string ndctatnumber = default(string), int? npinumber = default(int?), int? practiceroleid = default(int?), string providerprofileid = default(string), string providertype = default(string), string reportingname = default(string), int? scheduleresourcetypeid = default(int?), string schedulingnote = default(string), string sex = default(string), string specialtyid = default(string), int? ssn = default(int?), bool? staffbucket = default(bool?), int? supervisingproviderid = default(int?), string supervisingprovidertype = default(string), bool? trackmissingslips = default(bool?), string username = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Information about a single patient's appointment by id
        /// </summary>
        /// <param name='appointmentId'>
        /// Id of the appointment.
        /// </param>
        /// <param name='ignorerestrictions'>
        /// When showing patient detail for appointments, the patient
        /// information for patients with record restrictions and blocked
        /// patients will not be shown. Setting this flag to true will show
        /// that information for those patients.
        /// </param>
        /// <param name='showclaimdetail'>
        /// Include claim information, if available, associated with an
        /// appointment.
        /// </param>
        /// <param name='showcopay'>
        /// By default, the expected co-pay is returned. For performance
        /// purposes, you can set this to false and copay will not be
        /// populated.
        /// </param>
        /// <param name='showexpectedprocedurecodes'>
        /// Show the expetcted procedurecodes.
        /// </param>
        /// <param name='showinsurance'>
        /// Include patient insurance information. Shows insurance packages for
        /// the appointment if any are selected, and all patient packages
        /// otherwise.
        /// </param>
        /// <param name='showpatientdetail'>
        /// Include patient information for each patient associated with an
        /// appointment.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<AppointmentInformation>>> GetAppointmentByIdWithHttpMessagesAsync(int appointmentId, bool? ignorerestrictions = default(bool?), bool? showclaimdetail = default(bool?), bool? showcopay = default(bool?), bool? showexpectedprocedurecodes = default(bool?), bool? showinsurance = default(bool?), bool? showpatientdetail = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Set Information about a single patient's appointment by id
        /// </summary>
        /// <param name='patientid'>
        /// The athenaNet patient ID.
        /// </param>
        /// <param name='appointmentId'>
        /// Id of the appointment.
        /// </param>
        /// <param name='appointmenttypeid'>
        /// The appointment type to be booked. This field should never be used
        /// for booking appointments for web-based scheduling. The use of this
        /// field is reserved for digital check-in (aka "kiosk") or an
        /// application used by practice staff. One of this or reasonid is
        /// required.
        /// </param>
        /// <param name='bookingnote'>
        /// A note from the patient about why this appointment is being booked
        /// </param>
        /// <param name='departmentid'>
        /// The athenaNet department ID.
        /// </param>
        /// <param name='donotsendconfirmationemail'>
        /// For clients with athenaCommunicator, certain appointment types can
        /// be configured to have an appointment confirmation email sent to the
        /// patient at time of appointment booking. If this parameter is set to
        /// true, that email will not be sent. This should only be used if you
        /// plan on sending a confirmation email via another method.
        /// </param>
        /// <param name='ignoreschedulablepermission'>
        /// By default, we allow booking of appointments marked as schedulable
        /// via the web. This flag allows you to bypass that restriction for
        /// booking.
        /// </param>
        /// <param name='insurancecompany'>
        /// The name of the insurance company.
        /// </param>
        /// <param name='insurancegroupid'>
        /// If available, any identifier for the insurance group.
        /// </param>
        /// <param name='insuranceidnumber'>
        /// The insurance identifier for this individual patient.
        /// </param>
        /// <param name='insurancenote'>
        /// Any extra information provided by the patient about insurance
        /// coverage.
        /// </param>
        /// <param name='insurancephone'>
        /// The phone number for the insurance company.
        /// </param>
        /// <param name='insuranceplanname'>
        /// The insurance plan name (e.g. "HMO Blue").
        /// </param>
        /// <param name='insurancepolicyholder'>
        /// The full name of the insurance policy holder.
        /// </param>
        /// <param name='nopatientcase'>
        /// By default, we create a patient case upon booking an appointment
        /// for new patients. Setting this to true bypasses that patient case.
        /// </param>
        /// <param name='reasonid'>
        /// The appointment reason ID to be booked. This field is required for
        /// booking appointments for web-based scheduling and is a reason that
        /// is retrieved from the /patientappointmentreasons call.
        /// </param>
        /// <param name='urgentyn'>
        /// Set this field in order to set the urgent flag in athena (if the
        /// practice settings allow for this).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> BookAppointmentByIdWithHttpMessagesAsync(int patientid, int appointmentId, int? appointmenttypeid = default(int?), string bookingnote = default(string), int? departmentid = default(int?), bool? donotsendconfirmationemail = default(bool?), bool? ignoreschedulablepermission = default(bool?), string insurancecompany = default(string), string insurancegroupid = default(string), string insuranceidnumber = default(string), string insurancenote = default(string), string insurancephone = default(string), string insuranceplanname = default(string), string insurancepolicyholder = default(string), bool? nopatientcase = default(bool?), int? reasonid = default(int?), bool? urgentyn = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get booked appointments
        /// </summary>
        /// <param name='appointmentstatus'>
        /// Filter appointments by status.
        /// </param>
        /// <param name='appointmenttypeid'>
        /// Filter by appointment type ID.
        /// </param>
        /// <param name='departmentid'>
        /// The athenaNet department ID.
        /// </param>
        /// <param name='enddate'>
        /// End of the appointment search date range (mm/dd/yyyy). Inclusive.
        /// </param>
        /// <param name='endlastmodified'>
        /// Identify appointments modified prior to this date/time (mm/dd/yyyy
        /// hh:mi:ss). Inclusive. Note: This can only be used if a
        /// startlastmodified value is supplied as well.
        /// </param>
        /// <param name='ignorerestrictions'>
        /// When showing patient detail for appointments, the patient
        /// information for patients with record restrictions and blocked
        /// patients will not be shown. Setting this flag to true will show
        /// that information for those patients.
        /// </param>
        /// <param name='patientid'>
        /// The athenaNet patient ID. If operating in a Provider Group
        /// Enterprise practice, this should be the enterprise patient ID.
        /// </param>
        /// <param name='providerid'>
        /// The athenaNet provider ID. Multiple IDs (either as a comma
        /// delimited list or multiple POSTed values) are allowed.
        /// </param>
        /// <param name='scheduledenddate'>
        /// End of the appointment scheduled search date range (mm/dd/yyyy).
        /// Inclusive.
        /// </param>
        /// <param name='scheduledstartdate'>
        /// Start of the appointment scheduled search date range (mm/dd/yyyy).
        /// Inclusive.
        /// </param>
        /// <param name='showcancelled'>
        /// Include appointments that have been cancelled.
        /// </param>
        /// <param name='showclaimdetail'>
        /// Include claim information, if available, associated with an
        /// appointment.
        /// </param>
        /// <param name='showcopay'>
        /// By default, the expected co-pay is returned. For performance
        /// purposes, you can set this to false and copay will not be
        /// populated.
        /// </param>
        /// <param name='showexpectedprocedurecodes'>
        /// Show the expetcted procedurecodes.
        /// </param>
        /// <param name='showinsurance'>
        /// Include patient insurance information. Shows insurance packages for
        /// the appointment if any are selected, and all patient packages
        /// otherwise.
        /// </param>
        /// <param name='showpatientdetail'>
        /// Include patient information for each patient associated with an
        /// appointment.
        /// </param>
        /// <param name='showremindercalldetail'>
        /// Include all remindercall related results, if available, associated
        /// with an appointment.
        /// </param>
        /// <param name='startdate'>
        /// Start of the appointment search date range (mm/dd/yyyy). Inclusive.
        /// </param>
        /// <param name='startlastmodified'>
        /// Identify appointments modified after this date/time (mm/dd/yyyy
        /// hh:mi:ss). Inclusive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AppointmentInformationList>> GetBookedAppointmentsWithHttpMessagesAsync(string appointmentstatus = default(string), int? appointmenttypeid = default(int?), int? departmentid = default(int?), string enddate = default(string), string endlastmodified = default(string), bool? ignorerestrictions = default(bool?), int? patientid = default(int?), string providerid = default(string), string scheduledenddate = default(string), string scheduledstartdate = default(string), bool? showcancelled = default(bool?), bool? showclaimdetail = default(bool?), bool? showcopay = default(bool?), bool? showexpectedprocedurecodes = default(bool?), bool? showinsurance = default(bool?), bool? showpatientdetail = default(bool?), bool? showremindercalldetail = default(bool?), string startdate = default(string), string startlastmodified = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Provides the ability to add new open appointment slots
        /// </summary>
        /// <param name='appointmentdate'>
        /// The appointment date for the new open appointment slot
        /// (mm/dd/yyyy).
        /// </param>
        /// <param name='appointmenttime'>
        /// The time (hh24:mi) for the new appointment slot. Multiple times
        /// (either as a comma delimited list or multiple POSTed values) are
        /// allowed. 24 hour time.
        /// </param>
        /// <param name='departmentid'>
        /// The athenaNet department ID.
        /// </param>
        /// <param name='providerid'>
        /// The athenaNet provider ID.
        /// </param>
        /// <param name='appointmenttypeid'>
        /// The appointment type ID to be created. Either this or a reason must
        /// be provided.
        /// </param>
        /// <param name='reasonid'>
        /// The appointment reason (/patientappointmentreasons) to be created.
        /// Either this or a raw appointment type ID must be provided.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> OpenNewAppointmentWithHttpMessagesAsync(string appointmentdate, string appointmenttime, int departmentid, int providerid, int? appointmenttypeid = default(int?), int? reasonid = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get appointment types
        /// </summary>
        /// <param name='hidegeneric'>
        /// By default, we show both generic and non-generic types. Setting
        /// this to true will hide the generic types (and show only non-generic
        /// types).
        /// </param>
        /// <param name='hidenongeneric'>
        /// By default, we show both generic and non-generic types. Setting
        /// this to true will hide non-generic types (and show only generic
        /// types).
        /// </param>
        /// <param name='hidenonpatient'>
        /// This defaults to true if not specified, and thus will hide
        /// non-patient facing types. Setting this to false would thus show
        /// non-patient facing types.
        /// </param>
        /// <param name='hidetemplatetypeonly'>
        /// By default, we show both "template only" and not-template only
        /// types. Setting this to true, the results will omit template only
        /// types. ("Template only" is a setting that makes the type appear in
        /// schedules, but forces users to select a non-template type upon
        /// booking.)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AppointmentTypeInformationList>> GetAppointmentTypesWithHttpMessagesAsync(bool? hidegeneric = default(bool?), bool? hidenongeneric = default(bool?), bool? hidenonpatient = default(bool?), bool? hidetemplatetypeonly = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates new appointment type
        /// </summary>
        /// <param name='duration'>
        /// The expected duration, in minutes, of the appointment type. Note,
        /// this value cannot be changed after creation, so please choose
        /// carefully.
        /// </param>
        /// <param name='name'>
        /// The name of the appointment type. Maximum length of 30 characters.
        /// </param>
        /// <param name='patient'>
        /// If set to true, this type serves as a "patient" type, meaning that
        /// is is a type that can be used for booking patients. If set to
        /// false, then it this type will not be used for patient (e.g. "Lunch"
        /// or "Vacation"). Non-patient types are mostly used to reserving time
        /// for providers to not see patients.
        /// </param>
        /// <param name='shortname'>
        /// The short name code of the appointment type. Maximum length of 4
        /// characters. Used for making schedule templates. Note, this value
        /// cannot be changed after creation, so please choose carefully.
        /// </param>
        /// <param name='generic'>
        /// If set to true, this type serves as a "generic" type, that will
        /// match any type when searching. Defaults to false.
        /// </param>
        /// <param name='templatetypeonly'>
        /// If set to true, this type serves as a "template-only" type, meaning
        /// that it can be used for building schedule templates,  but cannot be
        /// used for booking appointments (i.e. another type must be chosen).
        /// Defaults to false.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> CreateAppointmentTypeWithHttpMessagesAsync(int duration, string name, bool patient, string shortname, bool? generic = default(bool?), bool? templatetypeonly = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
