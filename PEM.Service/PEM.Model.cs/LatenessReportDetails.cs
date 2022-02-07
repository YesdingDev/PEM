using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEM.Service
{
    public class LatenessReportDetails
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime TimeInMinute { get; set; }

        /*
        "employeeId": "VPL/00462",
            "name": "Tunde",
            "date": "2022-04-19T08:52:08.67",
            "timeInMinutes": 52.0*/
    }
}
