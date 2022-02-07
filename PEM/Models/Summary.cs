using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace PEM.Models
{
    public class Summary
    {
       
        public string? EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TotalDaysAbsent { get; set; }
        public string TotalDaysPresent { get; set; }
        public string TotalDaysLate { get; set; }



    }




}