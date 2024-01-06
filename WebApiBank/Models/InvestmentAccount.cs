using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class InvestmentAccount : Base
    {
        [Key] public int Id { get; set; }
        public int Amount { get; set; }
        public int AccountId { get; set; }
        public int InvestmentTypeId { get; set; }

        public virtual Account Account { get; set; }
        public virtual InvestmentType InvestmentType { get; set; }
        public virtual ICollection<InvestmentReport> Investments { get; set; }
    }
}
