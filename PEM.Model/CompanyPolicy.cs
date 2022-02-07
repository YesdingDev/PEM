using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEM.Model
{
    public class CompanyPolicy
    {
        
        public string CompanyId { get; set; }

      
        public string DivisionId { get; set; }

       
        public string DepartmentId { get; set; }

        
        public long CompanyStdId { get; set; }

        
        public long TaxFiscalYear { get; set; }

       
        public long TaxPeriod { get; set; }

       
        public object ReliefOnGross { get; set; }

       
        public DateTimeOffset CurrentPeriod { get; set; }

       
        public long AverageWrkAge { get; set; }

        
        public long WorkingHrs { get; set; }

       
        public string PostingCompanyId { get; set; }

       
        public object PostingDivisionId { get; set; }

       
        public object PostingDepartmentId { get; set; }

        
        public object LockedBy { get; set; }

       
        public object LockTs { get; set; }

       
        public long WorkingDays { get; set; }

        
        public string TaxType { get; set; }

        
        public string ReliefType { get; set; }

      
        public bool Prorate { get; set; }

       
        public DateTimeOffset ResumptionTime { get; set; }

      
        public DateTimeOffset GraceTime { get; set; }

        
        public object MidMonthDate { get; set; }

       
        public DateTimeOffset MidMonthPeriod { get; set; }

        
        public long PorationBasis { get; set; }

       
        public object Email { get; set; }

       
        public object EmailClosed { get; set; }

      
        public long SalaryAccount { get; set; }

       
        public bool GrossUpNonStatutoryforTax { get; set; }

        public bool BioSaturday { get; set; }

       
        public bool BioSunday { get; set; }

       
        public long NoofLatenessAsAbsent { get; set; }

       
        public string JournalBasis { get; set; }

       
        public bool PostJvasSummary { get; set; }

        
        public bool ConsolidateBillPerCostCentre { get; set; }

      
        public bool LeaveDaysWithWeekends { get; set; }

        
        public string BranchCode { get; set; }

        
        public bool PayrollProcessed { get; set; }

      
        public object AutoPromotion { get; set; }
       
        public object EmployeeProbationPeriod { get; set; }

      
        public object PayeaccountName { get; set; }

        
        public object NhfaccountName { get; set; }

      
        public object PromotionInAyear { get; set; }

       
        public object DurationBeforeFirstPromotion { get; set; }

     
        public object TaxRulesSubjectValue { get; set; }

       
        public string HrreportPassword { get; set; }
    }
}

