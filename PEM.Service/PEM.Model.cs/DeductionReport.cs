using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEM.Service
{
    public class DeductionReport
    {


        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string TimeInMinute { get; set; }
        /*  public DateTime Date { get; set; }
          public DateTime MissedPeriod { get; set; }*/
        /*
            "employeeId": "VPL/00659",
            "name": "OKPAKO",
            "timeInMinute": 0.0,
            "date": [],
            "missedPeriod": "0 days & 0 minutes"*/
    }
}
