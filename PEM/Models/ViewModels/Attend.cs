

using Newtonsoft.Json;

namespace PEM.Models.ViewModels
{
    public partial class Attend
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("divisionId")]
        public string DivisionId { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("attendanceDate")]
        public DateTime AttendanceDate { get; set; }

        [JsonProperty("employeeName")]
        public string EmployeeName { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("timeIn")]
        public DateTime? TimeIn { get; set; }

        [JsonProperty("absent")]
        public string Absent { get; set; }

        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        [JsonProperty("lockedBy")]
        public string LockedBy { get; set; }

        [JsonProperty("lockTs")]
        public DateTime? LockTs { get; set; }

        [JsonProperty("latePeriod")]
        public DateTime? LatePeriod { get; set; }

        [JsonProperty("period")]
        public DateTime? Period { get; set; }

        [JsonProperty("shiftType")]
        public string ShiftType { get; set; }

        [JsonProperty("expectedTimeIn")]
        public DateTime? ExpectedTimeIn { get; set; }

        [JsonProperty("branchCode")]
        public string BranchCode { get; set; }

        [JsonProperty("clockOutTimeOut")]
        public DateTime? ClockOutTimeOut { get; set; }

        [JsonProperty("attendanceStatus")]
        public string AttendanceStatus { get; set; }

        [JsonProperty("clockedIn")]
        public bool? ClockedIn { get; set; }

        [JsonProperty("clockedOut")]
        public bool? ClockedOut { get; set; }

        [JsonProperty("geolocationAddress")]
        public string GeolocationAddress { get; set; }

        [JsonProperty("geoLongitude")]
        public string GeoLongitude { get; set; }

        [JsonProperty("geoLatitude")]
        public string GeoLatitude { get; set; }

        [JsonProperty("systemDate")]
        public DateTime? SystemDate { get; set; }

        [JsonProperty("geolocationAddress2")]
        public string GeolocationAddress2 { get; set; }
    }
}






























/*namespace PEM.Models
{
    public class AttendanceViewModel
    {


        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime ExpectedTimeIn { get; set; }
        public Nullable<bool> ClockedIn { get; set; }
        public DateTime? ClockOutTimeOut { get; set; } = DateTime.Now;
        *//*  { get; set; }
          public string Absent { get; set; }
          public string Remark { get; set; }
          public DateTime LockedBy { get; set; }
          public DateTime LockTs { get; set; }
          public DateTime LatePeriodf { get; set; }
          public string Period { get; set; }
          public string ShiftType { get; set; }
          public string ExpectedTimeIn { get; set; }
          public string BranchCode { get; set; }
          public string ClockOutTimeout { get; set; }
          public string AttendanceStatus { get; set; }
          public DateTime ClockIn { get; set; }
          public DateTime ClockOut { get; set; }
          public string GoelocationAddress { get; set; }
          public string Geolongititude { get; set; }
          public string Geolatitude { get; set; }
          public string SystemDate { get; set; }
          public string GeoLocationAddress { get; set; }
*//*
    }
}

*/