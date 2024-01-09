using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class InvestmentReport
    {
        [Key] public int InvestmentReportId { get; set; }
        public int InvestmentId { get; set;}

        public virtual InvestmentAccount Investment {  get; set; }
    }
}
