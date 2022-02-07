using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEM.Service
{
    public class AbsenteeismReportDetail
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime? DateAbsent { get; set; }
        /* "employeeId": "VPL/00661",
             "name": "Nuru",
             "dateAbsent": "2022-04-19T00:00:00"*/
    }
}
