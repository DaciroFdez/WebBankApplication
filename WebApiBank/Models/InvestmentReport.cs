using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class InvestmentReport
    {
        [Key] public int id { get; set; }
        public int investmentId { get; set;}

        public virtual InvestmentAccount Investment {  get; set; }
    }
}
