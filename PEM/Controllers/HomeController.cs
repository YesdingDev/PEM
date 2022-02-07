using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PEM.Models;
using PEM.Service.Helpers.Clients;
using Syncfusion.XlsIO;
using System.Diagnostics;
using System.Net.Mime;
using PEM.Service;
using PEM.Models;
using System.Diagnostics;
using PEM.Service.Helpers.POCO;
using DevExtreme.AspNet.Data;
using PEM.Models.ViewModels;

namespace PEM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IPowersoftApiProvider apiProvider;

        public HomeController(ILogger<HomeController> logger, IPowersoftApiProvider apiProvider) //this interface lets you access the environment root
        {
            _logger = logger;
            this.apiProvider = apiProvider;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Attendance()
        {
            return View();
        }


        /*        Attendance start here
        */

        public async Task<IActionResult> GetAttendance(DevExtreme.AspNet.Mvc.DataSourceLoadOptions loadOptions)
        {
            try
            {
                StatusMessage statusMessage = new StatusMessage();
                List<Attend> attends = new List<Attend>();

                statusMessage = await apiProvider.GetAllAttendance();

                attends = statusMessage.data.ToObject<List<Attend>>();

                return Json(DataSourceLoader.Load(attends, loadOptions));
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        /*  public async Task<IActionResult> Attendance()
          {
              var attendance = await apiProvider.GetAllAttendance();
              var attendanceViewModelList = attendance.Data.Select(att => MapAttendance(att));
              return View(attendanceViewModelList);
          }

          private AttendanceViewModel MapAttendance(Attendance att) =>
              new AttendanceViewModel
              {
                  CompanyId = att.CompanyId,
                  DivisionId = att.DivisionId,
                  DepartmentId = att.DepartmentId,
                  EmployeeId = att.EmployeeId,
                  ClockedIn = att.ClockedIn,
                  EmployeeName = att.EmployeeName,
                  AttendanceDate = att.AttendanceDate,
                  ClockOutTimeOut = att.ClockOutTimeOut,*/

        /*       };
           public async Task<IActionResult> ExportAttendanceData()
           {
               var attendance = await apiProvider.GetAllAttendance();
               IEnumerable<Attendance>? attendanceData = attendance.Data;
               return ExportDataToCSV(attendanceData, "AttendanceData.CSV");*/
    
        /*        Attendance end
        */
        /*AbseteeismReportSummary start here
        */
        public async Task<IActionResult> AbseteeismReportSummary()
        {
            var abseteeism = await apiProvider.GetAllAbseteeismReportSummary();
            var abseteeismViewModelList = abseteeism.Data.Select(abs => MapAbseteeism(abs));

            return View(abseteeismViewModelList);

        }

        private AbseteeismReportSummaryViewModel MapAbseteeism(AbseteeismReportSummary abs) =>
            new AbseteeismReportSummaryViewModel
            {
                EmployeeId = abs.EmployeeId,
                Name = abs.Name,
                Days = abs.Days,
            };
        public async Task<IActionResult> ExportAbseteeismReportSummaryData()
        {
            var abseteeism = await apiProvider.GetAllAbseteeismReportSummary();
            IEnumerable<AbseteeismReportSummary>? abseteeismData = abseteeism.Data;
            return ExportDataToCSV(abseteeismData, "AbseteeismReportSummaryData.CSV");
        }


        /*AbseteeismReportSummary ends here
         * 
*/
        /*AbseteeismReportDetail start here
*/
        public async Task<IActionResult> AbsenteeismReportDetail()
        {
            var absenteeism = await apiProvider.GetAllAbsenteeismReportDetail();
            var absenteeismReportDetailViewModels = absenteeism.Data.Select(abn => MapAbsenteeism(abn));
            return View(absenteeismReportDetailViewModels);

        }
        private AbsenteeismReportDetailViewModel MapAbsenteeism(AbsenteeismReportDetail abn) =>
            new AbsenteeismReportDetailViewModel
            {
                EmployeeId = abn.EmployeeId,
                Name = abn.Name,
                DateAbsent = abn.DateAbsent,
            };
        public async Task<IActionResult> ExportAbsenteeismReportDetailData()
        {
            var absenteeism = await apiProvider.GetAllAbsenteeismReportDetail(); 
            IEnumerable<AbsenteeismReportDetail>? absenteeismData = absenteeism.Data;
            return ExportDataToCSV(absenteeismData, "AbsenteeismReportDetailData.CSV"); 
        }
        /*AbseteeismReportSummary Ends here
*/
        public async Task<IActionResult> DeductionReport()
        {
            var deduction = await apiProvider.GetAllDeductionReport();
            var deductionReportViewModelList = deduction.Data.Select(ded => MapDeduction(ded));
            return View(deductionReportViewModelList);
        }
        private DeductionReportViewModel MapDeduction(DeductionReport ded) =>
            new DeductionReportViewModel
            {
                EmployeeId = ded.EmployeeId,
                Name = ded.Name,
                TimeInMinute = ded.TimeInMinute,
            };
        public async Task<IActionResult> ExportDeductionReportData()
        {
            var deduction = await apiProvider.GetAllDeductionReport();
            IEnumerable<DeductionReport>? deductionData = deduction.Data;
            return ExportDataToCSV(deductionData, "DeductionReportData.CSV");
        }
        /*        LatenessReportDetails start here
        */
        public async Task<IActionResult> LatenessReportDetails()
        {
            var lateness = await apiProvider.GetAllLatenessReportDetails();
            var latenessReportDetailsViewModelList = lateness.Data.Select(lat => MapLateness(lat));
            return View(latenessReportDetailsViewModelList);
        }
        private LatenessReportDetailsViewModel MapLateness(LatenessReportDetails lat) =>
            new LatenessReportDetailsViewModel
            {
                EmployeeId = lat.EmployeeId,
                Name = lat.Name,
                DateTime = lat.DateTime,
                TimeInMinute = lat.TimeInMinute,
            };
        public async Task<IActionResult> ExportLatenessReportDetailsData()
        {
            var lateness = await apiProvider.GetAllLatenessReportDetails();
            IEnumerable<LatenessReportDetails>? latenessData = lateness.Data;
            return ExportDataToCSV(latenessData, "LatenessReportDetailsData.CSV");
        }

        /*        LatenessReportDetails ends here
        */


        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Calender()
        {
            return View();
        }

        public IActionResult Enter_Loan_Type()
        {
            return View();
        }


        public IActionResult Leave_Type()
        {
            return View();
        }

        public IActionResult Group_Type()
        {
            return View();
        }


        public IActionResult New_Employee()
        {
            return View();

        }

        public IActionResult Absenteesim_Report()
        {
            return View();

        }


        public IActionResult Lateness_Report()
        {
            return View();

        }
        public IActionResult Lateness_Summary()
        {
            return View();

        }


        public async Task<IActionResult> Enter_PFA_Types()
        {
            var result = await apiProvider.GetAllPFAType();
            var pfaTypes = result.Data;

            var pfaTypeVMList = new List<PfaTypeViewModel>()
            {

            };
            foreach (var pfaType in pfaTypes)
            {


                var pfaTypeVM = new PfaTypeViewModel();
                pfaTypeVM.PFAId = pfaType.pfaid;
                pfaTypeVM.PFADescription = pfaType.pfadescription;

                pfaTypeVMList.Add(pfaTypeVM);
            }

            return View(pfaTypeVMList);
        }

        public IActionResult Designation_Type()
        {
            return View();
        }

        public IActionResult Enter_And_View_Job()
        {
            return View();
        }
        public IActionResult Enter_Department_Type()
        {
            return View();
        }
        public IActionResult Enter_Type_of_Nationalty()
        {
            return View();
        }



        private FileStreamResult ExportDataToCSV<T>(IEnumerable<T> data, string fileName)
        {
            var csvFile = GetCSVFile(data);
            return this.File(fileStream: csvFile,
                contentType: MediaTypeNames.Application.Octet,
                fileDownloadName: fileName);
        }
        public async Task<IActionResult> ExportEmployeeData()
        {
            IEnumerable<Employee>? employeeList = await GetEmployeeList();

            return ExportDataToCSV(employeeList, "EmployeeData.CSV");
        }

        public async Task<IActionResult> ExportSummaryData()
        {
            IEnumerable<Summary>? summaryData = await GetSummaryList();

            return ExportDataToCSV(summaryData, "SummaryData.CSV");
        }


        private Stream GetCSVFile<T>(IEnumerable<T> exportData)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2013;
                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet worksheet = workbook.Worksheets[0];

                //Import data to worksheet
                worksheet.ImportData
                    (exportData,
                    firstRow: 1,
                    firstColumn: 1,
                    includeHeader: true);

                if (exportData.Any())
                {
                    worksheet.UsedRange.AutofitColumns();
                    worksheet.UsedRange.AutofitRows();
                }

                //Creating stream object.
                var stream = new MemoryStream();
                workbook.SaveAs(stream, ",");

                stream.Position = 0;

                workbook.Close();
                return stream;
            }
        }



        public async Task<IActionResult> Daily_Report() 
        {

            try
            {
                IEnumerable<Employee>? employeeList = await GetEmployeeList();
                return View(employeeList); 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View(new List<Employee>());
            }
        }

        private static async Task<IEnumerable<Employee>> GetEmployeeList()
        {
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{"Employee.json"}"); /*Path.Combine(environment.ContentRootPath, "wwwroot", "Employee.json");*/ //the path is incorrect
            /*Console.WriteLine(jsonPath);*/
            var employeeJson = await System.IO.File.ReadAllTextAsync(jsonPath); //please movce the empson file to wwrrot folder
            var employeeList = JsonConvert.DeserializeObject<IEnumerable<Employee>>(employeeJson); //linq
            return employeeList;
        }

        public async Task<IActionResult> Summary_Report()
        {

            try
            {
                IEnumerable<Summary>? SummaryList = await GetSummaryList();
                return View(SummaryList);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message);
                return View(new List<Summary>());

            }


        }

        private static async Task<IEnumerable<Summary>> GetSummaryList()
        {
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{"Summary.json"}");

            var SummaryJson = await System.IO.File.ReadAllTextAsync(jsonPath);
            var SummaryList = JsonConvert.DeserializeObject<IEnumerable<Summary>>(SummaryJson);
            return SummaryList;
        }





        /* public async Task<IActionResult> Daily_Report() 

         {

             var deb = JsonSerializer.Deserialize<Employee>(jsonString);
             return View();
         }*/


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
