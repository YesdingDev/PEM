using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace PEM.Models
{
    public class Employee
    {
        public string AttendanceDate { get; set; }
       
        public string? EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string AttendanceStatus { get; set; }
        public bool ClockedIn { get; set; }
        public bool ClockedOut { get; set; }
        public string TimeInAddress { get; set; }
        public string TimeOutAddress2 { get; set; }
        
    }

  

    
}