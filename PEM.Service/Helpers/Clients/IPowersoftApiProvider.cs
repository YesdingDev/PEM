using PEM.Service.Helpers.POCO;
//using Microsoft.Extensions.Options;
//using PEM.Service.DomainModels;

namespace PEM.Service.Helpers.Clients
{
    //741258 THIS IS THE TOKEN. iT WAS PUT IN THE App settings file. If it doens.t work, that means it has been changed. THe same eason your login does not work on this same app
    public interface IPowersoftApiProvider
    {
        public Task<StatusMessage> Login(string username, string password);
        public Task<Response<IEnumerable<PFAType>>> GetAllPFAType();

        //public Task<Response<IEnumerable<Leave>>> GetAllLeave();
        public Task<StatusMessage> GetAllAttendance();
        public Task<Response<IEnumerable<AbseteeismReportSummary>>> GetAllAbseteeismReportSummary();
        public Task<Response<IEnumerable<AbsenteeismReportDetail>>> GetAllAbsenteeismReportDetail();
        public Task<Response<IEnumerable<DeductionReport>>> GetAllDeductionReport();
        public Task<Response<IEnumerable<LatenessReportDetails>>> GetAllLatenessReportDetails();
        /*        public Task<Response> GetAllLatenessReportSummary();
        */




        //public async Task<IActionResult> GetPayrollCompanyPolicy();
    }

}

