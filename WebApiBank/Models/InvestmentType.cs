using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class InvestmentType : Base
    {
        [Key]
        public int Id { get; set; }
        public string InvestmentName { get; set; }

        public virtual ICollection<InvestmentAccount> Account { get; set; }
    }
}
