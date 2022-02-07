//using Microsoft.Extensions.Options;
//using PEM.Service.DomainModels;

namespace PEM.Service.Helpers.Clients
{
    public static class APIEndpointUrl
    {
        #region Account API
        public const string Login = "Login";
        public const string ResetCustomerPassword = "ResetCustomerPassword";
        #endregion

        


        public const string GetAllPFAType = "API/GetPayrollPFAType";
        public const string GetAllAttendance = "GetAttendance";
        public const string AddPayrollPFAType = "AddPayrollPFAType";
        public const string GetPayrollCompanyPolicy = "GetPayrollCompanyPolicy";
        public const string GetAllAbseteeismReportSummary = "api/GetAbsenteeismReportSummary";
        public const string GetAllAbsenteeismReportDetail = "API/GetAbsenteeismReportDetail";
        public const string GetAllDeductionReport = "API/GetDeductionReport";
        public const string GetAllLatenessReportDetails = "API/GetLatenessReportDetails";
        public const string GetAllLatenessReportSummary = "API/GetLatenessReportSummary";








    }
}
